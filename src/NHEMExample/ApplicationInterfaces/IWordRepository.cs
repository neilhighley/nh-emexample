using System.Collections.Generic;
using ApplicationModels;

namespace ApplicationInterfaces
{
    /// <summary>
    /// Repository to hold the word list
    /// </summary>
    public interface IWordRepository:IRepository<WordItem>
    {
        List<WordItem> GetAll();
        void Add(WordItem wi);
        void Remove(WordItem wordItem);
        bool Contains(WordItem wordItem);
    }
}
