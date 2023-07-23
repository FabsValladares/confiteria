using confiteria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                ImagenProducto = "confiteria.Images.Combo1.jpg" ,
                Descripcion = "Palomitas de Maiz + 2 Refrescos",
                Precio = 120,
                Cantidad = 0,
               
            },
            new Golosina
            {
                NombreProducto = "Combo 2",
                ImagenProducto = "confiteria.Images.Combo2.jpg" ,
                Descripcion = "Palomitas de Maiz + 1 Refresco",
                Precio = 95,
                Cantidad = 0,
               
            },
            new Golosina
            {
                 NombreProducto = "Combo 3",
                // ImagenProducto = "confiteria.Resources.Images.Combo2.jpg" 
                Descripcion = "Nachos + 1 Refresco",
                Precio = 100,
                Cantidad = 0,
            },
             new Golosina
            {
                 NombreProducto = "Adicional",
                // ImagenProducto = "confiteria.Resources.Images.Combo2.jpg" 
                Descripcion = "Refresco Adicional",
                Precio = 35,
                Cantidad = 0,
            },
              new Golosina
            {
                 NombreProducto = "Adicional",
                // ImagenProducto = "confiteria.Resources.Images.Combo2.jpg" 
                Descripcion = "Agua en Botella",
                Precio = 20,
                Cantidad = 0,
            }



        };

            BindingContext = this;
        }
    }
}
