using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yaml2code.Models
{
    public class ObjectType
    {
        public string Name { get; set; }
        public List<string> Fields { get; set; }
        public string InheritsFrom { get; set; }
        ///TODO: Crear campo de Interfaces 
        public ObjectType()
        {
            Fields = new List<string>();
        }
    }
}
