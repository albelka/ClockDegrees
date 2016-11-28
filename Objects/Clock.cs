using System.Collections.Generic;
using System;

namespace ClockDegrees.Objects
{
	public class Clock
	{
		private int _hour;
		private int _minute;
		private int _hourDegreesClockwise;
		private int _hourDegreesCounterClockwise;
		private int _minuteDegrees;

		public Clock(int hour, int minute)
		{
			_hour = hour;
			_minute = minute;
			_minuteDegrees = _minute * 6;
			_hourDegreesClockwise = (30 * _hour) + (_minute / 2);
			_hourDegreesCounterClockwise = Math.Abs(_hourDegreesClockwise - 360);
		}

		public int GetMinuteDegrees()
		{
			return _minuteDegrees;
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
		public int FindDistanceClockwise()
		{
			return Math.Abs(_hourDegreesClockwise-_minuteDegrees);
		}
	}
}
