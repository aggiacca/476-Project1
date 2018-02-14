using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTester
{

    class Word10Factory : IGUIfactory
    {
        public IButton createButton()
        {
            return new Word10Button();
        }
        public IPanel createPanel()
        {
            return new Word10Panel();
        }
        public ITextbox createTextbox()
        {
            return new Word10Textbox();
        }

    }

    class Word10Button : IButton
    {
        public String getDescription()
        {
            return ("Word10 Button");
        }
    }

    class Word10Panel : IPanel
    {
        public String getDescription()
        {
            return ("Word10 Panel");
        }
    }

    class Word10Textbox : ITextbox
    {
        public String getDescription()
        {
            return ("Word10 Textbox");
        }
    }
}
