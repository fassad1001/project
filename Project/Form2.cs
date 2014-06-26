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

        public void addIB_text(string text)
        {
            TextBox textBox = new TextBox();
            textBox.ReadOnly = true;
            textBox.Multiline = true;
            textBox.Width = 380;
            textBox.Height = 100;

            vScrollBar1.Maximum = IB_text_Panel.VerticalScroll.Maximum + 1;

            textBox.Text = text;
            IB_text_Panel.Controls.Add(textBox);
        }
        public void addIB_pic()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IB_text_Panel.AutoScrollPosition = new Point(
                IB_text_Panel.AutoScrollPosition.X,
                IB_text_Panel.VerticalScroll.Maximum);
            vScrollBar1.Value = vScrollBar1.Maximum;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            IB_text_Panel.AutoScrollPosition = new Point(
                IB_text_Panel.AutoScrollPosition.X,
                vScrollBar1.Value);
        }
    }
}
