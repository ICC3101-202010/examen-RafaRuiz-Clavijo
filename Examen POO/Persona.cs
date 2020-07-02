using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_POO
{
    public class Persona
    {
        protected string nombre;
        protected int edad;
        private string nacion;
        private int sueldo;

        public Persona(string nombre, int edad, string nacion, int sueldo)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacion = nacion;
            this.Sueldo = sueldo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nacion { get => nacion; set => nacion = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }

        public List<string> Informacion_Persona()
        {
            return new List<string>() { Nombre, Convert.ToString(Edad), Nacion, Convert.ToString(Sueldo) };
        }

        //Se puede obtener la info gracias al metodo o a las propiedades
    }
}
