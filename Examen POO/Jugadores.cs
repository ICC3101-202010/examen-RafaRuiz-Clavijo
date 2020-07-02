using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_POO
{
    public class Jugadores : Persona
    {
        private int puntos_ataque;
        private int puntos_defensa;
        private int numero_camiseta;

        public Jugadores(string name, int edad, string nacion, int sueldo, int puntos_ataque, int puntos_defensa, int numero_camiseta) 
            : base (name, edad, nacion, sueldo)
        {
            this.Puntos_ataque = puntos_ataque;
            this.Puntos_defensa = puntos_defensa;
            this.Numero_camiseta = numero_camiseta;
        }

        public int Puntos_ataque { get => puntos_ataque; set => puntos_ataque = value; }
        public int Puntos_defensa { get => puntos_defensa; set => puntos_defensa = value; }
        public int Numero_camiseta { get => numero_camiseta; set => numero_camiseta = value; }
    }
}
