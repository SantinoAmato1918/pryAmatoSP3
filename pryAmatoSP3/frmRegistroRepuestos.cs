using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAmatoSP3
{
    public partial class frmRegistroRepuestos : Form
    {
        //Array 1 Dimension - Vector
        string[] VecRepuestos = new string[3];

        public frmRegistroRepuestos()
        {
            InitializeComponent();
        }

        private void frmRegistroRepuestos_Load(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string VarMarca = cmbMarca.Text;
            string VarOrigen;

            if (rbImportado.Checked == true)
            {
                VarOrigen = "Nacional";
            }
            else
            {
                VarOrigen = "Importado";
            }

            lstRepuesto.Items.Add(VarMarca + ' ' + VarOrigen);

            //Añadir los elementos del vector a la linea
            for (int indiceRegistro = 0; indiceRegistro < VecRepuestos.Length; indiceRegistro++)
            {
                //Grabar el Vector. Array 1 Dimension
                VecRepuestos[indiceRegistro] = VarMarca + ' ' + VarOrigen;
                lstRepuesto.Items.Add(VecRepuestos[indiceRegistro]);
            }

        
           

         
        }
    }
}
