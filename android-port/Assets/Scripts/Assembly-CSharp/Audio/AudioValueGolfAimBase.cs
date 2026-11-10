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
			if (controller != null)
			{
				controller.OnAimStart += OnAimStart;
				controller.OnAimUpdate += OnAimUpdate;
				controller.OnPreShoot += OnAimShoot;
				controller.OnCancel += OnAimCancel;
			}
		}

		private void OnDisable()
		{
			if (controller != null)
			{
				controller.OnAimStart -= OnAimStart;
				controller.OnAimUpdate -= OnAimUpdate;
				controller.OnPreShoot -= OnAimShoot;
				controller.OnCancel -= OnAimCancel;
			}
		}

		private void OnAimStart()
		{
		}

		private void OnAimUpdate(Vector3 boost, bool arg2)
		{
			this.boost = boost;
			SetValue();
			lastBoost = boost;
		}

		private void OnAimShoot(Vector3 boost)
		{
		}

		private void OnAimCancel()
		{
		}
	}
}
