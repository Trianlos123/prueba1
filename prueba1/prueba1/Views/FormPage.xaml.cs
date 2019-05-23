using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prueba1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormPage : ContentPage
	{
		public FormPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombre.Text))
            {
                DisplayAlert("Error", "Debe ingresar nombre.", "OK");
                nombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(rut.Text))
            {
                DisplayAlert("Error", "Debe ingresar RUT.", "OK");
                rut.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email.Text))
            {
                DisplayAlert("Error", "Debe ingresar Email.", "OK");
                email.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass1.Text))
            {
                DisplayAlert("Error", "Debe ingresar Contraseña.", "OK");
                pass1.Focus();
                return;
            }

            if (pass1.Text.Length < 6)
            {
                DisplayAlert("Error", "La Contraseña debe tener mínimo 6 caracteres.", "OK");
                pass1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass2.Text))
            {
                DisplayAlert("Error", "Debe ingresar la Confirmacion de Contraseña.", "OK");
                pass2.Focus();
                return;
            }

            if (pass1.Text != pass2.Text)
            {
                DisplayAlert("Error", "Deben coincidir las contraseñas.", "OK");
                pass1.Focus();
                return;
            }

            DisplayAlert("", "Campos Validados", "Aceptar");
        }
    }
}