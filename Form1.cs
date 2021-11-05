using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{

    public partial class Form1 : Form
    {
        public int type = 0;
        private bool NumeroPiso;
        private bool CantVentanas;
        private bool Direccion;
        private bool Superficie;
        private bool PrecioBase;

        

        private void Form1_Load(object sender, EventArgs e)
        {
        }

      
        public partial class BotonPrecio : Form
        {
            private object txtNumPiso;
            private object myPiso;
            Piso myPiso = new Piso();
            Local myLocal = new Local();
            public int type = 0;
            private bool NumeroPiso1;
            private bool CantVentanas1;
            private bool Direccion1;
            private bool Superficie1;
            private bool PrecioBase1;



            

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void radiobtnPiso_CheckedChanged(object sender, EventArgs e)
            {
                type = 1;
                txtNumPiso.Enabled = true;

            }

            private void radiobtnLocal_CheckedChanged(object sender, EventArgs e)
            {
                type = 2;
                txtNumPiso.Enabled = false;

            }

            private void txtNumPiso_TextChanged(object sender, EventArgs e)
            {
                switch (type)
                {
                    case 1:
                        try
                        {
                            myPiso.NumeroPiso1 = Convert.ToInt32(txtNumPiso.Text);
                        }
                        catch (Exception)
                        {

                        }

                        break;
                    case 2:

                        break;
                   
                }
            }

            private void txtVentanas_TextChanged(object sender, EventArgs e)
            {
                switch (type)
                {
                    case 1:
                        try
                        {
                            myLocal.CantVentanas1 = Convert.ToInt32(txtVentanas.Text);
                        }
                        catch (Exception)
                        {

                        }

                        break;
                    case 2:

                        break;

                }
            }

            private void txtDireccion_TextChanged(object sender, EventArgs e)
            {
                switch (type)
                {
                    case 1:
                        try
                        {
                            myPiso.Direccion1 = txtDireccion.Text;
                        }
                        catch (Exception)
                        {
                        }

                        break;
                    case 2:
                        try
                        {
                            myLocal.Direccion1 = txtDireccion.Text;
                        }
                        catch (Exception)
                        {
                        }

                        break;
                }
            }

            private void txtSuperficie_TextChanged(object sender, EventArgs e)
            {
                    switch (type)
                    {
                        case 1:
                            try
                            {
                                myPiso.Superficie1 = Convert.ToDouble(txtSuperficie.Text);
                            }
                            catch (Exception)
                            {
                            }

                            break;
                        case 2:
                            try
                            {
                                myLocal.Superficie1 = Convert.ToDouble(txtSuperficie);
                            }
                            catch (Exception)
                            {
                            }

                            break;

                    }
                }

            private void txtAntiguedad_TextChanged(object sender, EventArgs e)
            {
                switch (type)
                {
                    case 1:
                        try
                        {
                            myPiso.Antiguedad1 = Convert.ToInt32(txtAntiguedad.Text);
                        }
                        catch (Exception)
                        {

                        }

                        break;
                    case 2:
                        try
                        {
                            myLocal.Antiguedad1 = Convert.ToInt32(txtAntiguedad.Text);
                        }
                        catch (Exception)
                        {

                        }

                        break;

                }
            }

            private void txtPrecioBase_TextChanged(object sender, EventArgs e)
            {
                switch (type)
                {
                    case 1:
                        try
                        {

                            myPiso.PrecioBase1 = Convert.ToDouble(txtPrecioBase.Text);
                        }
                        catch (Exception)
                        {

                        }

                        break;
                    case 2:
                        try
                        {

                            myLocal.PrecioBase1 = Convert.ToDouble(txtPrecioBase.Text);
                        }
                        catch (Exception)
                        {

                        }

                        break;

                }
                private void BtnPrecio(object sender, MouseEventArgs e)
                {
                    if (type == 1)
                    {
                        txtResultado.Text = Convert.ToString(myPiso.CalcularPrecio());
                    }
                    if (type == 2)
                    {
                        txtResultado.Text = Convert.ToString(myLocal.CalcularPrecio());
                    }
                }
            }
        }
    }
}
