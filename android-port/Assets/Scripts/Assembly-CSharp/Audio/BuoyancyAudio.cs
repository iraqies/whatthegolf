using Buoyancy;
using UnityEngine;

namespace Audio
{
	public class BuoyancyAudio : MonoBehaviour
	{
		[SerializeField]
		private GameObject[] buoyancyGameObjects;

		[SerializeField]
		private float audioCooldown;

		[SerializeField]
		private MinMax volumeRange;

		[SerializeField]
		private MinMax pitchRange;

		[SerializeField]
		private MinMax waterHitVelocityRange;

		[SerializeField]
		private ClipSettingsCollection skipClips;

		[SerializeField]
		private ClipSettingsCollection splashClips;

		private IBuoyant[] buoyantObjects;

		private float nextSkipSfxTime;

		private float nextSplashSfxTime;

		private Vector3 AudioPosition => default;

		private void Awake()
		{
		}

		private void BuoyancyTarget_OnEnterWaterNoSkip(Vector3 obj)
		{
		}

		private void BuoyancyTarget_OnPostSkip(Vector3 obj)
		{
		}
	}
}
