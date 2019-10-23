using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
