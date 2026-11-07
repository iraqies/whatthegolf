namespace Rewired.Utils.Classes.Utility
{
	internal abstract class StopwatchBase
	{
		public abstract double offsetSeconds { get; }

		public abstract long offsetTicks { get; }

		public abstract double elapsedSeconds { get; }

		public abstract void Start();
	}
}
