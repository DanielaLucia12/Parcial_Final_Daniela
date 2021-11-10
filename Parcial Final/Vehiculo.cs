using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Final
{
    class Vehiculo
    {
        private string tipo;
        private string placa;
        private string marca;
        private string puesto;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Puesto { get => puesto; set => puesto = value; }
    }
}
