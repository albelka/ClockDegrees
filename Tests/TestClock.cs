using Xunit;
namespace ClockDegrees.Objects
{
  public class ClockTest
  {
    [Fact]
    public void FindShortestDistance_FindMinDegrees_36()
    {
      Clock newClock = new Clock(0,6);
      Assert.Equal(36, newClock.FindShortestDistance());
    }

  }
}
