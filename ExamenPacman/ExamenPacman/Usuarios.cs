using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPacman
{
    [Serializable()]
    public class Usuarios
    {
        string nombreUsuario;
        string contrasena;
        int scoreAcumulado;
        List<int> scorePerGame=new List<int>();

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int ScoreAcumulado { get => scoreAcumulado; set => scoreAcumulado = value; }
        public List<int> ScorePerGame { get => scorePerGame; set => scorePerGame = value; }
        public Usuarios() { }
        public bool ChequeoContra(string nm, string ct)
        {
            if (nm == this.NombreUsuario && ct == this.Contrasena)
            {
                return true;
            }
            else   return false;
        }
    }
}
