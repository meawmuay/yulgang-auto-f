using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Yulgang_Auto_F
{
    public partial class Form : System.Windows.Forms.Form
    {
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern IntPtr GetForegroundWindow();

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int GetWindowText(System.IntPtr hWnd, System.Text.StringBuilder lpString, int cch);

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        private uint _pid;
        private Boolean _botStatus;
        private uint _botTime1;
        private uint _botTime2;
        private IntPtr _handleWindow;
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            //Set title
            this.Text = @"Yulgang Auto F " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            comboBoxButton1.Items.Add(new ComboboxItemF() { Text = "-", Value = 0 });
            comboBoxButton2.Items.Add(new ComboboxItemF() { Text = "-", Value = 0 });

            uint[] fs = {0x3B,0x3C,0x3D,0x3E,0x3F,0x40,0x41,0x42,0x43,0x44};
            for( int i = 1; i <= 10; i++ )
            {
                comboBoxButton1.Items.Add(new ComboboxItemF() { Text = "F" + i, Value = fs[i - 1] });
                comboBoxButton2.Items.Add(new ComboboxItemF() { Text = "F" + i, Value = fs[i - 1] });
            }

            comboBoxButton1.SelectedIndex = 0;
            comboBoxButton2.SelectedIndex = 0;

            comboBoxTime1.Items.Add(new ComboboxItemTime() { Text = "1 นาที", Value = 1 });
            comboBoxTime1.Items.Add(new ComboboxItemTime() { Text = "5 นาที", Value = 5 });
            comboBoxTime1.Items.Add(new ComboboxItemTime() { Text = "10 นาที", Value = 10 });
            comboBoxTime1.Items.Add(new ComboboxItemTime() { Text = "20 นาที", Value = 20 });
            comboBoxTime1.Items.Add(new ComboboxItemTime() { Text = "30 นาที", Value = 30 });
            comboBoxTime1.SelectedIndex = 0;

            comboBoxTime2.Items.Add(new ComboboxItemTime() { Text = "1 นาที", Value = 1 });
            comboBoxTime2.Items.Add(new ComboboxItemTime() { Text = "5 นาที", Value = 5 });
            comboBoxTime2.Items.Add(new ComboboxItemTime() { Text = "10 นาที", Value = 10 });
            comboBoxTime2.Items.Add(new ComboboxItemTime() { Text = "20 นาที", Value = 20 });
            comboBoxTime2.Items.Add(new ComboboxItemTime() { Text = "30 นาที", Value = 30 });
            comboBoxTime2.SelectedIndex = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"โปรแกรมนี้สร้างโดย แมวหมวย\nหากคุณพบปัญหา กรุณาติดต่อเราเพื่อแก้ไข", @"เกี่ยวกับ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timerFindPID_Tick(object sender, EventArgs e)
        {
            System.Text.StringBuilder title = new System.Text.StringBuilder(256);
            IntPtr handleWindow = GetForegroundWindow();
            GetWindowText(handleWindow, title, title.Capacity);

            Status("รอเลือกหน้าจอเกม...");

            if( title.ToString().StartsWith("YGOnline") )
            {
                GetWindowThreadProcessId(handleWindow, out _pid);
                _handleWindow = handleWindow;
                labelPID.Text = _pid.ToString();
                labelYulgang.Text = title.ToString();
                timerFindPID.Enabled = false;
                Status("...");
            }
        }

        private void Status(String message)
        {
            toolStripStatusLabel.Text = message;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if( timerFindPID.Enabled == false )
            {
                timerFindPID.Enabled = true;
            }
            else
            {
                timerFindPID.Enabled = false;
            }
            Status("...");
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            if( _botStatus )
            {
                Stop();
            }
            else
            {
                if( _pid == 0 )
                {
                    MessageBox.Show(@"เลือกหน้าจอเกมก่อน!", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Start();
                }
            }
        }

        private void Start()
        {
            _botStatus = true;
            buttonStart.Text = @"หยุดทำงาน";
            comboBoxTime1.Enabled = false;
            comboBoxTime2.Enabled = false;
            comboBoxButton1.Enabled = false;
            comboBoxButton2.Enabled = false;
            _botTime1 = 5;
            _botTime2 = 0;
            timerBot1.Enabled = true;
            timerBot2.Enabled = true;
        }
        private void Stop()
        {
            _botStatus = false;
            buttonStart.Text = @"เริ่มทำงาน";
            timerBot1.Enabled = false;
            timerBot2.Enabled = false;
            labelTimeout1.Text = @"-";
            labelTimeout2.Text = @"-";
            comboBoxTime1.Enabled = true;
            comboBoxTime2.Enabled = true;
            comboBoxButton1.Enabled = true;
            comboBoxButton2.Enabled = true;
            Status(@"หยุดทำงาน");
        }

        private void timerBot1_Tick(object sender, EventArgs e)
        {
            Status(@"กำลังทำงาน...");
            _botTime1 = _botTime1 + 1;

            if( _botTime1 % ( ( (ComboboxItemTime)comboBoxTime1.SelectedItem ).Value * 60 ) == 0
                && comboBoxButton1.SelectedIndex > 0 )
            {
                Console.WriteLine(@"Bot 1 Tick");
                SetForegroundWindow(_handleWindow);
                Thread.Sleep(20);
                var f = ((ComboboxItemF) comboBoxButton1.SelectedItem).Value;
                Keyboard.SendKey(0x9D, false);
                Keyboard.SendKey(f, false);
                Thread.Sleep(20);
                Keyboard.SendKey(f, true);
                Keyboard.SendKey(0x9D, true);
            }

            labelTimeout1.Text = _botTime1.ToString() + @" วินาที";

        }

        private void timerBot2_Tick(object sender, EventArgs e)
        {
            Status(@"กำลังทำงาน...");
            _botTime2 = _botTime2 + 1;

            if( _botTime2 % ( ( (ComboboxItemTime)comboBoxTime2.SelectedItem ).Value * 60 ) == 0
                  && comboBoxButton2.SelectedIndex > 0 )
            {
                Console.WriteLine(@"Bot 2 Tick");
                SetForegroundWindow(_handleWindow);
                Thread.Sleep(20);
                var f = ((ComboboxItemF) comboBoxButton2.SelectedItem).Value;
                Keyboard.SendKey(0x9D, false);
                Keyboard.SendKey(f, false);
                Thread.Sleep(20);
                Keyboard.SendKey(f, true);
                Keyboard.SendKey(0x9D, true);
            }
            labelTimeout2.Text = _botTime2.ToString() + @" วินาที";

        }
    }
}
