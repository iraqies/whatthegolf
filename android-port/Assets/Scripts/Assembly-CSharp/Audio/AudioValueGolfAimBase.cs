using Core;
using UnityEngine;

namespace Audio
{
	public abstract class AudioValueGolfAimBase : BaseAudioValue
	{
		[SerializeField]
		protected GolfBallController controller;

		protected Vector3 boost;

		protected Vector3 lastBoost;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnAimStart()
		{
		}

		private void OnAimUpdate(Vector3 boost, bool arg2)
		{
		}

		private void OnAimShoot(Vector3 boost)
		{
		}

		private void OnAimCancel()
		{
		}
	}
}
