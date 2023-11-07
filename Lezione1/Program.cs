using Prova;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Lezione1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prova.Docente d1 = new Prova.Docente("Antonio", "Lezzi");
            Prova.Docente d2 = new Prova.Docente("Enrico", "Conti");
            Prova.Studente s2 = new Prova.Studente("Tommaso", "Galimberti");
            Prova.Studente s1 = new Prova.Studente("Gio", "Gia");
            s1.AddEsame(new Prova.Esame("Ios", 27, d1));
            s1.AddEsame(new Prova.Esame("Java", 18, d2));


            Aula aula = new Aula();

            aula = aula + s1;  // Aggiungi uno studente
            aula = aula + d1;   // Aggiungi un docente

            Console.WriteLine($"studente1 == studente2: {s1 == s2}"); // True
            Console.WriteLine($"studente1 == studente3: {s1 != s2}"); // False



        }
    }
}

namespace Prova
{
    interface Persona
    {
        string Name { get; set; }
        string Surname { get; set; }
        
    }

    class Aula
    {
        List<Persona> lista;

        public Aula()
        {
            this.lista = new List<Persona>();
        }
        public static Aula operator +(Aula aula, Persona p)
        {
            aula.lista.Add(p);
            return aula;
        }


    }

    class Esame
    {
        private string name;
        private double voto;
        private Docente docente;

        public Esame(string name, double voto, Docente docente)
        {
            this.name = name;
            this.voto = voto;
            this.docente = docente;
        }   
    }

    class Studente : Persona
    {
        private string name;
        private string surname;
        List<Esame> list;

        public Studente(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.list = new List<Esame>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public void AddEsame(Esame e)
        {
            list.Add(e);
        }
       

        public static bool operator ==(Studente studente1, Studente studente2)
        {
            if (ReferenceEquals(studente1, studente2))
            {
                return true;
            }

            if (studente1 is null || studente2 is null)
            {
                return false;
            }

            return studente1.name == studente2.name && studente1.surname == studente2.surname;
        }
        
        public static bool operator !=(Studente studente1, Studente studente2)
        {
            return !(studente1 == studente2);
        }

    }

    class Docente : Persona
    {
        private string name;
        private string surname;

        public Docente(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
    }
}