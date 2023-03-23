using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsInput.Native;
using WindowsInput;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;



namespace macro
{


    public partial class femhook : Form
    {

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration

        [DllImport("User32.dll")]
        public static extern long SetCursorPos(int x, int y);



        bool mouseDown;
        private Point offsets;
        InputSimulator sim = new InputSimulator();
        public femhook()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var buttondown = sim.InputDeviceState.IsKeyDown(VirtualKeyCode.VK_Z);
            if (buttondown)
            {
                sim.Mouse.LeftButtonDown();
                sim.Keyboard.Sleep(10);
                sim.Mouse.LeftButtonUp();
                sim.Keyboard.KeyPress(VirtualKeyCode.XBUTTON2);
                sim.Mouse.LeftButtonDown();
                sim.Mouse.LeftButtonUp();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            macrobutton.Location = new Point(-100, 294);
            triggerwallbutton.Location = new Point(-100, 294);
            layerrushbutton.Location = new Point(-100, 294);
            tunnelbutton.Location = new Point(-100, 294);
            towerbutton.Location = new Point(-100, 294);
            norecoilbutton.Location = new Point(-100, 294);
            panel2.Location = new Point(142, 65);
            astolfobutton.Location = new Point(15, 86);
        }


        private void mainbutton_Click(object sender, EventArgs e)
        {
            macrobutton.Location = new Point(15, 86);
            triggerwallbutton.Location = new Point(15, 109);
            layerrushbutton.Location = new Point(15, 132);
            tunnelbutton.Location = new Point(15, 155);
            towerbutton.Location = new Point(15, 178);
            norecoilbutton.Location = new Point(16, 201);
            panel2.Location = new Point(15, 65);
            astolfobutton.Location = new Point(-100, 294);
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            var buttondown = sim.InputDeviceState.IsKeyDown(VirtualKeyCode.VK_X);
            if (buttondown)
            {
                sim.Keyboard.KeyPress(VirtualKeyCode.LSHIFT);
                sim.Keyboard.Sleep(10);
                sim.Mouse.LeftButtonDown();
                sim.Keyboard.Sleep(10);
                sim.Mouse.LeftButtonUp();

            }
        }


        private void macrobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (macrobutton.Checked)
            {
                macro.Start();
            }
            else
            {
                macro.Stop();
            }
        }

        private void hidebutton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(254, 28);
        }

        private void hidebutton_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(254, 28);
            if (hidebutton.Checked)
            {
                this.Size = new Size(254, 28);
            }
            else
            {
                this.Size = new Size(254, 311);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (hidebutton.Checked)
            {
                hidebutton.Checked = false;

            }
            else
            {
                hidebutton.Checked = true;
            }
        }



        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offsets.X = e.X;
            offsets.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offsets.X, currentScreenPos.Y - offsets.Y);
            }
        }

        private void mouseUp_event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void takewallbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerwallbutton.Checked)
            {
                triggerwall.Start();
            }
            else
            {
                triggerwall.Stop();
            }
        }

        private void layerrushbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (layerrushbutton.Checked)
            {
                ramprush.Start();
            }
            else
            {
                ramprush.Stop();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            if (btBind.Text == "...")
            {


                if (GetAsyncKeyState(Keys.Escape) < 0)

                {
                    btBind.Text = "none";

                }

                else

                {
                    btBind.Text = e.KeyCode.ToString();

                }
            }
        }

        private void btBind_Click(object sender, EventArgs e)
        {
            btBind.Text = "...";
        }

        private void bindedit_Tick(object sender, EventArgs e)
        {

        }

        private void ramprush_Tick(object sender, EventArgs e)
        {
            var buttondown = sim.InputDeviceState.IsKeyDown(VirtualKeyCode.VK_N);
            if (buttondown)
            {
                sim.Keyboard.KeyPress(VirtualKeyCode.XBUTTON2);
                sim.Keyboard.Sleep(10);
                sim.Mouse.LeftButtonDown();
                sim.Mouse.LeftButtonDown();
                sim.Keyboard.Sleep(10);
 
                sim.Keyboard.KeyPress(VirtualKeyCode.XBUTTON1);
                sim.Keyboard.Sleep(10);
                sim.Mouse.LeftButtonDown();
                sim.Mouse.LeftButtonDown();
                sim.Keyboard.Sleep(625);
            }
        }

        private void tower_Tick(object sender, EventArgs e)
        {
            var buttondown = sim.InputDeviceState.IsKeyDown(VirtualKeyCode.VK_N);
            if (buttondown)
            {
                sim.Mouse.LeftButtonDown();
                sim.Keyboard.KeyPress(VirtualKeyCode.XBUTTON1);
                sim.Keyboard.Sleep(100);
                SetCursorPos(2500, 500);
                sim.Keyboard.KeyPress(VirtualKeyCode.XBUTTON2);
                sim.Keyboard.Sleep(100);
            }

        }

        private void towerbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (towerbutton.Checked)
            {
                tower.Start();
            }
            else
            {
                tower.Stop();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (astolfobutton.Checked)
            {
                astolfo.Location = new Point(131, 132);
            }
            else
            {
                astolfo.Location = new Point(-200, 294);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
