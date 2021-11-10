using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Final
{
    class Conductor
    {
        private string id;
        private string sexo;
        private string afiliado;

        public string Id { get => id; set => id = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Afiliado { get => afiliado; set => afiliado = value; }
    }
}
