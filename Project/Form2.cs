using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void addIB(string text)
        {
            TextBox textBox = new TextBox();
            textBox.ReadOnly = true;
            textBox.Multiline = true;
            textBox.Width = 380;
            textBox.Height = 100;

            textBox.Text = text;
            flowLayoutPanel1.Controls.Add(textBox);
        }
    }
}
