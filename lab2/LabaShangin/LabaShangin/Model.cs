using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaShangin
{
    class Model
    {
    public string read(string path)
{
            var s = System.IO.File.ReadAllText(path, Encoding.UTF8);
            return s;
}
    public void write(string path, string Text)
    {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path))
            {
                file.Write(Text, Encoding.UTF8);
            }
        }
}
}
