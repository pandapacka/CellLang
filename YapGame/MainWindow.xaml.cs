using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Control;
using Organism.Cell;
using Organism;

namespace YapGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Organism.Organism organism;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Paint(organism);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button.Visibility = Visibility.Visible;
            button1.Visibility = Visibility.Hidden;
            string code = textBox.Text;
            organism = new Organism.Organism();
            Captain go = new Captain(code, organism);
            
        }
        private void Paint(Organism.Organism organism)
        {
            string label_text;
            CellConfig work_cells = organism.cell_stats;

            label_text = "Cells:\r";
            label_text += "--------------------------\n";
            label_text += PaintCells(work_cells);
            label_text += "--------------------------\n";
            label_text += "Generators:\r";
            label.Content = label_text;
        }
        private string PaintCells(CellConfig work_cell)
        {
            Dictionary<string, List<ICell>> cells = new Dictionary<string, List<ICell>>();
            foreach(CellType type in Enum.GetValues(typeof(CellType)))
            {
                List<ICell> list_cells = work_cell.dock.Where(x => x.GetType().Equals(type)).ToList();
                cells.Add(type.ToString(), list_cells);
            }
            string string_cells = "";
            foreach(var pair in cells)
            {
                string_cells += "\t" + pair.Key + "\t"+pair.Value.Count.ToString()+"\n";
            }
            return string_cells;    
        }
    }
}
