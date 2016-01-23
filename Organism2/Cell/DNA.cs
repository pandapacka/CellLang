using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organism.Organ;

namespace Organism.Cell
{
    public class DNA : ICell
    {

        public DNA()
        {
            HP = 10;
            Name = "DNA";
        }
        public int HP
        {
            get;
            private set;
        }

        public string Name{get;set;}

        public IOrgan Organ
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IOrganism Organism
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CellType Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Kill()
        {
            throw new NotImplementedException();
        }

        public void Step()
        {
            HP -= 1;
        }
    }
}
