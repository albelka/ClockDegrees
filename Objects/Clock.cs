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
		private int _minuteDegreesClockwise;
		private int _minuteDegreesCounterClockwise;
		private static List<Clock> _allClocks = new List<Clock>{};

		public static void DeleteAll()
		{
			_allClocks.Clear();
		}

		public Clock(int hour, int minute)
		{
			_allClocks.Add(this);
			_hour = hour;
			_minute = minute;
			_minuteDegreesClockwise = _minute * 6;
			_minuteDegreesCounterClockwise = Math.Abs(_minuteDegreesClockwise - 360);
			_hourDegreesClockwise = (30 * _hour) + (_minute / 2);
			_hourDegreesCounterClockwise = Math.Abs(_hourDegreesClockwise - 360);
		}

		public int GetMinuteDegreesClockwise()
		{
			return _minuteDegreesClockwise;
		}

		public int GetMinuteDegreesCounterClockwise()
		{
			return _minuteDegreesCounterClockwise;
		}

		public int GetHourDegreesClockwise()
		{
			return _hourDegreesClockwise;
		}

		public int GetHourDegreesCounterClockwise()
		{
			return _hourDegreesCounterClockwise;
		}

		public int FindDistanceClockwise()
		{
			return Math.Abs(_hourDegreesClockwise + _minuteDegreesCounterClockwise) % 360;
		}

		public int FindDistanceCounterClockwise()
		{
			return Math.Abs(_hourDegreesCounterClockwise + _minuteDegreesClockwise) % 360;
		}
		public int FindShortestDistance()
		{
			int counterClockwise = this.FindDistanceCounterClockwise();
			int clockwise = this.FindDistanceClockwise();
			if (counterClockwise <= clockwise)
			{
				return counterClockwise;
			}
			else
			{
				return clockwise;
			}
		}
	}
}
