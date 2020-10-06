using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int time;
        int timeleft;
        public Form1()
        {
            InitializeComponent();
        }

        private void Second_Click(object sender, EventArgs e)
        {
            Second.Text = "";
        }

        private void Begin_Click(object sender, EventArgs e)
        {
            try
            { Begin.Enabled = false;
                time = Convert.ToInt32(Second.Text);
                progressBar1.Value = 0;
                progressBar1.Maximum = time;
                Count();
            }
            catch
            {
                MessageBox.Show("Введите цифры", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        async void Count()
        {
            while (progressBar1.Value <time)
            {
                timeleft = time - progressBar1.Value;
                TimeLeft.Text = $"Оставшееся время: {timeleft} сек.";
                progressBar1.Value++;
                await Task.Delay(1000);                              
            }
            TimeLeft.Text = "";
            MessageBox.Show("Время вышло", "Время вышло",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Begin.Enabled = true;
            Second.Text = "";
            time = 0;
            progressBar1.Value = 0;
            TimeLeft.Text = "";
            }

      
    }
}
