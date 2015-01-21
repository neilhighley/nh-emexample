using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationInterfaces
{

    public interface IMainMethods
    {
        /// <summary>
        /// Count the number of negative words detected
        /// </summary>
        /// <param name="sentenceIn"></param>
        /// <returns></returns>
        int NumberOfNegativeWords();

        /// <summary>
        /// Add a sentence to be processed
        /// </summary>
        /// <param name="s"></param>
        void AddSentenceForProcessing(string s);

        /// <summary>
        /// Return the response text
        /// </summary>
        /// <returns></returns>
        string GetResponse();

        void AddNegativeWord(string NegativeWordForAddition);
        void RemoveNegativeWord(string NegativeWordForAddition);
    }

}
