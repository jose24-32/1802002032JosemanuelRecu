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
    public partial class btnVotar : Form
    {
        public btnVotar()
        {
            InitializeComponent();
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = false;
                chk5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                chk1.Checked = false;
            }

            if (chk2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = false;
                chk5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                chk2.Checked = false;
            }

            if (chk3.Checked == true)
            {
                MessageBox.Show(" Gracias por su voto");
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = false;
                chk5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                chk3.Checked = false;
            }

            if (chk4.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = false;
                chk5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                chk4.Checked = false;
            }

            if (chk5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = false;
                chk5.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                chk5.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chkUne.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chkUne.Enabled = false;
                chkVamos.Enabled = false;
                chkUnionista.Enabled = false;
                chkTodos.Enabled = false;
                chkUcn.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                chkUne.Checked = false;
            }

            if (chkVamos.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chkUne.Enabled = false;
                chkVamos.Enabled = false;
                chkUnionista.Enabled = false;
                chkTodos.Enabled = false;
                chkUcn.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                chkVamos.Checked = false;
            }

            if (chkUnionista.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chkUne.Enabled = false;
                chkVamos.Enabled = false;
                chkUnionista.Enabled = false;
                chkTodos.Enabled = false;
                chkUcn.Enabled = false;
                button2.Enabled = false;

                tabControl1.SelectedIndex = 1;
                chkUnionista.Checked = false;
            }

            if (chkTodos.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chkUne.Enabled = false;
                chkVamos.Enabled = false;
                chkUnionista.Enabled = false;
                chkTodos.Enabled = false;
                chkUcn.Enabled = false;
                button2.Enabled = false; ;

                tabControl1.SelectedIndex = 1;
                chkTodos.Checked = false;
            }

            if (chkUcn.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chkUne.Enabled = false;
                chkVamos.Enabled = false;
                chkUnionista.Enabled = false;
                chkTodos.Enabled = false;
                chkUcn.Enabled = false;
                button2.Enabled = false; ;

                tabControl1.SelectedIndex = 1;
                chkUcn.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chkune2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chkune2.Enabled = false;
                chkvamos2.Enabled = false;
                chkUnionista2.Enabled = false;
                chktodos2.Enabled = false;
                chkUcn2.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                chkune2.Checked = false;
            }

            if (chkvamos2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chkune2.Enabled = false;
                chkvamos2.Enabled = false;
                chkUnionista2.Enabled = false;
                chktodos2.Enabled = false;
                chkUcn2.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                chkvamos2.Checked = false;
            }

            if (chkUnionista2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chkune2.Enabled = false;
                chkvamos2.Enabled = false;
                chkUnionista2.Enabled = false;
                chktodos2.Enabled = false;
                chkUcn2.Enabled = false;
                button3.Enabled = false;

                tabControl1.SelectedIndex = 1;
                chkUnionista2.Checked = false;
            }

            if (chktodos2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chkune2.Enabled = false;
                chkvamos2.Enabled = false;
                chkUnionista2.Enabled = false;
                chktodos2.Enabled = false;
                chkUcn2.Enabled = false;
                button3.Enabled = false; ;

                tabControl1.SelectedIndex = 1;
                chktodos2.Checked = false;
            }

            if (chkUcn2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                chkune2.Enabled = false;
                chkvamos2.Enabled = false;
                chkUnionista2.Enabled = false;
                chktodos2.Enabled = false;
                chkUcn2.Enabled = false;
                button3.Enabled = false; ;

                tabControl1.SelectedIndex = 1;
                chkUcn2.Checked = false;
            }
        }

        private void btnVotar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void chkUcn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkUnionista_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkVamos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkUne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void chkUcn2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkUnionista2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chktodos2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkvamos2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkune2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
