using NUnit.Framework;

namespace Experiments.Tests
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void FooReturnsValue()
		{
			var foo = new Foo();
			var value = foo.Do();
			Assert.NotNull(value);
			Assert.AreEqual(@"{""Bar"":1,""Baz"":""value""}", value);
		}

		[Test]
		public void TestToFail()
		{
			Assert.AreEqual(true, false);
		}
	}
}
