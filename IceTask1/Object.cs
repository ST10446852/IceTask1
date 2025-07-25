using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask1
{
    class Object
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Object(int id, string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine($"Object Created: {Name} (ID: {Id})");
        }
        Object()
        {
            Console.WriteLine($"Object Finalized: {Name} (ID: {Id})");
        }
    }
}
