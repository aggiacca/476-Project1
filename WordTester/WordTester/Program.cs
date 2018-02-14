using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTester
{
    class Program
    {
        static void Main(string[] args)
        {

            String input = "Word18";
            switch(input){

            }
            IGUIfactory factory = new Word90Factory();
            IButton button = factory.createButton();
            IPanel panel = factory.createPanel();
            ITextbox textbox = factory.createTextbox();

            Console.WriteLine(button.getDescription());
            Console.WriteLine(panel.getDescription());
            Console.WriteLine(textbox.getDescription());

            Console.ReadKey();
        }
    }
}
