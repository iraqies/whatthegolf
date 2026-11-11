using Core;
using UnityEngine;

public class KeepMovingChallenge : Challenge
{
	private Rigidbody _ballRigidbody;

	private GolfBallController _controller;

	private float _failChallengeTimer;

	private bool _challengeStarted;

	private float _levelTimer;

	public float timeToBeat = 20f;

	private int _currentTimeInt;

	public bool beginOnAim;

	public float minVelocity = 0.25f;

	protected override void Activate()
	{
		_controller = Object.FindObjectOfType<GolfBallController>();
		_controller.OnShoot += ControllerOnOnShoot;
		if (beginOnAim)
		{
			_controller.OnAimStart += ControllerOnAimStart;
		}
		_ballRigidbody = _controller.GetComponent<Rigidbody>();
		_failChallengeTimer = 1f;
		_challengeStarted = false;
		LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(Mathf.RoundToInt(timeToBeat), StrokeCounter.CounterTypes.CardsDisappearing, useExternalCountActivator: true);
	}

	private void ControllerOnAimStart()
	{
		_challengeStarted = true;
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
		_challengeStarted = true;
	}

	protected override void ChallengeUpdate()
	{
		if (!_challengeStarted)
		{
			return;
		}
		_levelTimer += Time.deltaTime;
		base.ChallengeUpdate();
		if (_ballRigidbody.velocity.magnitude >= minVelocity)
		{
			_failChallengeTimer = 1f;
		}
		else
		{
			_failChallengeTimer -= Time.deltaTime;
		}
		if (_failChallengeTimer <= 0f)
		{
			Fail();
		}
		if (_levelTimer > timeToBeat + 1f)
		{
			Complete();
		}
		if (_currentTimeInt != Mathf.RoundToInt(timeToBeat - _levelTimer))
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(_currentTimeInt, StrokeCounter.CounterTypes.CardsDisappearing, useExternalCountActivator: true);
		}
		_currentTimeInt = Mathf.RoundToInt(timeToBeat - _levelTimer);
	}

	public override string GetDescription()
	{
		if (string.IsNullOrEmpty(DescriptionLocalizationId))
		{
			return string.Format(Localization.Instance.GetString("ID_CHALLENGE_KEEPMOVING"), timeToBeat);
		}
		return string.Format(Localization.Instance.GetString(DescriptionLocalizationId), timeToBeat);
	}

	public override string GetWinMessageID()
	{
		return string.IsNullOrEmpty(WinMessageLocalizationId) ? "ID_CHALLENGE_KEEPMOVING_COMPLETION" : WinMessageLocalizationId;
	}
}
