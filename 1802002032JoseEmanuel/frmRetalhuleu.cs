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
    public partial class frmRetalhuleu : Form
    {
        public frmRetalhuleu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                a1.Checked = false;
            }

            if (a2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                a2.Checked = false;
            }

            if (a3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                a3.Checked = false;
            }
            if (a4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                a4.Checked = false;
            }
            if (a5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                a5.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                b1.Checked = false;
            }

            if (b2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                b2.Checked = false;
            }

            if (b3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                b3.Checked = false;
            }
            if (b4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                b4.Checked = false;
            }
            if (b5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                b5.Checked = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (q1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                q1.Enabled = false;
                q2.Enabled = false;
                q3.Enabled = false;
                q4.Enabled = false;
                q5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                q1.Checked = false;
            }

            if (q2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                q1.Enabled = false;
                q2.Enabled = false;
                q3.Enabled = false;
                q4.Enabled = false;
                q5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                    q2.Checked = false;
            }

            if (q3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                q1.Enabled = false;
                q2.Enabled = false;
                q3.Enabled = false;
                q4.Enabled = false;
                q5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                q3.Checked = false;
            }
            if (q4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                q1.Enabled = false;
                q2.Enabled = false;
                q3.Enabled = false;
                q4.Enabled = false;
                q5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                q4.Checked = false;
            }
            if (q5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                q1.Enabled = false;
                q2.Enabled = false;
                q3.Enabled = false;
                q4.Enabled = false;
                q5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                q5.Checked = false;
            }

        }
    }
}
