using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public void Guardar(string archivo, string datos)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(archivo, true);
                writer.WriteLine(datos);
            }
            catch (Exception exception)
            {
                throw new ArchivosException(exception);
            }
            finally
            {
                writer.Close();
            }
        }
        public void Leer(string archivo, out string datos)
        {
            StreamReader reader = null;
            try
            {                
                reader = new StreamReader(archivo, true);
                datos = reader.ReadToEnd();
            }
            catch (Exception exception)
            {

                throw new ArchivosException(exception);
            }
            finally
            {
                if (reader!=null)
                {
                    reader.Close();
                }
            }
        }
    }
}
