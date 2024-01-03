using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieMobila.Models
{

    public class Programare
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Serviciu { get; set; }
        public TimeSpan Ora { get; set; }


    }
}
