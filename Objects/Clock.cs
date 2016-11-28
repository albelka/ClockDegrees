using System.Collections.Generic;

namespace ClockDegrees.Objects
{
	public class Clock
	{
		private int _hour;
		private int _min;
		private int _hourDegrees;
		private int _minDegrees;

		public Clock(int hour, int min)
		{
			_hour = hour;
			_min = min;
		}

		public int FindShortestDistance()
		{
			_minDegrees = _min * 6;
			return _minDegrees;
		}
	}
}
