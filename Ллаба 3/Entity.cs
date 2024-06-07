using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ллаба_3
{
    public abstract class Entity
    {
        public string? Name { get; set; }
    }

    // Класс Мастер
    public class Master : Entity
    {
        public Master(string name)
        {
            Name = name;
        }
    }
}
