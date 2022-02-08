using System;
using nuspecgen.servico;

namespace nuspecgen
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = args[0];
            string version = args[1];
            string authors = args[2];
            string description = args[3];
            string files = args[4];
            string nuspec = args[5];

            ControleExecucao controleExecucao = new ControleExecucao();

            controleExecucao.exec(id, version, authors, description, files, nuspec);

        }
    }
}
