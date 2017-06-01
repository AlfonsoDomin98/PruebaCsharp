using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJose.Models
{
    class Alumno : Persona
    {
        public string Nmatricula { get; set; }
        public float Nota
        {
            get
            {
               return Nota;
            }
            set 
            {
                if(Nota < 0 || Nota > 10)
                {
                    throw new Exception("[ERROR] Nota fuera de rango");
                }
            }
        }

        public Alumno(string Nmatricula,string nombre, string apellidos, int edad) : base(nombre, apellidos, edad)
        {
            this.Nota = 0;
            this.Nmatricula = Nmatricula;

        }

        public Alumno(string Nmatricula, float Nota, string nombre, string apellidos, int edad) : base(nombre, apellidos, edad)
        {
            this.Nota = Nota;
            this.Nmatricula = Nmatricula;

        }

        // METODOS
        public void Quejarse(string queja)
        {
            Console.WriteLine("Queja - "+queja);
        }

        public override void Saludar(string msg)
        {
            Console.WriteLine("Ehhhh " + msg);
        }
    }
}
