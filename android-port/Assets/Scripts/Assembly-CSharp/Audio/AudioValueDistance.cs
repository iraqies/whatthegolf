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
			if (obj1 == null || obj2 == null)
				return;
			SetValue();
		}

		public override string ValueInputName()
		{
			string n1 = (obj1 != null && obj1.gameObject != null) ? obj1.gameObject.name : "";
			string n2 = (obj2 != null && obj2.gameObject != null) ? obj2.gameObject.name : "";
			return string.Format("{0} ({1}, {2})", listenType.ToString().ToLower(), n1, n2);
		}

		protected override void SetValue()
		{
			if (obj1 != null && obj2 != null)
			{
				if (listenType == DistanceListenType.DISTANCE)
					value = Vector3.Distance(obj1.position, obj2.position);
				else if (listenType == DistanceListenType.DISTANCE_ON_Y)
					value = obj2.position.y - obj1.position.y;
			}
			base.SetValue();
		}
	}
}
