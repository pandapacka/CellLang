using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organism
{
    public interface IGameObject
    {
        void Step();
        string Name { get; set; }
    }
}
