using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationInterfaces;
using ApplicationLibrary;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ContentConsole.Test.Unit.steps
{
    [Binding]
    public class Steps_UserCanSeeNegativeWordsInSubject
    {
        private IWordRepository _repo = GodHelper.GetPopulatedRepository();
        private ApplicationLibrary.MainMethods mm;

        private string sentenceIn = "The weather in Manchester in winter is bad. It rains all the time - it must be horrible for people visiting.";
        

        [Given(@"I have entered a sentence")]
        public void GivenIHaveEnteredASentence()
        {
                mm=new MainMethods(_repo);
                mm.AddSentenceForProcessing(sentenceIn);

                Assert.AreEqual(sentenceIn,mm.SentenceEntered);
        }

        [When(@"I submit ""(.*)""")]
        public void WhenISubmit(string p0)
        {
            sentenceIn = p0;

            mm = new MainMethods(_repo);
            mm.AddSentenceForProcessing(sentenceIn);

            Assert.AreEqual(p0, mm.SentenceEntered);
        }

        [Then(@"the result should be ""(.*)"" on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            var template = "Total Number of negative words: {0}";
            mm = new MainMethods(_repo,template);
            mm.AddSentenceForProcessing(sentenceIn);
            var response=mm.GetResponse();
            Assert.AreEqual(p0, response);
        }

    }
}
