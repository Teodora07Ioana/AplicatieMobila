using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicatieMobila.Models;

namespace AplicatieMobila
{
    public static class ProgramariService
    {
        public static List<Programare> Programarile { get; } = new List<Programare>();

        public static void AddProgramare(Programare programare)
        {
            Programarile.Add(programare);
        }

        public static IEnumerable<Programare> GetProgramarileUtilizatorului()
        {
            return Programarile;
        }
    }
}
