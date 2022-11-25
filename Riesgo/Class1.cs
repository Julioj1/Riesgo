using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riesgo
{
    public class Riesgo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mitigation { get; set; }
        public string Impacto { get; set; }
        public string Probabilidad { get; set; }
        public int Total { get; set; }
        public string Nivel { get; set; }

    }
}
