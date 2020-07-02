using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_POO
{
    public class Partido
    {
        private Equipo local;
        private Equipo visita;
        private int tiempo;
        private int score_local;
        private int score_visita;
        private bool nacional; //Si es true es nacional, si no es de liga

        public Partido(Equipo local, Equipo visita, int tiempo, int score_local, int score_visita)
        {
            this.Local = local;
            this.Visita = visita;
            this.Tiempo = tiempo;
            this.Score_local = score_local;
            this.Score_visita = score_visita;
            if (Verificar_Validez())
            {
                this.Nacional = Local.Nacional;

            }
            this.Local.Entrenador.NotificarEmergencia += OnNotifyLesion;
            this.Visita.Entrenador.NotificarEmergencia += OnNotifyLesion;
        }

        public Equipo Local { get => local; set => local = value; }
        public Equipo Visita { get => visita; set => visita = value; }
        public int Tiempo { get => tiempo; set => tiempo = value; }
        public int Score_local { get => score_local; set => score_local = value; }
        public int Score_visita { get => score_visita; set => score_visita = value; }
        public bool Nacional { get => nacional; set => nacional = value; }

        public bool Verificar_Validez()
        {
            //Entrega si en el partido se enfrentan dos equipos nacionales o dos equipos de liga
            return Local.Nacional == Visita.Nacional;
        }
        public List<string> Informacion_Partido()
        {
            return new List<string>() { Local.Name, Visita.Name, Convert.ToString(Tiempo), Convert.ToString(Score_local), Convert.ToString(Score_visita), Convert.ToString(Nacional) };
        }
        public void Simular_Partido()
        {
            if (!Verificar_Validez())
            {
                Console.WriteLine("El partido no es valido, no puede enfrentarse un equipo nacional con un equipo de liga");
            }
        }
        public void OnNotifyLesion(object source, HelpThePlayerEventArgs e)
        {
            Console.WriteLine("Jugador Lesionado: " + e.player.Nombre);
        }
    }
}
