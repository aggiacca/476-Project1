using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTester
{

    class Word18Factory : IGUIfactory
    {
        public IButton createButton()
        {
            return new Word18Button();
        }
        public IPanel createPanel()
        {
            return new Word18Panel();
        }
        public ITextbox createTextbox()
        {
            return new Word18Textbox();
        }

    }

    class Word18Button : IButton
    {
        public String getDescription()
        {
            return ("Word18 Button");
        }
    }

    class Word18Panel : IPanel
    {
        public String getDescription()
        {
            return ("Word18 Panel");
        }
    }

    class Word18Textbox : ITextbox
    {
        public String getDescription()
        {
            return ("Word18 Textbox");
        }
    }
}
