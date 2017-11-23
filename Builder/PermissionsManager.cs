using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class PermissionsManager
    {
        public Permissions Construct(PermissionsBuilder permBuilder) => permBuilder;
    }
}
