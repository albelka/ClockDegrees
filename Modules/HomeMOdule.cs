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
				Dictionary<string, Clock> pageData = new Dictionary<string, Clock>();
				return View["index.cshtml", pageData];
			};
			Post["/"] = _ =>
			{
				Dictionary<string, Clock> pageData = new Dictionary<string, Clock>();
				int minutes = int.Parse(Request.Form["minute"]);
				int hours = int.Parse(Request.Form["hour"]);
				Clock newClock = new Clock(hours, minutes);
				pageData["newClock"] = newClock;
				return View["index.cshtml", pageData];
			};
		}
	}
}
