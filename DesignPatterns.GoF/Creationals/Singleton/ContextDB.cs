using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Creationals.Singleton
{
    public class ContextDB
    {
        private static ContextDB _instancia = null;

        private ContextDB()
        {
        }

        public static ContextDB Instancia 
        { 
            get 
            {
                if(_instancia == null)
                {
                    _instancia = new ContextDB();
                    Console.WriteLine("Instância ContextDB Criada");
                }

                return _instancia; ;
            } 
        }

        public void OpenConnection(string mensagem)
        {
            Console.WriteLine(mensagem);
        }


    }
}
