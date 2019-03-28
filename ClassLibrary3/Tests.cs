using NUnit.Framework;
using Hash;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1 ()
        {
            string firstName = "Frog", secondName = "Eagle", thirdName = "Pizza";
            var hashTable = new HashTable(3);
            hashTable.PutPair (0, firstName);
            hashTable.PutPair (1, secondName);
            hashTable.PutPair (2, thirdName);
            Assert.AreEqual (firstName, hashTable.GetValueByKey (0));
            Assert.AreEqual (secondName, hashTable.GetValueByKey (1));
            Assert.AreEqual (thirdName, hashTable.GetValueByKey (2));
        }

        [Test]
        public void Test2 ()
        {
            var hashTable = new HashTable (2);
            hashTable.PutPair (2, 1);
            hashTable.PutPair (2, 3);
            Assert.AreEqual (3, hashTable.GetValueByKey (2));
        }

        [Test]
        public void Test3 ()
        {
            var hashTable = new HashTable (10000);
            for (var i = 0; i < 10000; i++)
            {
                hashTable.PutPair ((i * 1000), i);
            }
            Assert.AreEqual (9, hashTable.GetValueByKey (9000));
        }

        [Test]
        public void Test4 ()
        {
            var hashTable = new HashTable(10000);
            for (int i = 0; i < 10000; i++)
            {
                hashTable.PutPair(i, i * 1000);
            }
            for (int i = 10000; i < 11000; i++)
            {
                Assert.AreEqual(hashTable.GetValueByKey(i), null);
            }
        }
    }
}
