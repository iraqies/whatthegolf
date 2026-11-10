using Core;
using UnityEngine;

public class MaxPowerChallenge : Challenge
{
	private GolfBallController _controller;

	protected override void Activate()
	{
		_controller = FindObjectOfType<GolfBallController>();
		if (_controller != null)
			_controller.OnShoot += ControllerOnOnShoot;
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		Complete();
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
		if (obj.magnitude < 0.95f)
			Fail();
	}

	public override string GetDescription()
	{
		string key = !string.IsNullOrEmpty(DescriptionLocalizationId) ? DescriptionLocalizationId : "ID_CHALLENGE_DESC_MAX_POWER";
		return Localization.Instance != null ? Localization.Instance.GetString(key) : key;
	}

	public override string GetWinMessageID()
	{
		return !string.IsNullOrEmpty(WinMessageLocalizationId) ? WinMessageLocalizationId : "ID_WIN_MESSAGE_CHALLENGE";
	}
}
