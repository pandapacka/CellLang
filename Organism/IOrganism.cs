using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Organism.Cell;
using Organism.Generator;
using Organism.Organ;

namespace Organism
{
    interface IOrganism:IGameObject
    {
        List<IOrgan> Organs { get; }
        List<ICell> Cells { get; }
        List<IGenerator> Generators { get; }
        IOrgan AddOrgan(OrganConfig config);
    }
}
