using System;
using ApplicationData;
using ApplicationInterfaces;
using ApplicationLibrary;
using ApplicationModels;

namespace ContentConsole
{
    public static class Program
    {
        private static IWordRepository _repo;

        public static void Main(string[] args)
        {
            _repo=new WordRepository();

            _repo.Add(new WordItem() { Name = "swine" });
            _repo.Add(new WordItem() { Name = "bad" });
            _repo.Add(new WordItem() { Name = "nasty" });
            _repo.Add(new WordItem() { Name = "horrible" });

            var mm = new MainMethods(_repo, "Total Number of negative words:{0}");

            string content =
                "The weather in Manchester in winter is bad. It rains all the time - it must be horrible for people visiting.";

            mm.AddSentenceForProcessing(content);
           
            Console.WriteLine("Scanned the text:");
            Console.WriteLine(content);
            Console.WriteLine(mm.GetResponse());

            Console.WriteLine("Press ANY key to exit.");
            Console.ReadKey();
        }
    }

}
