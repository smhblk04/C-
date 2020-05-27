using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dama_tahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] button = new Button[8, 8]; //8*8'lik dama tahtasi 
            int top = 0;
            int left = 0;
            for (int i = 0; i <= button.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= button.GetUpperBound(1); j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 60;
                    button[i, j].Height = 60;
                    button[i, j].Top = top;
                    button[i, j].Left = left;
                    left += 60;
                    if ((i+j) % 2 == 0)
                    {
                        button[i, j].BackColor = Color.Black;
                    }
                    else { button[i, j].BackColor = Color.Red;  }
                    this.Controls.Add(button[i, j]);//Button'u koyan satir
                }
                top += 60;
                left = 0;
            }
        }
    }
}
