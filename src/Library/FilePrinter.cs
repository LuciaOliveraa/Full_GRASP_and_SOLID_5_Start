using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IPrintingContent text)
        {
            File.WriteAllText("Recipe.txt", text.GetTextToPrint());
        }
    }
}