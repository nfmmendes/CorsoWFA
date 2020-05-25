using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corso
{
    class Provincia
    {

        public static List<Provincia> Provincie = new List<Provincia>()
        {
            new Provincia("Emilia-Romagna", "Piacenza", 30),
            new Provincia("Emilia-Romagna", "Parma", 27),
            new Provincia("Emilia-Romagna", "Reggio Emilia", 45),
            new Provincia("Emilia-Romagna", "Modena", 90),
            new Provincia("Emilia-Romagna", "Bologna", 12),
            new Provincia("Lombardia", "Mantova", 4),
            new Provincia("Lombardia", "Milano", 7),
            new Provincia("Lombardia", "Brescia", 9),
            new Provincia("Lombardia", "Lodi", 16),
            new Provincia("Lombardia", "Monza", 25),
            new Provincia("Lombardia", "Pavia", 98),
            new Provincia("Veneto", "Verona", 2),
            new Provincia("Toscana", "Firenze", 70),
            new Provincia("Toscana", "Siena", 3),
            new Provincia("Toscana", "Lucca", 68),
            new Provincia("Toscana", "Prato", 95),
            new Provincia("Veneto", "Treviso", 40),
            new Provincia("Veneto", "Padova", 20),
        };


        public string Regione {get; set;}
        public string Nome { get; set;  }
        public int Popolazione { get; set; }

        public Provincia()
        {

        }

        public Provincia(string regione, string nome, int popolazione)
        {
            Regione = regione;
            Nome = nome;
            Popolazione = popolazione;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
