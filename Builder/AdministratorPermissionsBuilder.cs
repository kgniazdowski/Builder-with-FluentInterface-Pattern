using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class AdministratorPermissionsBuilder : PermissionsBuilder
    {
        public override PermissionsBuilder BuildAdministrationPermissions()
        {
            permissions["Administration"] = new List<string>
            {
                "Show profile info",
                "Edit profile info",
                "Show other users profile info",
                "Edit other users profile info"
            };
            return this;
        }

        public override PermissionsBuilder BuildContractorPermissions()
        {
            permissions["Contractors"] = new List<string>
            {
                "Show contractor",
                "Add contractor",
                "Edit contractor",
                "Delete contractor"
            };
            return this;
        }

        public override PermissionsBuilder BuildGoodsPermissions()
        {
            permissions["Goods"] = new List<string>
            {
                "Show goods",
                "Add good",
                "Edit good",
                "Delete good"
            };
            return this;
        }
    }
}
