using Xunit;
namespace ClockDegrees.Objects
{
  public class ClockTest
  {
    [Fact]
    public void GetMinDegrees_FindMinDegrees_36()
    {
      Clock newClock = new Clock(1, 6);
      Assert.Equal(36, newClock.GetMinDegrees());
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
  }
}
