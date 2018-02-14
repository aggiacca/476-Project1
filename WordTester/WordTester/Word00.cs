using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTester
{

    class Word00Factory : IGUIfactory
    {
        public IButton createButton()
        {
            return new Word00Button();
        }
        public IPanel createPanel()
        {
            return new Word00Panel();
        }
        public ITextbox createTextbox()
        {
            return new Word00Textbox();
        }

    }

    class Word00Button : IButton
    {
        public String getDescription()
        {
            return ("Word00 Button");
        }
    }

    class Word00Panel : IPanel
    {
        public String getDescription()
        {
            return ("Word00 Panel");
        }
    }

    class Word00Textbox : ITextbox
    {
        public String getDescription()
        {
            return ("Word00 Textbox");
        }
    }
}
