using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensiones
{
    public static class Extensiones
    {
        public static string DevolverString(this string texto)
        {
            string tex = $"{texto} / Finalizado";
            return tex;
        }
    }
}
