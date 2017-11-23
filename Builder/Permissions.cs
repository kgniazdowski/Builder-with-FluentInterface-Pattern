using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Permissions
    {
        private Dictionary<string, List<string>> _permissions = new Dictionary<string, List<string>>();

        //Indexer
        public List<string> this[string key]
        {
            get { return _permissions[key]; }
            set { _permissions[key] = value; }
        }

        public void Show()
        {
            foreach (KeyValuePair<string, List<string>> permGroup in _permissions)
            {
                Console.WriteLine(permGroup.Key);
                permGroup.Value.ForEach(f => { Console.WriteLine("\t* " + f); });
            }
        }
    }
}
