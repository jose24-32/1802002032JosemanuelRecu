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
    public partial class frmEmpradonar : Form
    {
        Conexion c = new Conexion();
        public frmEmpradonar()
        {
            InitializeComponent();
        }

        private void frmEmpradonar_Load(object sender, EventArgs e)
        {
            RbInsertar.Checked = true;
            Conexion c = new Conexion();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(txtBoxDPI.Text) || (string.IsNullOrEmpty(txtnombre.Text))))
            {
                MessageBox.Show("Por favor llenar todos los requerimientos");
            }
            else
                if (c.personaRegistrada(Convert.ToInt32(txtBoxDPI.Text)) == 0)
            {
                MessageBox.Show(c.insertar(Convert.ToInt32(txtBoxDPI.Text), txtnombre.Text, cbMunicipio.Text));
                    //textBoxDPI.Text = "";
                    //textBoxnombre.Text = "";
                    // comboBoxmunicipio.Text = "";
                if (cbMunicipio.SelectedItem.Equals("Suchitepéquez"))
                {
                    frmSuchitepequez n = new frmSuchitepequez();
                    n.Show();
                }
                if (cbMunicipio.SelectedItem.Equals("Guatemala"))
                {
                    btnVotar n = new btnVotar();
                    n.Show();
                }

                if (cbMunicipio.SelectedItem.Equals("Quetzaltenango"))
                {
                    frmQuetzaltenango nc = new frmQuetzaltenango();
                    nc.Show();
                }

                if (cbMunicipio.SelectedItem.Equals("Sololá"))
                {
                    frmSolola n = new frmSolola();
                    n.Show();
                }

                if (cbMunicipio.SelectedItem.Equals("Retalhuleu"))
                {
                    frmRetalhuleu n = new frmRetalhuleu();
                    n.Show();
                }
            }
        }
    }
}

