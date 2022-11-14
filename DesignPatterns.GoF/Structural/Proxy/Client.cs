using DesignPatterns.GoF.Structural.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Proxy
{
    public class Client
    {
        public void ConectarClientVPN()
        {
            VPNProxy proxy = new VPNProxy();

            Console.Write("Digite o UserName: ");
            string username = Console.ReadLine();

            Console.Write("Digite o Password: ");
            string password = Console.ReadLine();

            var user = new User(username, password);
            proxy.AcessarVPN(user);
        }
    }
}
