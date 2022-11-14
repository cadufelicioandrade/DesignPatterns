using DesignPatterns.GoF.Structural.Proxy.Interfaces;
using DesignPatterns.GoF.Structural.Proxy.Model;
using DesignPatterns.GoF.Structural.Proxy.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Proxy
{
    public class VPNProxy : IProxy
    {
        public void AcessarVPN(User user)
        {
            DataBaseConnection sql = new DataBaseConnection();
            sql.RegistrarAcesso(user);
            Console.WriteLine(new String('-', 40));
            VPN vpn = new VPN();
            vpn.AcessarVPN(user);
        }
    }
}
