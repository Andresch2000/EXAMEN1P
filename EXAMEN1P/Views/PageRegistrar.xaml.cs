using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXAMEN1P.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageRegistrar : ContentPage
    {
        public PageRegistrar()
        {
            InitializeComponent();
        }

        private async void btnsalvar_Clicked(object sender, EventArgs e)
        {

            var contacto = new Models.Contactos
            {
                nombres = nombre.Text,
                apellidos = apellido.Text,
                telefonos = telefono.Text,
                edades = edad.Text,
                paises = pais.SelectedItem.ToString(),
                notas = nota.Text

            };

            if (await App.Database.AddContactos(contacto) > 0) 
            {
                await DisplayAlert("Aviso", "Contacto Ingresado con Exito", "Ok");
            }
            else
            {
                await DisplayAlert("Aviso", "A ocurrido un error...", "Ok");
            }
        }
    }
}