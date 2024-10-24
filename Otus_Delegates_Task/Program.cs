using Otus_Delegates_Task;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSearcher searcher = new FileSearcher();
            searcher.FileFound += Searcher_Found;

            searcher.SearchDirectory(@"C:\Users\head\source\repos\Otus_Delegates_Task\Otus_Delegates_Task");
        }

        private static void Searcher_Found(object sender, FileArgs e)
        {
            Console.WriteLine($"Файл нашли : {e.FileName}");
            if(e.FileName.EndsWith(".txt"))
            {
                e.Cancel = true;
            }
        }
    }
}



