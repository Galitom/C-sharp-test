using System.Runtime.CompilerServices;

namespace Lezione1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci un cognome: ");
            string cognome = Console.ReadLine();

            Prova.Studente s = new Prova.Studente(nome, cognome);
            Console.WriteLine("Nome: " + s.Name+"; Cognome: "+s.Surname);

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

    class Studente : Persona
    {
        private string name;
        private string surname;

        public Studente(string name, string surname)
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