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
                // ImagenProducto = "confiteria.Resources.Images.Combo1.jpg" 
                Descripcion = "Palomitas de Maiz + 2 Refrescos",
                Precio = 120,
               
            },
            new Golosina
            {
                NombreProducto = "Combo 2",
                // ImagenProducto = "confiteria.Resources.Images.Combo2.jpg" 
                Descripcion = "Palomitas de Maiz + 1 Refresco",
                Precio = 95,
               
            },
        };

            BindingContext = this;
        }
    }
}
