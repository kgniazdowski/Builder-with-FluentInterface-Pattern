using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BasicPermissionsBuilder : PermissionsBuilder
    {
        public override PermissionsBuilder BuildAdministrationPermissions()
        {
            permissions["Administration"] = new List<string>
            {
                "Show profile info",
                "Edit profile info"
            };
            return this;
        }

        public override PermissionsBuilder BuildContractorPermissions()
        {
            permissions["Contractors"] = new List<string>
            {
                "Show contractors"
            };
            return this;
        }

        public override PermissionsBuilder BuildGoodsPermissions()
        {
            permissions["Goods"] = new List<string>
            {
                "Show goods"
            };
            return this;
        }
    }
}
