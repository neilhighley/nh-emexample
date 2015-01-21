using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationInterfaces;
using ApplicationModels;

namespace ApplicationLibrary
{
    public class MainMethods : IMainMethods
    {
        private IWordRepository _repo;
        private string _sentenceEntered;
        private string _responseTemplate = "";

        /// <summary>
        /// Constructor for Main Methods
        /// </summary>
        /// <param name="repo">The repository for negative words</param>
        public MainMethods(IWordRepository repo,string responseTemplate="Total Number of negative words:{0}")
        {
            _repo = repo;
            _responseTemplate = responseTemplate;
        }

        /// <summary>
        /// The sentence to be checked
        /// </summary>
        public string SentenceEntered
        {
            get { return _sentenceEntered; }
        }

        /// <summary>
        /// Count the number of negative words detected
        /// </summary>
        /// <param name="sentenceIn"></param>
        /// <returns></returns>
        public int NumberOfNegativeWords()
        {
            var cnt = 0;
            foreach (WordItem word in _repo.GetAll())
            {
                if (SentenceEntered.Contains(word.Name)) cnt++;
            }
            return cnt;
        }

        /// <summary>
        /// Add a sentence to be processed
        /// </summary>
        /// <param name="s"></param>
        public void AddSentenceForProcessing(string s)
        {
            _sentenceEntered = s;
        }

        /// <summary>
        /// Return the response text
        /// </summary>
        /// <returns></returns>
        public string GetResponse()
        {
            return string.Format(_responseTemplate, NumberOfNegativeWords());
        }

        public void AddNegativeWord(string NegativeWordForAddition)
        {
            _repo.Add(new WordItem() { Name = NegativeWordForAddition });
        }
        public void RemoveNegativeWord(string NegativeWordForAddition)
        {
            _repo.Remove(new WordItem() { Name = NegativeWordForAddition });
        }
    }
}
