using DesignPatterns.GoF.Structural.Proxy.Interfaces;
using DesignPatterns.GoF.Structural.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Proxy
{
    public class VPN : IProxy
    {
        public void AcessarVPN(User user)
        {
            Console.WriteLine("[+] - Acessando VPN\n");
            Thread.Sleep(2000);
            Console.WriteLine($"{user.Username}, você está logado na VPN");
        }
    }
}
