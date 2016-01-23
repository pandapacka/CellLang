using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organism.Cell
{
    public class CellConfig
    {
        public List<ICell> dock;
        public CellConfig()
        {
            dock = new List<ICell>();
        }
        
    }
}
