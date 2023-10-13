using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class CityHierarchy
    {
        private Dictionary<string, string> hierarchy = new Dictionary<string, string>();

        public void Add(string child, string parent)
        {
            hierarchy[child] = parent;
        }

        public void FindParent(string child)
        {
            if (hierarchy.ContainsKey(child))
            {
                string parent = hierarchy[child];
                Console.WriteLine(child);
                if (parent != "-1")
                {
                    FindParent(parent);
                }
            }
        }
    }
}
