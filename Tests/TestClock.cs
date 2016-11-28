using Xunit;
using System;
namespace ClockDegrees.Objects
{
  public class ClockTest : IDisposable
  {
    [Fact]
    public void GetMinuteDegreesClockwise_FindMinuteDegrees_30()
    {
      Clock newClock = new Clock(0, 5);
      Assert.Equal(30, newClock.GetMinuteDegreesClockwise());
    }
    [Fact]
    public void GetMinuteDegreesCounterClockwise_FindMinuteDegrees_30()
    {
      Clock newClock = new Clock(0, 55);
      Assert.Equal(30, newClock.GetMinuteDegreesCounterClockwise());
    }
    [Fact]
    public void GetHourDegreesClockwise_FindHourDegrees_30()
    {
      Clock newClock = new Clock(1, 0);
      Assert.Equal(30, newClock.GetHourDegreesClockwise());
    }
    [Fact]
    public void GetHourDegreesCounterClockwise_FindHourDegrees_30()
    {
      Clock newClock = new Clock(11, 0);
      Assert.Equal(30, newClock.GetHourDegreesCounterClockwise());
    }
    [Fact]
    public void GetDistanceClockwise_FindDinstanceClockwise_308()
    {
      Clock newClock = new Clock (11, 4);
      Assert.Equal(308, newClock.FindDistanceClockwise());
    }
    [Fact]
    public void GetDistanceCounterClockwise_FindDinstanceCounterClockwise_52()
    {
      Clock newClock = new Clock (11, 4);
      Assert.Equal(52, newClock.FindDistanceCounterClockwise());
    }
    [Fact]
    public void GetShortestDistance_FindShortestDistance_52()
    {
      Clock newClock = new Clock (1, 56);
      Assert.Equal(82, newClock.FindShortestDistance());
    }
    public void Dispose()
    {
      Clock.DeleteAll();
    }
  }
}
