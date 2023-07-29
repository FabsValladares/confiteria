using confiteria.Models;
using confiteria.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace confiteria
{
    public partial class MainPage : ContentPage
    {
        public List<Golosina> ConfiteriaList { get; set; }

        public MainPage()
        {
            InitializeComponent();

            ConfiteriaList = new List<Golosina>
        {
            new Golosina
            {
                NombreProducto = "Combo 1",
                ImagenProducto = "combo1.jpg",
                Descripcion = "Palomitas de Maiz + 2 Refrescos",
                Precio = 120,
                Cantidad = 0,

            },
            new Golosina
            {
                NombreProducto = "Combo 2",
                ImagenProducto = "combo2.jpg",
                Descripcion = "Palomitas de Maiz + 1 Refresco",
                Precio = 95,
                Cantidad = 0,

            },
            new Golosina
            {
                 NombreProducto = "Combo 3",
                 ImagenProducto = "combo2.jpg",
                Descripcion = "Nachos + 1 Refresco",
                Precio = 100,
                Cantidad = 0,
            },
             new Golosina
            {
                 NombreProducto = "Adicional",
                 ImagenProducto = "combo2.jpg",
                Descripcion = "Refresco Adicional",
                Precio = 35,
                Cantidad = 0,
            },
              new Golosina
            {
                 NombreProducto = "Adicional",
                ImagenProducto = "combo1.jpg" ,
                Descripcion = "Agua en Botella",
                Precio = 20,
                Cantidad = 0,
            }



        };

            BindingContext = this;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PantallaPagos());
        }

    }

}

