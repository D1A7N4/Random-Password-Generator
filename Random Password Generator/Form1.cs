using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Random_Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTN_Randomise_Click(object sender, EventArgs e)
        {
            string password = "";
            Random r = new Random();
            char c;
            for(int i = 0; i < 20; i++)
            {
                int j = r.Next(33, 126);
                int[] banned = { 45, 60, 62 };
                do
                {
                    j = r.Next(33, 126);
                } while (Array.IndexOf(banned, j) != -1);
                c = Convert.ToChar(j);
                password += c;
            }
            TBX_Password.Text = password;
        }
    }
}
