using CSharpJose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJose.Models
{
    abstract class Persona : ISaludable
    {
        private string nombre { get; set; }
        private string apellidos { get; set; }
        private int edad;

        public Persona(string nombre, string apellidos, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        // GETTERS AND SETTERS 
        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int Edad)
        {
            if(Edad < 0)
            {
                throw new Exception("[ERROR] La edad no puede ser menor de 0");
            }
        }

        // METODOS     
        public abstract void Saludar(string msg);

        public void Andar()
        {
            Console.WriteLine("Estoy andando");

        }

        public override string ToString()
        {
            return String.Format("{0} {1} ", nombre, apellidos);
        }
    }
}
