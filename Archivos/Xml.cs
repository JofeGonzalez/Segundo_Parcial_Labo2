using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            XmlTextWriter write = null;
            XmlSerializer ser;
            try
            {
                write = new XmlTextWriter(archivo, Encoding.UTF8);
                write.Formatting = Formatting.Indented;
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(write, datos);
            }
            catch (Exception exception)
            {

                throw new ArchivosException(exception);
            }
            finally
            {
                if (write != null)
                {
                    write.Close();
                }
            }
        }
        public void Leer(string archivo, out T datos)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(reader);
                }
            }
            catch (Exception exception)
            {

                throw new ArchivosException(exception);
            }
        }
    }
}
