using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organism;
using Control.Command;

namespace Control
{
    public class Captain
    {
        const char stop_symbol = '.';
        Organism.Organism organism;
        string code;
        public Captain(string new_code, Organism.Organism new_organism)
        {
            code = new_code;
            organism = new_organism;
            Parser parser = new Parser();
            List<string> lines = code.Split(stop_symbol).ToList();

            for (var i=0; i<lines.Count; i++)
            {
                string line = lines[i];

                string after_parse = parser.Parse(line);
                List<string> attributes = after_parse.Split().ToList();
                CommandEnum command = (CommandEnum)Enum.Parse(typeof(CommandEnum), attributes[0]);
                attributes.RemoveAt(0);
                exec(command, attributes, organism);
                
            }


           
        }
        public void exec(CommandEnum command, List<string> attributes, Organism.Organism organism)
        {
            switch (command)
            {
                case CommandEnum.born:
                    Born born = new Born(organism);
                    born.exec(attributes);
                    break;
                default:
                    break;
            }
        }
    }
}
