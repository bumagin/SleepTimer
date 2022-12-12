using Microsoft.Win32;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int time;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            time = Convert.ToInt32(numericUpDown1.Value);
            label1.Text = "Осталось: " + time + " минут";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;

            label1.Text = "";
            label1.Text = "Осталось: " + time + " минут";

            if (time == 0)
            {
                System.Diagnostics.Process.Start("cmd", "/c shutdown -s -f -t 00");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Вы остановили таймер!", "Успех");
        }
    }
}