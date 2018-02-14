using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTester
{

    class Word90Factory : IGUIfactory
    {
        public IButton createButton()
        {
            return new Word90Button();
        }
        public IPanel createPanel()
        {
            return new Word90Panel();
        }
        public ITextbox createTextbox()
        {
            return new Word90Textbox();
        }

    }

    class Word90Button : IButton
    {
        public String getDescription()
        {
            return ("Word90 Button");
        }
    }

    class Word90Panel : IPanel
    {
        public String getDescription()
        {
            return ("Word90 Panel");
        }
    }

    class Word90Textbox : ITextbox
    {
        public String getDescription()
        {
            return ("Word90 Textbox");
        }
    }
}
