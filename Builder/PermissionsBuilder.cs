using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class PermissionsBuilder
    {
        protected Permissions permissions = new Permissions();

        //public Permissions Permissions { get { return permissions; } }

        //Abstract methods
        public abstract PermissionsBuilder BuildGoodsPermissions();
        public abstract PermissionsBuilder BuildContractorPermissions();
        public abstract PermissionsBuilder BuildAdministrationPermissions();

        public static implicit operator Permissions(PermissionsBuilder permBuilder)
        {
            return permBuilder.BuildGoodsPermissions()
                            .BuildContractorPermissions()
                            .BuildAdministrationPermissions()
                            .permissions;
        }
    }
}
