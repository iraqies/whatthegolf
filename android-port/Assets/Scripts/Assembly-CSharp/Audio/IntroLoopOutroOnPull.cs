using Core;
using UnityEngine;

namespace Audio
{
	public class IntroLoopOutroOnPull : MonoBehaviour
	{
		public IntroLoopOutro loop;

		public GolfBallController ball;

		public float stopAfterTimeInactive;

		public bool blockStart;

		public bool stopOnShoot;

		public bool stopOnCancel;

		public float cooldown;

		private float lastBoost;

		private bool lastBlockState;

		private float timer;

		private bool stop;

		private float nextStartTime;

		private void Awake()
		{
		}

		private void Ball_OnAimStart()
		{
		}

		private void TryStart()
		{
		}

		private void Ball_OnAimUpdate(Vector3 boost, bool arg2)
		{
		}

		private void Ball_OnPreShoot(Vector3 obj)
		{
		}

		private void Ball_OnCancel()
		{
		}

		private void Update()
		{
		}
	}
}
