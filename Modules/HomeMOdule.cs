using Nancy;
using System.Collections.Generic;
using ClockDegrees.Objects;

namespace ClockDegrees
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};
		}
	}
}
