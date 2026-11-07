using UnityEngine;

namespace Audio
{
	public class AudioValueDistance : BaseAudioValue
	{
		public enum DistanceListenType
		{
			DISTANCE = 0,
			DISTANCE_ON_Y = 1
		}

		public Transform obj1;

		public Transform obj2;

		public DistanceListenType listenType;

		protected override bool Use2D => false;

		private void Update()
		{
		}

		public override string ValueInputName()
		{
			return null;
		}

		protected override void SetValue()
		{
		}
	}
}
