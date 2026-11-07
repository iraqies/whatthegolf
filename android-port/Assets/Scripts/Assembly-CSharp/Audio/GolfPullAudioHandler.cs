using Core;
using UnityEngine;

namespace Audio
{
	public class GolfPullAudioHandler : MonoBehaviour
	{
		public bool overrideGlobalSetting;

		private GolfPullSimple pullSimple;

		private bool aiming;

		public GolfBallController ball { get; private set; }

		private void Awake()
		{
		}

		public void Initialize(GolfBallController _ball)
		{
		}

		public void Deinitialize()
		{
		}

		public void OnCancel()
		{
		}

		private void OnAimStart()
		{
		}

		private void OnAim(Vector3 boost, bool cancel)
		{
		}

		private void OnShoot(Vector3 boost)
		{
		}

		private void Update()
		{
		}
	}
}
