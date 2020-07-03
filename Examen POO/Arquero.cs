﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_POO
{
    public class Arquero : Jugadores, CanJugarArco
    {
        public Arquero(string name, int edad, string nacion, int sueldo, int puntos_ataque, int puntos_defensa, int numero_camiseta, bool lesionado) : 
            base(name, edad, nacion, sueldo, puntos_ataque, puntos_defensa, numero_camiseta, lesionado)
        {

        }

        public void Jugar_al_Arco()
        {
            //Metodo que permite jugar en el arco
        }
    }
}
