using Core;
using UnityEngine;

namespace DanceOff
{
	public class DanceOffShooter : ShooterBase
	{
		[SerializeField]
		private Sequencer sequencer;

		[SerializeField]
		private Matrix4x4 inputToDanceDirMapping;

		private Vector2[] possibleDirections;

		public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
	}

		private Vector2 GetBestMatch(Vector2 rawDir)
		{
			return default;
		}
	}
}
