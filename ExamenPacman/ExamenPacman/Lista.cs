using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPacman
{
    public static class Lista
    {

        public static List<Usuarios> registro = new List<Usuarios>();
        public static void Guardar(List<Usuarios> pregistro)
        {
            String NombreArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro.txt");
            FileStream fs = new FileStream(NombreArchivo, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, registro);
            fs.Close();
        }
        public static List<Usuarios> CargarDatos(string p )
        {
            String NombreArchivo1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro.txt");
            if (!File.Exists(NombreArchivo1))
            {
                return new List<Usuarios>();
            }
            FileStream fs = new FileStream(NombreArchivo1, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            List<Usuarios> listado = formatter.Deserialize(fs) as List<Usuarios>;

            return listado;
        }
    }
}
