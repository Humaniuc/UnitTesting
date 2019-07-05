using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ReversedAlphaString
{
    [TestFixture]
    class Tests
    {
        StringUtils stringUtils; 
        [SetUp]
        public void Init()
        {
            stringUtils = new StringUtils();
        }
        [TestCase("ab-cd", "dc-ba")]
        [TestCase("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
        [TestCase("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
        [TestCase("Test1ng-Leet=code-25Q!", "Qedo1ct-eeLg=ntse-25T!")]
        public void CheckReversed(string s, string expected)
        {
            var actual = stringUtils.ReverseUsingStringBuilder(s);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckEmptyOrNullString()
        {
            string actual = null;
            Assert.Throws<ArgumentNullException>(() => stringUtils.ReverseUsingStringBuilder(actual));
        }
    }
}
