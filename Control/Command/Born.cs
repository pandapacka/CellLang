using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organism;
using Organism.Cell;

namespace Control.Command
{
    public class Born:ICommand
    {
        Organism.Organism organism;

        public Born(Organism.Organism new_organism)
        {
            organism = new_organism;
        }
        public void exec(List<string> attributes)
        {
            string born_type = attributes[0];
            CellType cell_type = (CellType)Enum.Parse(typeof(CellType), attributes[1]);
            int count = Int32.Parse(attributes[2]);


            switch (born_type)
            {
                case "cell":
                    BornCell(cell_type, count);
                    break;
                default:
                    break;
            }
        }

        public void BornCell(CellType cell_type, int count)
        {
            switch (cell_type)
            {
                case CellType.DNA:
                    DNA dna_cell = new DNA();
                    organism.cell_stats.dock.Add(dna_cell);
                    break; 
            }
        }
    }
}
