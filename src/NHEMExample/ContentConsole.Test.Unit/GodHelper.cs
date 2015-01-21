using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationData;
using ApplicationInterfaces;
using ApplicationModels;

namespace ContentConsole.Test.Unit
{
    public class GodHelper
    {
        public static IWordRepository GetPopulatedRepository()
        {
            var repo = new WordRepository();
            repo.Add(new WordItem()
            {
                Name = "bad"
            });
            repo.Add(new WordItem()
            {
                Name = "horrible"
            });

            return repo;
        }
        public static IWordRepository GetEmptyRepository()
        {
            var repo = new WordRepository();
            return repo;
        }
    }
}
