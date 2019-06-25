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
    public partial class frmSolola : Form
    {
        public frmSolola()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (u1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                u1.Enabled = false;
                u2.Enabled = false;
                u3.Enabled = false;
                u4.Enabled = false;
                u5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                u1.Checked = false;
            }

            if (u2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                u1.Enabled = false;
                u2.Enabled = false;
                u3.Enabled = false;
                u4.Enabled = false;
                u5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                u2.Checked = false;
            }

            if (u3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                u1.Enabled = false;
                u2.Enabled = false;
                u3.Enabled = false;
                u4.Enabled = false;
                u5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                u3.Checked = false;
            }
            if (u4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                u1.Enabled = false;
                u2.Enabled = false;
                u3.Enabled = false;
                u4.Enabled = false;
                u5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                u4.Checked = false;
            }
            if (u5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                u1.Enabled = false;
                u2.Enabled = false;
                u3.Enabled = false;
                u4.Enabled = false;
                u5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                u5.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                f1.Enabled = false;
                f2.Enabled = false;
                f3.Enabled = false;
                f4.Enabled = false;
                f5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                f1.Checked = false;
            }

            if (f2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                f1.Enabled = false;
                f2.Enabled = false;
                f3.Enabled = false;
                f4.Enabled = false;
                f5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                f2.Checked = false;
            }

            if (f3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                f1.Enabled = false;
                f2.Enabled = false;
                f3.Enabled = false;
                f4.Enabled = false;
                f5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                f3.Checked = false;
            }
            if (f4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                f1.Enabled = false;
                f2.Enabled = false;
                f3.Enabled = false;
                f4.Enabled = false;
                f5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                f4.Checked = false;
            }
            if (f5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                f1.Enabled = false;
                f2.Enabled = false;
                f3.Enabled = false;
                f4.Enabled = false;
                f5.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                f5.Checked = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (r1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                r4.Enabled = false;
                r5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                r1.Checked = false;
            }

            if (r2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                r4.Enabled = false;
                r5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                r2.Checked = false;
            }

            if (r3.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                r4.Enabled = false;
                r5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                r3.Checked = false;
            }
            if (r4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                r4.Enabled = false;
                r5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                r4.Checked = false;
            }
            if (r5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                r4.Enabled = false;
                r5.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                r5.Checked = false;
            }
        }
    }
}
