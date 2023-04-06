using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientes.models
{
    public class Cliente
    {
        public string id { get; set; }  
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tarjeta { get; set; }
        public string telefono { get; set; }

        public string NombreCompleto
        {
            get { return nombre + " " + apellido; }
        }

        public string TarjetCredito
        {
            get { return tarjeta; }
        }

        public string Telefono
        {
            get { return telefono; }
        }

        public override string ToString()
        {
            return NombreCompleto + " " + TarjetCredito + " " + Telefono;
        }
    }
}
