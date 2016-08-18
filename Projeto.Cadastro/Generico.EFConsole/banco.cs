using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generico.EF;

namespace Generico.EFConsole
{
    class banco
    {
        public void cadastrar(string nome, string endereco)
        {
            var db = new BANCOESTUDOEntities();
            var cliente = db.TB_CLIENTE.Create();

            cliente.NOME = nome;
            cliente.ENDERECO = endereco;
            db.TB_CLIENTE.Add(cliente);
            db.SaveChanges();

        }




    }
}
