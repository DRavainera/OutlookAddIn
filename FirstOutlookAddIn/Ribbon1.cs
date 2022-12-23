using FirstOutlookAddIn.Services;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstOutlookAddIn
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            var listaProyectos = CargarLista();

            this.CargarDatos(listaProyectos);
        }

        public void CargarDatos(List<string> datos)
        {
            foreach(string dato in datos)
            {
                RibbonDropDownItem item = Factory.CreateRibbonDropDownItem();
                
                item.Tag = dato.ToString();
                item.Label = dato.ToString();
                
                this.comboBox1.Items.Add(item);
            }
        }

        public List<string> CargarLista()
        {
            List<string> listaNombres = new List<string>();

            var listaProyectos = TraerListaProyectos.TraerLista();

            foreach(var proyecto in listaProyectos)
            {
                listaNombres.Add(proyecto.Nombre);
            }

            return listaNombres;
        }
    }
}
