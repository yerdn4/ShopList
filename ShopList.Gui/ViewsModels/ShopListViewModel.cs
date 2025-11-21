using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShopList.Gui.ViewsModels
{
    public class ShopListViewModel
    {
        public ObservableCollecction<Item> Items { get;}

        public ShopListViewModel()
        {
            Items = new ObservableColeccion<Item>();
            CargarDatos();
        }

        private void CargarDatos()
        {
            Items.Add(new Item()
            {
                Id = 1,
                nombre = "leche"
                cantidad = 2,

            }
        }
    }
}
