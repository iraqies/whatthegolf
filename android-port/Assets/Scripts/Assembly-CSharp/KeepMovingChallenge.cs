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
		if (_controller != null)
		{
			_controller.OnShoot += ControllerOnOnShoot;
			if (beginOnAim)
			{
				_controller.OnAimStart += ControllerOnAimStart;
			}
			_ballRigidbody = _controller.GetComponent<Rigidbody>();
		}
		_failChallengeTimer = 1f;
		_challengeStarted = false;
		if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(Mathf.RoundToInt(timeToBeat), true, true, false);
		}
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
		if (_ballRigidbody != null)
		{
			if (_ballRigidbody.velocity.magnitude >= minVelocity)
			{
				_failChallengeTimer = 1f;
			}
			else
			{
				_failChallengeTimer -= Time.deltaTime;
			}
		}
		if (_failChallengeTimer <= 0f)
		{
			Fail();
		}
		if (_levelTimer > timeToBeat + 1f)
		{
			Complete();
		}
		int remaining = Mathf.RoundToInt(timeToBeat - _levelTimer);
		if (_currentTimeInt != remaining)
		{
			if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			{
				LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(_currentTimeInt, true, true, false);
			}
		}
		_currentTimeInt = remaining;
	}

	public override string GetDescription()
	{
		string key = string.IsNullOrEmpty(DescriptionLocalizationID) ? "ID_CHALLENGE_KEEPMOVING" : DescriptionLocalizationID;
		if (Localization.Instance != null)
		{
			return string.Format(Localization.Instance.GetString(key), timeToBeat);
		}
		return string.Format(key, timeToBeat);
	}

	public override string GetWinMessageID()
	{
		return string.IsNullOrEmpty(CustomWinMessageLocalizationID) ? "ID_CHALLENGE_KEEPMOVING_COMPLETION" : CustomWinMessageLocalizationID;
	}
}
