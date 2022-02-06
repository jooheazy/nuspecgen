using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nuspecgen.servico
{
    
    public class ControleExecucao
    {
        public const string constFile = "< file src=#file# />";
        public const string constbreakline = "/r/n";
        public const string constid = "#id#";
        public const string constversion = "#version#";
        public const string constauthors = "#authors#";
        public const string constdesc = "#description#";
        public const string constfiles = "#files#";

        public void exec (string id, string version, string authors, string description, string files, string nuspec)
        {
            ControleTemplate controleTemplate = new ControleTemplate();

            string strTemp = controleTemplate.template();

            strTemp = strTemp.Replace(constid, id);
            strTemp = strTemp.Replace(constversion, version);
            strTemp = strTemp.Replace(constauthors, authors);
            strTemp = strTemp.Replace(constdesc, description);
            strTemp = strTemp.Replace(constfiles, files);

            File.WriteAllText(nuspec, strTemp);

        }

        public string buildfile(string src)
        {
            DirectoryInfo dir = new DirectoryInfo(src);

            string strreturn= "";

            foreach(FileInfo file in dir.GetFiles())
            {
                strreturn = strreturn + constbreakline + constFile.Replace(constfiles, file.FullName);
            }

            return strreturn;

        }
        

    }
}
