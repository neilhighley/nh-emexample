using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationInterfaces;
using ApplicationModels;

namespace ApplicationData
{
    public class WordRepository:IWordRepository
    {
        private List<WordItem> _items = new List<WordItem>();

        public List<WordItem> GetAll()
        {
            return _items;
        }

        public void Add(WordItem wi)
        {
            _items.Add(wi);
        }
        public void Remove(WordItem wi)
        {
            _items.Remove(wi);
        }

        public bool Contains(WordItem wi)
        {
            foreach (var w in _items)
            {
                if (w.Name == wi.Name) return true;
            }
            return false;
        }
    }
}
