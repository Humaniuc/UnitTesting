using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GoatLatin
{
    
    [TestFixture]
    class SentenceTests
    {
        GoatLatin goat;
        [SetUp]
        public void Init()
        {
            goat = new GoatLatin();
        }
        [TestCase("I speak Goat Latin", "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]
        [TestCase("The quick brown fox jumped over the lazy dog", "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]
        public void CheckSentence(string s, string expected)
        {
            string actual = goat.GoatLatinSentence(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
