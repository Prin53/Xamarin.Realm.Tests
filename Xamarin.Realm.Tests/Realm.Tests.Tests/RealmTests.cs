using NUnit.Framework;

namespace Realm.Tests.Tests
{
    [TestFixture]
    public class RealmTests
    {
        [Test]
        public void GetInstance_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => Realms.Realm.GetInstance());
        }
    }
}