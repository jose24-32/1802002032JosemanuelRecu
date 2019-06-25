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
    public partial class frmQuetzaltenango : Form
    {
        public frmQuetzaltenango()
        {
            InitializeComponent();
        }

        private void frmQuetzaltenango_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (s1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                s1.Enabled = false;
                s2.Enabled = false;
                s3.Enabled = false;
                s4.Enabled = false;
                s5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                s1.Checked = false;
            }

            if (s2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                s1.Enabled = false;
                s2.Enabled = false;
                s3.Enabled = false;
                s4.Enabled = false;
                s5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                s2.Checked = false;
            }

            if (s3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                s1.Enabled = false;
                s2.Enabled = false;
                s3.Enabled = false;
                s4.Enabled = false;
                s5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                s3.Checked = false;
            }
            if (s4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                s1.Enabled = false;
                s2.Enabled = false;
                s3.Enabled = false;
                s4.Enabled = false;
                s5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                s4.Checked = false;
            }
            if (s5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                s1.Enabled = false;
                s2.Enabled = false;
                s3.Enabled = false;
                s4.Enabled = false;
                s5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                s5.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (j1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                j1.Enabled = false;
                j2.Enabled = false;
                j3.Enabled = false;
                j4.Enabled = false;
                j5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                j1.Checked = false;
            }

            if (j2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                j1.Enabled = false;
                j2.Enabled = false;
                j3.Enabled = false;
                j4.Enabled = false;
                j5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                j2.Checked = false;
            }

            if (j3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                j1.Enabled = false;
                j2.Enabled = false;
                j3.Enabled = false;
                j4.Enabled = false;
                j5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                j3.Checked = false;
            }
            if (j4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                j1.Enabled = false;
                j2.Enabled = false;
                j3.Enabled = false;
                j4.Enabled = false;
                j5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                j4.Checked = false;
            }
            if (j5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                j1.Enabled = false;
                j2.Enabled = false;
                j3.Enabled = false;
                j4.Enabled = false;
                j5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                j5.Checked = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;
                c4.Enabled = false;
                c5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                c1.Checked = false;
            }

            if (c2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;
                c4.Enabled = false;
                c5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                c2.Checked = false;
            }

            if (c3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;
                c4.Enabled = false;
                c5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                c3.Checked = false;
            }
            if (c4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;
                c4.Enabled = false;
                c5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                c4.Checked = false;
            }
            if (c5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;
                c4.Enabled = false;
                c5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                c5.Checked = false;
            }
        }
    }
}
