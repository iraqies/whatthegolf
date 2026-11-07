namespace Chronos
{
	public interface IAreaClock
	{
		ClockBlend innerBlend { get; }

		void Release(Timeline timeline);

		float TimeScale(Timeline timeline);
	}
}
