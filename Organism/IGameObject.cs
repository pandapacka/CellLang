using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organism
{
    interface IGameObject
    {
        void Step();
        string Name { get; }
    }
}
