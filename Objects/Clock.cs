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
			_minDegrees = _min * 6;
			_hourDegrees = (30 * _hour) + (_min / 2);
		}

		public int GetMinDegrees()
		{
			return _minDegrees;
		}

		public int GetHourDegrees()
		{
			return _hourDegrees;
		}

		public int FindShortestDistance()
		{
			return _hourDegrees;
		}
	}
}
