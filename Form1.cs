using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCountDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(doCountDown)).Start();
                  
        }
        void doCountDown()
        {
            for (int i = 3; i > 0; i--)
            {
                setCountDownText( "GAME STARTS IN: " + i);
                System.Threading.Thread.Sleep(1000);
            }
            MessageBox.Show("Start Play");
        }
        void setCountDownText(string txtValue)
        {
            if (Countdown.InvokeRequired)
            {
                Action safeWrite = delegate { setCountDownText(txtValue); };
                Countdown.Invoke(safeWrite);
            }
            else
                Countdown.Text = txtValue;
        }
    }
}
