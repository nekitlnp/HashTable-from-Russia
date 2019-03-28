using NUnit.Framework;
using NUnit.Compatibility;
using HashTable;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestMassive3El()
        {
            string firstName = "Ïðèâåò", secondName = "Ñîñåä", thirdName = "Àíâàð";
            var hashTable = new HashTable(3);
            hashTable.PutPair(0, firstName);
            hashTable.PutPair(1, secondName);
            hashTable.PutPair(2, thirdName);
            Assert.AreEqual(firstName, hashTable.GetValueByKey(0));
            Assert.AreEqual(secondName, hashTable.GetValueByKey(1));
            Assert.AreEqual(thirdName, hashTable.GetValueByKey(2));
        }
    }
}
