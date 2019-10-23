using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public abstract class Contrato
    {
        public abstract IList<ClienteModel> Pesquisar();
    }
}
