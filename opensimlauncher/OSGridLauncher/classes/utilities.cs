using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OSGridLauncher.classes
{
    class utilities
    {
        public static string SOPath(string caminho)
        {
            return caminho.Replace('\\', Path.DirectorySeparatorChar);
        }

    }
}
