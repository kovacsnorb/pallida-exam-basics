using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueCharacters;

namespace UniqueCharTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void UniqueCharTest_AllCharUnique()
        {
            string input = "falunep";
            char[] output = { 'f', 'a', 'l', 'u', 'n', 'e', 'p' };
            Assert.AreEqual(output, UniqueCharacters.Program.GetUniqueCharacters(input));
        }

        [Test]
        public void UniqueCharTest_MixedCharacters()
        {
            string input = "rekettyes";
            char[] output = { 'r', 'k', 'y', 's' };
            Assert.AreEqual(output, UniqueCharacters.Program.GetUniqueCharacters(input));
        }

        [Test]
        public void UniqueCharTest_NoUniqueCharacters()
        {
            string input = "ette";
            char[] output = { };
            Assert.AreEqual(output, UniqueCharacters.Program.GetUniqueCharacters(input));
        }
    }
}
