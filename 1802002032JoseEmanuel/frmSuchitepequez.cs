using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1802002032JoseEmanuel
{
    public partial class frmSuchitepequez : Form
    {
        public frmSuchitepequez()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                p1.Enabled = false;
                p2.Enabled = false;
                p3.Enabled = false;
                p4.Enabled = false;
                p5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                p1.Checked = false;
            }

            if (p2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                p1.Enabled = false;
                p2.Enabled = false;
                p3.Enabled = false;
                p4.Enabled = false;
                p5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                p2.Checked = false;
            }

            if (p3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                p1.Enabled = false;
                p2.Enabled = false;
                p3.Enabled = false;
                p4.Enabled = false;
                p5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                p3.Checked = false;
            }
            if (p4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                p1.Enabled = false;
                p2.Enabled = false;
                p3.Enabled = false;
                p4.Enabled = false;
                p5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                p4.Checked = false;
            }
            if (p5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                p1.Enabled = false;
                p2.Enabled = false;
                p3.Enabled = false;
                p4.Enabled = false;
                p5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                p5.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (d1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                d1.Enabled = false;
                d2.Enabled = false;
                d3.Enabled = false;
                d4.Enabled = false;
                d5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                d1.Checked = false;
            }

            if (d2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                d1.Enabled = false;
                d2.Enabled = false;
                d3.Enabled = false;
                d4.Enabled = false;
                d5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                d2.Checked = false;
            }

            if (d3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                d1.Enabled = false;
                d2.Enabled = false;
                d3.Enabled = false;
                d4.Enabled = false;
                d5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                d3.Checked = false;
            }
            if (d4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                d1.Enabled = false;
                d2.Enabled = false;
                d3.Enabled = false;
                d4.Enabled = false;
                d5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                d4.Checked = false;
            }
            if (d5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                d1.Enabled = false;
                d2.Enabled = false;
                d3.Enabled = false;
                d4.Enabled = false;
                d5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                d5.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                x1.Enabled = false;
                x2.Enabled = false;
                x3.Enabled = false;
                x4.Enabled = false;
                d5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                x1.Checked = false;
            }

            if (x2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                x1.Enabled = false;
                x2.Enabled = false;
                x3.Enabled = false;
                x4.Enabled = false;
                x5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                x2.Checked = false;
            }

            if (x3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                x1.Enabled = false;
                x2.Enabled = false;
                x3.Enabled = false;
                x4.Enabled = false;
                x5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                x3.Checked = false;
            }
            if (x4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                x1.Enabled = false;
                x2.Enabled = false;
                x3.Enabled = false;
                x4.Enabled = false;
                x5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                x4.Checked = false;
            }
            if (x5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                x1.Enabled = false;
                x2.Enabled = false;
                x3.Enabled = false;
                x4.Enabled = false;
                x5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                x5.Checked = false;
            }
        }
    }
}
