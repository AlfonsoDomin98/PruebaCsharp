using CSharpJose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJose.Models
{
    class Profesor : Persona, IEvaluable
    {
        public float Sueldo
        {
            get
            {
                return Sueldo;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("[ERROR] Sueldo fuera de rango");
                }
            }
        }

        public Profesor(float Sueldo,string nombre, string apellidos, int edad) : base(nombre, apellidos, edad)
        {
            this.Sueldo = Sueldo;
        }


        // METODOS FUNCIONALES
        public void Evaluar(Alumno a, float nota)
        {
            a.Nota = nota;
        }

        public void Regañar(string msg)
        {
            Console.WriteLine("REGAÑINA - " + msg);
        }

        public override void Saludar(string msg)
        {
            Console.WriteLine("Buenos dias " + msg);
        }
    }
}
