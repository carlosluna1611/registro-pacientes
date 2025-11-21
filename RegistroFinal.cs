using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDePacientes
{
    public partial class RegistroFinal : Form
    {
        //Inicio de la ventana de registros personales

        public RegistroFinal()
        {
            InitializeComponent();
        }

        //Funcionalidad del boton Guardar para avanzar de ventana
        private void btnGuardarDatos1_Click(object sender, EventArgs e)
        {
            //Respuestas a los valores establecidos por las validaciones en forma Switch
            switch (ValidacionDatosEspecificos())
            {
                //Respuestas a los casos de errores posibles
                case 0:
                    {
                        //Limpieza de todos los mensajes de error anteriores
                        errorProvider1.SetError(txtCorreo, "");
                        errorProvider1.SetError(txtTelefono, "");
                        errorProvider1.SetError(cbxPais, "");
                        errorProvider1.SetError(txtDireccion, "");
                        errorProvider1.SetError(txtMedicamento, "");
                        errorProvider1.SetError(pnlDatosEspecificos0, "");
                        errorProvider1.SetError(pnlDatosEspecificos1, "");
                        //Mensaje para almacenar y utilizar en una ventana emergente
                        string mensajefinal = "!Datos Registrados con éxito¡\nesperamos verte pronto, !feliz día¡";
                        //Creacion de los botones que tendra la ventana emergente
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        //Apertura de la ventana emergente de despedida
                        MessageBox.Show(mensajefinal, "!Adios¡", buttons);
                        //Ruptura del caso numero 0
                        break;
                    }

                case 1:
                    {
                        errorProvider1.SetError(txtCorreo, "Debe de rellenar este campo con su correo electrónico");
                        //Mensaje de error general del panel
                        errorProvider1.SetError(pnlDatosEspecificos0, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al campo de texto para rectificar su error
                        txtCorreo.Focus();
                        //Ruptura del caso numero 1
                        break;
                    }

                case 2:
                    {
                        errorProvider1.SetError(txtTelefono, "Debe de rellenar este campo con su número telefónico, no deben de haber letras o caracteres especiales");
                        //Limpieza de todos los mensajes de error anteriores
                        errorProvider1.SetError(txtCorreo, "");
                        //Mensaje de error general del panel
                        errorProvider1.SetError(pnlDatosEspecificos0, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al campo numerico para rectificar su error
                        txtTelefono.Focus();
                        //Ruptura del caso numero 2
                        break;
                    }

                case 3:
                    {
                        errorProvider1.SetError(cbxPais, "Debe de rellenar este campo con su país de origen");
                        //Limpieza de todos los mensajes de error anteriores
                        errorProvider1.SetError(txtCorreo, "");
                        errorProvider1.SetError(txtTelefono, "");
                        //Mensaje de error general del panel
                        errorProvider1.SetError(pnlDatosEspecificos0, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al selector de lista para rectificar su error
                        cbxPais.Focus();
                        //Ruptura del caso numero 2
                        break;
                    }
                case 4:
                    {
                        errorProvider1.SetError(txtDireccion, "Debe de rellenar este campo con su dirección corta");
                        //Limpieza de todos los mensajes de error anteriores
                        errorProvider1.SetError(txtCorreo, "");
                        errorProvider1.SetError(txtTelefono, "");
                        errorProvider1.SetError(cbxPais, "");
                        //Mensaje de error general del panel
                        errorProvider1.SetError(pnlDatosEspecificos0, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al campo de texto para rectificar su error
                        txtDireccion.Focus();
                        //Ruptura del caso numero 5
                        break;
                    }
                case 5:
                    {
                        errorProvider1.SetError(txtMedicamento, "Debe de rellenar este campo con los medicamentos a los cuales sea usted alérgico");
                        //Mensaje de error general del panel
                        errorProvider1.SetError(pnlDatosEspecificos1, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al campo de texto para rectificar su error
                        txtDireccion.Focus();
                        //Ruptura del caso numero 5
                        break;
                    }

            }
        }

        //Metodo para las funciones de Validacion
        private int ValidacionDatosEspecificos()
        {
            //Validacion para que el usuario no deje el campo de texto vacio
            if (txtCorreo.Text == "")
            {
                //Retorno de variable de error 1
                return 1;
            }
            else
            {
                //Validacion para que el usuario no deje el selector de lista y campo numerico vacio ni con valores de letras
                if ((cbxTelefono.SelectedIndex < 0) || (!(txtTelefono.Text.All(Char.IsDigit)) || (txtTelefono.Text == "")))

                {
                    //Retorno de variable de error 2
                    return 2;
                }
                else
                {
                    //Validacion para que el usuario no deje el selector de lista vacio
                    if (((cbxPais.SelectedIndex < 0)))
                    {
                        //Retorno de variable de error 3
                        return 3;
                    }
                    else
                    {
                        //Validacion para que el usuario no deje el campo de texto vacio
                        if (txtDireccion.Text == "")
                        {
                            //Retorno de variable de error 4
                            return 4;
                        }
                        else
                        {
                            //Validacion para que el usuario no deje el campo de texto vacio si es que selecciona el check
                            if ((chbxMedicamento.Checked == true) && (txtMedicamento.Text == ""))
                            {
                                //Retorno de variable de error 5
                                return 5;
                            }
                            else
                            {   //Retorno de variable de comprobacion exitosa 0
                                return 0;
                            }
                        }
                    }
                }
            }
        }

        //Funcionalidad del boton Regresar para cerrar la ventana y regresar a la anterior
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funcionalidad del boton Salir para cerrar todo el programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(null, "Estás a punto de cerrar el programa, !hasta luego¡", null);
            Application.Exit();
        }
    }
}



