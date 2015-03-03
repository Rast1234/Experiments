using Newtonsoft.Json;

namespace Experiments
{
	public class Foo
	{
		public string Do()
		{
			var x = new
			{
				Bar = 1,
				Baz = "value"
			};
			return JsonConvert.SerializeObject(x);
		}
	}
}
