using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nuspecgen.servico
{
    public class ControleTemplate
    {
        public string template()
        {
            string file;

            file = File.ReadAllText("template\\template.txt");

            return file;
        }
    }
}
