using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Organism.Cell;
using Organism.Generator;

namespace Organism.Organ
{
    interface IOrgan:IGameObject
    {
        IOrganism Organism { get; }
        List<IGenerator> Genaratos { get; }
        List<ICell> Cells { get; }
        IGenerator AddGenarator(GeneratorConfig config);
    }
}
