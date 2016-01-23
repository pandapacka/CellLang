using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Organism.Organ;

namespace Organism.Cell
{
    public interface ICell : IGameObject
    {
        int HP { get; }
        CellType Type { get; }
        IOrganism Organism { get; }
        IOrgan Organ { get; }
        void Kill();
    }
}
