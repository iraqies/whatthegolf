using System;

namespace Audio.Conditions
{
	[Serializable]
	public class SerializedAudioCondition
	{
		public Condition condition;

		public AudioCondition ConditionReference;
	}
}
