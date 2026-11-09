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
			pullSimple = GetComponentInChildren<GolfPullSimple>();
		}

		public void Initialize(GolfBallController _ball)
		{
			if (_ball == null) return;
			if (pullSimple == null)
				pullSimple = GetComponentInChildren<GolfPullSimple>();
			ball = _ball;
			ball.OnAimUpdate -= OnAim;
			ball.OnAimUpdate += OnAim;
			ball.OnAimStart -= OnAimStart;
			ball.OnAimStart += OnAimStart;
			ball.OnPreShoot -= OnShoot;
			ball.OnPreShoot += OnShoot;
			ball.OnCancel -= OnCancel;
			ball.OnCancel += OnCancel;
			ball.OnShootWhileBlocked -= OnShoot;
			ball.OnShootWhileBlocked += OnShoot;
			if (pullSimple != null)
				pullSimple.ball = ball;
		}

		public void Deinitialize()
		{
			if (ball != null)
			{
				ball.OnAimUpdate -= OnAim;
				ball.OnAimStart -= OnAimStart;
				ball.OnPreShoot -= OnShoot;
				ball.OnCancel -= OnCancel;
				ball.OnShootWhileBlocked -= OnShoot;
				ball = null;
			}
		}

		public void OnCancel()
		{
			OnShoot(Vector3.zero);
		}

		private void OnAimStart()
		{
			if (pullSimple != null && pullSimple.isActiveAndEnabled)
				pullSimple.Ball_OnAimStart();
		}

		private void OnAim(Vector3 boost, bool cancel)
		{
			if (pullSimple != null)
				pullSimple.Ball_OnAimUpdate(boost, cancel);
		}

		private void OnShoot(Vector3 boost)
		{
			if (pullSimple != null)
				pullSimple.Ball_OnPreShoot(boost);
		}

		private void Update()
		{
			if (ball == null) return;
			if (pullSimple != null && pullSimple.source != null && pullSimple.source.isPlaying && !ball.isActiveAndEnabled)
			{
				pullSimple.Stop();
			}
			if (!ball.IsAiming && aiming && pullSimple != null && pullSimple.isActiveAndEnabled)
			{
				pullSimple.StopAim();
			}
			aiming = ball.IsAiming;
		}
	}
}
