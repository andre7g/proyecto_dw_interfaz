using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoreoBidInterfaz.Models
{
    public class FileResponse
    {
        public int status { get; set; }

        public string mensaje { get; set; }

        public string pathArchivo { get; set; }

        public string extensionArchivo { get; set; }
    }
}
