using UnityEngine;

namespace GolfGames.Pinball
{
	public class PinballFlipper : MonoBehaviour
	{
		[SerializeField]
		public PinballFlipperType Type;

		[SerializeField]
		public HingeJoint2D Joint;

		private float startMotorSpeed;

		private void Start()
		{
		}

		public void Toggle(bool isFlipped)
		{
		}
	}
}
