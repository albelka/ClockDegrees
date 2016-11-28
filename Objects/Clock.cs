using System.Collections.Generic;
using System;

namespace ClockDegrees.Objects
{
	public class Clock
	{
		private int _hour;
		private int _min;
		private int _hourDegreesClockwise;
		private int _hourDegreesCounterClockwise;
		private int _minDegrees;

		public Clock(int hour, int min)
		{
			_hour = hour;
			_min = min;
			_minDegrees = _min * 6;
			_hourDegreesClockwise = (30 * _hour) + (_min / 2);
			_hourDegreesCounterClockwise = Math.Abs(_hourDegreesClockwise - 360);
		}

		public int GetMinDegrees()
		{
			return _minDegrees;
		}

		public int GetHourDegreesClockwise()
		{
			return _hourDegreesClockwise;
		}

		public int GetHourDegreesCounterClockwise()
		{
			return _hourDegreesCounterClockwise;
		}

		public int FindShortestDistance()
		{
			return _hour;
		}
	}
}
