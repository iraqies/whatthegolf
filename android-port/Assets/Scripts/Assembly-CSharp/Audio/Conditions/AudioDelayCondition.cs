namespace Audio.Conditions
{
	public abstract class AudioDelayCondition : AudioCondition
	{
		public float delay;

		public float NextTime { get; protected set; }
	}
}
