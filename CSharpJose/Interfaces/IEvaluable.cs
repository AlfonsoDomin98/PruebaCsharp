using CSharpJose.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJose.Interfaces
{
    interface IEvaluable 
    {
        void Evaluar(Alumno a, float nota);
    }
}
