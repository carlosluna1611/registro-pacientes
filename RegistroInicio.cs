using System.Runtime.CompilerServices;

namespace RegistroDePacientes
{
    public partial class RegistroInicio : Form
    {
        //Inicio de la aplicacion con la ventana de registros personales
        public RegistroInicio()
        {
            InitializeComponent();
        }

        //Funcionalidad del boton Salir para cerrar la ventana
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funcionalidad del boton Guardar para avanzar de ventana
        private void btnGuardarDatos0_Click(object sender, EventArgs e)
        {
            //Respuestas a los valores establecidos por las validaciones en forma Switch
            switch (ValidacionDatos())
            {
                case 0:
                    {
                        //Limpieza de todos los mensajes de error anteriores
                        errorProvider1.SetError(txtPNombre, "");
                        errorProvider1.SetError(txtSNombre, "");
                        errorProvider1.SetError(txtPApellido, "");
                        errorProvider1.SetError(txtSApellido, "");
                        errorProvider1.SetError(txtCedula, "");
                        errorProvider1.SetError(txtEdad, "");
                        errorProvider1.SetError(cbxSexo, "");
                        errorProvider1.SetError(pnlDatos0, "");
                        //Apertura de la nueva ventana de registros especificos
                        using (RegistroFinal ventanaRegistroFinal = new RegistroFinal())
                        ventanaRegistroFinal.ShowDialog();
                        //Ruptura del caso numero 0
                        break;
                    }

                    //Respuestas a los casos de errores posibles
                case 1:
                    {
                        errorProvider1.SetError(txtPNombre, "Debe de rellenar este campo con su primer nombre, sin números o caracteres especiales");
                        //Mensaje de error general del panel

                        errorProvider1.SetError(pnlDatos0, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al campo de texto para rectificar su error
                        txtPNombre.Focus();
                        //Ruptura del caso numero 1
                        break;
                    }

                case 2:
                    {
                        errorProvider1.SetError(txtSNombre, "No deben de haber números o caracteres especiales en este campo");
                        //Mensaje de error general del panel
                        errorProvider1.SetError(pnlDatos0, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al campo de texto para rectificar su error
                        txtSNombre.Focus();
                        //Ruptura del caso numero 2
                        break;
                    }

                case 3:
                    {
                        errorProvider1.SetError(txtPApellido, "Debe de rellenar este campo con su primer apellido, sin números o caracteres especiales");
                        //Limpieza de todos los mensajes de error anteriores
                        errorProvider1.SetError(txtPNombre, "");
                        errorProvider1.SetError(txtSNombre, "");
                        //Mensaje de error general del panel
                        errorProvider1.SetError(pnlDatos0, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al campo de texto para rectificar su error
                        txtPApellido.Focus();
                        //Ruptura del caso numero 3
                        break;
                    }

                case 4:
                    {
                        errorProvider1.SetError(txtSApellido, "No deben de haber números o caracteres especiales en este campo");
                        //Limpieza de todos los mensajes de error anteriores
                        errorProvider1.SetError(txtPNombre, "");
                        errorProvider1.SetError(txtSNombre, "");
                        errorProvider1.SetError(txtPApellido, "");
                        //Mensaje de error general del panel
                        errorProvider1.SetError(pnlDatos0, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al campo de texto para rectificar su error
                        txtSApellido.Focus();
                        //Ruptura del caso numero 4
                        break;
                    }

                case 5:
                    {
                        errorProvider1.SetError(txtCedula, "Debe de seleccionar un tipo de cédula e indicar su valor, sin letras o caracteres especiales");
                        //Limpieza de todos los mensajes de error anteriores
                        errorProvider1.SetError(txtPNombre, "");
                        errorProvider1.SetError(txtSNombre, "");
                        errorProvider1.SetError(txtPApellido, "");
                        errorProvider1.SetError(txtSApellido, "");
                        //Mensaje de error general del panel
                        errorProvider1.SetError(pnlDatos0, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al campo numerico para rectificar su error
                        txtCedula.Focus();
                        //Ruptura del caso numero 5
                        break;
                    }

                case 6:
                    {
                        errorProvider1.SetError(txtEdad, "Debe de rellenar este campo con su edad, sin letras o caracteres especiales");
                        //Limpieza de todos los mensajes de error anteriores
                        errorProvider1.SetError(txtPNombre, "");
                        errorProvider1.SetError(txtSNombre, "");
                        errorProvider1.SetError(txtPApellido, "");
                        errorProvider1.SetError(txtSApellido, "");
                        errorProvider1.SetError(txtCedula, "");
                        //Mensaje de error general del panel
                        errorProvider1.SetError(pnlDatos0, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al campo numerico para rectificar su error
                        txtEdad.Focus();
                        //Ruptura del caso numero 6
                        break;
                    }

                case 7:
                    {
                        errorProvider1.SetError(cbxSexo, "Debe de seleccionar un sexo");
                        //Limpieza de todos los mensajes de error anteriores
                        errorProvider1.SetError(txtPNombre, "");
                        errorProvider1.SetError(txtSNombre, "");
                        errorProvider1.SetError(txtPApellido, "");
                        errorProvider1.SetError(txtSApellido, "");
                        errorProvider1.SetError(txtCedula, "");
                        errorProvider1.SetError(txtEdad, "");
                        //Mensaje de error general del panel
                        errorProvider1.SetError(pnlDatos0, "Debe de rellenar los campos nesesitados para continuar");
                        //Enfoque del usuario al selector de lista para rectificar su error
                        cbxSexo.Focus();
                        //Ruptura del caso numero 7
                        break;
                    }
            }
        }

        //metodo para las funciones de Validacion
        private int ValidacionDatos()
        {
            //Validacion para que el usuario no deje el campo de texto vacio ni con valores numericos
            if (!(txtPNombre.Text.All(Char.IsLetter)) || (txtPNombre.Text == ""))
            {
                return 1;
            }
            else
            {
                //Validacion para que el usuario no deje el campo de texto con valores numericos, siendo un campo opcional para el desarrollo del codigo
                if ((!(txtSNombre.Text.All(Char.IsLetter))))
                {
                    return 2;
                }
                else
                {
                    //Validacion para que el usuario no deje el campo de texto vacio ni con valores numericos
                    if (!(txtPApellido.Text.All(Char.IsLetter)) || (txtPApellido.Text == ""))
                    {
                        return 3;
                    }
                    else
                    {
                        //Validacion para que el usuario no deje el campo de texto con valores numericos, siendo un campo opcional para el desarrollo del codigo
                        if ((!(txtSApellido.Text.All(Char.IsLetter))))
                        {
                            return 4;
                        }
                        else
                        {
                            //Validacion para que el usuario no deje el campo numerico vacio ni con valores de letras
                            if ((cbxCedula.SelectedIndex < 0) || (!(txtCedula.Text.All(Char.IsDigit)) || (txtCedula.Text == "")))
                            {
                                return 5;
                            }
                            else
                            {
                                //Validacion para que el usuario no deje el campo numerico vacio ni con valores de letras
                                if (!(txtEdad.Text.All(Char.IsDigit)) || (txtEdad.Text == ""))
                                {
                                    return 6;
                                }
                                else
                                {
                                    //Validacion para que el usuario no deje el selector de lista vacio
                                    if (cbxSexo.SelectedIndex < 0)
                                    {
                                        return 7;
                                    }
                                    //Validacion final corroborando que todos los datos fueron introducidos con exito
                                    else
                                    {
                                        return 0;
                                    }
                                }    
                            }
                        }
                    }
                }
            }
        }
    }
}
