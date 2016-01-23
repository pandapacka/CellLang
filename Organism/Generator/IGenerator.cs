using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Organism.Cell;
using Organism.Organ;

namespace Organism.Generator
{
    interface IGenerator : IGameObject
    {
        CellType Type { get; }
        IOrganism Organism { get; }
        IOrgan Organ { get; }
        ICell Generate();
    }
}
