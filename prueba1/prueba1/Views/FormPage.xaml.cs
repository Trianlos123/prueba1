using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombre.Text))
            {
                await DisplayAlert("Error", "Debe ingresar nombre.", "OK");
                nombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(rut.Text))
            {
                await DisplayAlert("Error", "Debe ingresar RUT.", "OK");
                rut.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email.Text))
            {
                await DisplayAlert("Error", "Debe ingresar Email.", "OK");
                email.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass1.Text))
            {
                await DisplayAlert("Error", "Debe ingresar Contraseña.", "OK");
                pass1.Focus();
                return;
            }

            if (pass1.Text.Length < 6)
            {
                await DisplayAlert("Error", "La Contraseña debe tener mínimo 6 caracteres.", "OK");
                pass1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass2.Text))
            {
                await DisplayAlert("Error", "Debe ingresar la Confirmacion de Contraseña.", "OK");
                pass2.Focus();
                return;
            }

            if (pass1.Text != pass2.Text)
            {
                await DisplayAlert("Error", "Deben coincidir las contraseñas.", "OK");
                pass1.Focus();
                return;
            }

            await DisplayAlert("", "Campos Validados", "Aceptar");
            //activo la espera 
            //waitActivityIndicator.IsRunning = true;
            //bloqueo el boton 
            aceptar.IsEnabled = false;
            HttpClient client = new HttpClient();
            //direccion base raiz
            client.BaseAddress = new Uri("http://service.twk.cl");

            // método asincrono await espera la respuesta
            string jsonData = "{'NombreCompleto' :'" + nombre.Text + "', 'Usuario_id' :'" + rut.Text + "' }";

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("/api/alumno/179143488", content);

        }
    }
}