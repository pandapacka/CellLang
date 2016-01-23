using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Organism.Cell;

namespace Organism
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Organism
    {
        //private static volatile Organism instance;
        //private static object syncRoot = new Object();
        //public static Organism Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (syncRoot)
        //            {
        //                if (instance == null)
        //                    instance = new Organism();
        //            }
        //        }

        //        return instance;
        //    }
        //}
        //private Organism()
        //{
        //    Init();
        //}
        public CellConfig cell_stats;
        public Organism()
        {
            Init();
        }
        public void Init()
        {
            cell_stats = new CellConfig();
        }
        public void Stats()
        {

        }
    }
}
