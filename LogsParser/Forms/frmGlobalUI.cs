using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;
using System.Diagnostics;

namespace LogsParser {
    public partial class frmGlobalUI : Form {
        #region Form functions
        public IEnumerable<Control> GetSelfAndChildrenRecursive(Control parent)
        {
            List<Control> controls = new List<Control>();
            foreach (Control child in parent.Controls)
            {
                controls.AddRange(GetSelfAndChildrenRecursive(child));
            }
            controls.Add(parent);
            return controls;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute( "user32.dll" )]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute( "user32.dll" )]
        public static extern bool ReleaseCapture();

        /*
        Constants in Windows API
        0x84 = WM_NCHITTEST - Mouse Capture Test
        0x1 = HTCLIENT - Application Client Area
        0x2 = HTCAPTION - Application Title Bar

        This function intercepts all the commands sent to the application. 
        It checks to see of the message is a mouse click in the application. 
        It passes the action to the base action by default. It reassigns 
        the action to the title bar if it occured in the client area
        to allow the drag and move behavior.
        */

        protected override void WndProc(ref Message m) {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;

            const UInt32 HTLEFT = 10;
            const UInt32 HTRIGHT = 11;
            const UInt32 HTBOTTOMRIGHT = 17;
            const UInt32 HTBOTTOM = 15;
            const UInt32 HTBOTTOMLEFT = 16;
            const UInt32 HTTOP = 12;
            const UInt32 HTTOPLEFT = 13;
            const UInt32 HTTOPRIGHT = 14;

            const int RESIZE_HANDLE_SIZE = 10;
            bool handled = false;
            if ( m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE ) {
                Size formSize = this.Size;
                Point screenPoint = new Point( m.LParam.ToInt32() );
                Point clientPoint = this.PointToClient( screenPoint );

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
            {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
            {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
        };

                foreach ( KeyValuePair<UInt32, Rectangle> hitBox in boxes ) {
                    if ( hitBox.Value.Contains( clientPoint ) ) {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if ( !handled )
                base.WndProc( ref m );
        }

        private void MouseMove_Window(object sender, MouseEventArgs e) {
            if ( e.Button == MouseButtons.Left ) {
                ReleaseCapture();
                SendMessage( Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0 );
            }
        }

        private void btn_Window_Close_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_Window_Minimize_Click(object sender, EventArgs e) {
            base.WindowState = FormWindowState.Minimized;
        }

        private void btn_Window_Resize_Click(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
            else
            {
                base.WindowState = FormWindowState.Normal;
            }
        }

        #endregion

        #region Lists
        public List<SFM.ListInterface> pListItems, pListBuffs, pListPets, pListMonster, pListSkills;
        private BindingList<string> pListCharacters;
        #endregion

        #region Initiations
        public frmGlobalUI() {
            InitializeComponent();
            XColors.CURRENT_COLOR = (XColorStyle)Properties.Settings.Default.nStyle;
            ChangeStyle();
            mainMenu.Renderer = new ToolStripColors();
            Benchmark( Initiation, 1 );
        }

        public void Initiation() {
            SFM.OnApplicationStartup();
            //LoadLists();
        }

        private void Benchmark(Action act, int iterations) {
            GC.Collect();
            //act.Invoke(); // run once outside of loop to avoid initialization costs
            Stopwatch sw = Stopwatch.StartNew();
            for ( int i = 0; i < iterations; i++ ) {
                act.Invoke();
            }
            sw.Stop();
            lbBenchmark.Text += string.Format( "Loaded in {0}ms!", ( sw.ElapsedMilliseconds / iterations ).ToString() );
        }

        public void LoadLists() {
            pListItems = SFM.ReadFile( "items.txt", dgvItems );
            pListBuffs = SFM.ReadFile( "buffs.txt", dgvBuffs );
            pListMonster = SFM.ReadFile( "monster.txt", dgvMonster );
            pListCharacters = SFM.ReadCharacter( "characters.txt" );
        }
        #endregion

        #region Search function
        private void SearchGridView(object sender, EventArgs e) {
            List<SFM.ListInterface> pList = null;
            DataGridView dgv = null;
            string search = "";
            if ( sender.Equals( btnSearchItems ) ) {
                pList = pListItems;
                dgv = dgvItems;
                search = tbItemsSearch.Text;
            }
            else if ( sender.Equals( btnBuffsSearch ) ) {
                pList = pListBuffs;
                dgv = dgvBuffs;
                search = tbBuffsSearch.Text;
            }
            else if ( sender.Equals( btnMonsterSearch ) ) {
                pList = pListMonster;
                dgv = dgvMonster;
                search = tbMonsterSearch.Text;
            }
          
            var pSearch = pList.FindAll( i => i.Name.ToLower().Contains( search.ToLower() ) );
            SFM.UpdateDataGridView( dgv, pSearch );
        }

        private void ResetGridView(object sender, EventArgs e) {
            
            //if ( sender.Equals( btnBuffsResetList ) )
            //    SFM.UpdateDataGridView( dgvBuffs, pListBuffs );
            //else if ( sender.Equals( btnMonsterResetList ) )
            //    SFM.UpdateDataGridView( dgvMonster, pListMonster );
          
                return;
        }

        #endregion

       

        #region GUI-Events


        private void tsmiDatabase_Click(object sender, EventArgs e) {
            frmDatabase dbForm = new frmDatabase( this );
            dbForm.ShowDialog();
        }


        private void ChangeStyle()
        {
            if (XColors.CURRENT_COLOR == XColorStyle.Blue)
            {
                GetSelfAndChildrenRecursive(this).OfType<XButton>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Blue);
                GetSelfAndChildrenRecursive(this).OfType<XPanel>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Blue);
                GetSelfAndChildrenRecursive(this).OfType<XTabControl>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Blue);
                GetSelfAndChildrenRecursive(this).OfType<XDataGridView>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Blue);
                GetSelfAndChildrenRecursive(this).OfType<XListBox>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Blue);
                GetSelfAndChildrenRecursive(this).OfType<XComboBox>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Blue);
                pbLogo.Image = global::LogsParser.Properties.Resources.GM_ToolBlue;
                pbMX.Image = global::LogsParser.Properties.Resources.GM_ToolBlueAbout;
            }
            else
            {
                GetSelfAndChildrenRecursive(this).OfType<XButton>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Red);
                GetSelfAndChildrenRecursive(this).OfType<XPanel>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Red);
                GetSelfAndChildrenRecursive(this).OfType<XTabControl>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Red);
                GetSelfAndChildrenRecursive(this).OfType<XDataGridView>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Red);
                GetSelfAndChildrenRecursive(this).OfType<XListBox>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Red);
                GetSelfAndChildrenRecursive(this).OfType<XComboBox>().ToList().ForEach(b => b.ColorStyle = XColorStyle.Red);
                pbLogo.Image = global::LogsParser.Properties.Resources.GM_ToolRed;
                pbMX.Image = global::LogsParser.Properties.Resources.GM_ToolRedAbout;
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        /// <summary>
        /// Выйти из приложения
        /// </summary>
        private void Exit()
        {
            this.Close();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            XColors.CURRENT_COLOR = XColors.CURRENT_COLOR == XColorStyle.Blue ? XColorStyle.Red : XColorStyle.Blue;
            ChangeStyle();
        }

        private void frmGlobalGUI_Closed(object sender, FormClosedEventArgs e) {
            Properties.Settings.Default.nStyle = (int)XColors.CURRENT_COLOR;
            Properties.Settings.Default.Save();
        }

        private void CopyrightClicked(object sender, EventArgs e) {
            //Process.Start( "http://xijezu.com/" );
        }

        private void useOldPetListToolStripMenuItem_CheckStateChanged(object sender, EventArgs e) {
            MessageBox.Show( "You might have to load a new list into the tool when it's using the wrong one.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
            
        }
        #endregion
    }
}