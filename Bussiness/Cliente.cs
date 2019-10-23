using Bussiness;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Cliente : Contrato
    {
        private readonly Conexao cmd;


        public async override IList<ClienteModel> Pesquisar()
        {
            var resultado = await cmd.conexao();

            return resultado;
        }
    }
}
