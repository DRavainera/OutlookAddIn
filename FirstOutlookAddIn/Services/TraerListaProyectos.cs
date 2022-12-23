using FirstOutlookAddIn.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FirstOutlookAddIn.Services
{
    internal class TraerListaProyectos
    {
        public static List<Proyecto> TraerLista()
        {
            string[] listaNombres = { "Proyecto1", "Proyecto2", "Proyecto3" };

            List<Proyecto> listaProyecto = new List<Proyecto>();

            int contador = 1;

            foreach (var nombre in listaNombres)
            {
                Proyecto proyecto = new Proyecto()
                {
                    Id = contador,
                    Nombre = nombre
                };

                listaProyecto.Add(proyecto);

                contador++;
            }

            return listaProyecto;
        }
    }
}
