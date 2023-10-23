using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IPrintingContent text)
        {
            Console.WriteLine(text.GetTextToPrint());
        }
    }
}