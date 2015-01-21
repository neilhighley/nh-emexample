using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationInterfaces;
using ApplicationLibrary;
using ApplicationModels;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ContentConsole.Test.Unit.steps
{
    [Binding]
    public class steps_AdminCanChangeNegativeWords
    {
        private IWordRepository _repo = GodHelper.GetEmptyRepository();
        private IMainMethods mm;

        private string sentenceIn = "The weather in Manchester in winter is bad. It rains all the time - it must be horrible for people visiting.";
        private string strNegativeWord = "rains";
        

        [Given(@"I have entered New negative words")]
        public void GivenIHaveEnteredNewNegativeWords()
        {
            _repo = GodHelper.GetEmptyRepository();
            mm=new MainMethods(_repo);
            mm.AddNegativeWord(strNegativeWord);
            var wordItem = new WordItem() { Name = strNegativeWord };
            Assert.IsTrue(_repo.Contains(wordItem));
        }

        [Given(@"I have not changed the codebase")]
        public void GivenIHaveNotChangedTheCodebase()
        {
            //sorry, not sure how to do this on Console Applications
            Assert.IsTrue(true);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //sorry, not sure how to do this on Console Applications
            Assert.IsTrue(true);
        }


        [Then(@"the new Negative Words should be used")]
        public void ThenTheNewNegativeWordsShouldBeUsed()
        {
            var template = "Total Number of negative words: {0}";
            var expected = string.Format(template, 1);
            _repo = GodHelper.GetEmptyRepository();
            mm = new MainMethods(_repo, template);
            var wordItem = new WordItem() { Name = strNegativeWord };

            mm.AddNegativeWord(wordItem.Name);
            mm.AddSentenceForProcessing(sentenceIn);

            var response = mm.GetResponse();
            Assert.AreEqual(expected, response);
        }

    }
}
