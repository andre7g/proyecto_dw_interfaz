using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoreoBidInterfaz.Models
{
    public class Documento
    {
        [Required(ErrorMessage = "Elija un documento: .docx, .xlsx, .pdf")]
        public IFormFile Files { get; set; }

        [Required(ErrorMessage = "Debe definir un path para el almacenamiento")]
        public string path { get; set; }
    }
}
