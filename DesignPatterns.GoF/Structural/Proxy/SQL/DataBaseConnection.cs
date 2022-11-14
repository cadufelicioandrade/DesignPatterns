using DesignPatterns.GoF.Structural.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Proxy.SQL
{
    public class DataBaseConnection
    {
        public void RegistrarAcesso(User user)
        {
            var query = $"INSERT INTO TB_RegistroVPN (User, Password, DataHora)\nVALUES ('{user.Username}', '{user.Password}', {DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")})\n";

            Console.WriteLine("\n[!] Registrando acesso pelo Proxy. . .\n");
            Console.WriteLine(query);
        }
    }
}
