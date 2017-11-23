using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //FluentInterface:
            PermissionsManager permManager = new PermissionsManager();

            Permissions basicPermissions = permManager.Construct(new BasicPermissionsBuilder());            
            basicPermissions.Show();

            Console.Write("\n\n\n");

            Permissions adminPermissions = permManager.Construct(new AdministratorPermissionsBuilder());
            adminPermissions.Show();

            Console.ReadKey();
        }
    }
}
