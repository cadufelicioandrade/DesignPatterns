using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Creationals.Singleton
{
    public class Client
    {
        public void AcessarBD()
        {
            var context = ContextDB.Instancia;
            context.OpenConnection("Select * from table;");

            context = ContextDB.Instancia;
            context.OpenConnection("Insert Into table (teste) values (001);");

            context = ContextDB.Instancia;
            context.OpenConnection("Update table set teste=022 where id=01;");

            context = ContextDB.Instancia;
            context.OpenConnection("Delete table where id=01;");
        }
    }
}
