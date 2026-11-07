using UnityEngine;

namespace Audio
{
	public class WreckingBallTowerAudio : MonoBehaviour
	{
		public IntroLoopOutro rotationAudio;

		public AudioValueRigidbody rotationValue;

		public float timeToStartLoop;

		public float minValue;

		public float maxValue;

		public float timeToEndLoop;

		public Transform Extendable;

		public AudioSource extendableSource;

		public float volume;

		private float rot_value;

		private float offTimer;

		private float onTimer;

		private float ext_pos_Z;

		private float ext_delta;

		private float ext_vol;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRotationValueChange(float v)
		{
		}

		private void Update()
		{
		}
	}
}
