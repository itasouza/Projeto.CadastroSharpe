using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace UIConsole
{
    public class DBProduto:DbContext
    {
        public DbSet<Produto> produtos { get; set; }


    }
}
