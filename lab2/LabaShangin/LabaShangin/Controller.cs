using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaShangin
{
    class Controller
    {
        string TextBox;
	    string Path;
        public void writer(string FileDirectory, string Text)
        {
            TextBox = Text;
            Path = FileDirectory;
            var w = new Model();
            w.write(Path, Text);
        }
        public string reader(string FileDirectory)
	{
	Path = FileDirectory;
	var r = new Model();
	TextBox = r.read(Path);
	return TextBox;
	}
}
}
