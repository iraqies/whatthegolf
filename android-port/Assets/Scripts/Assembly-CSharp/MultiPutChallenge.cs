using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class MultiPutChallenge : Challenge
{
	public int ballsToWin;

	public bool dontUsePlayer;

	public GameObject ballDisappearParticles;

	public bool isManualSet;

	public List<GameObject> objectsToPut;

	private GolfBallController[] _controllers;

	private MultiBallFlag _multiBallFlag;

	private ObjectDestroyable _objectDestroyTrigger;

	private int _currentPutCount;

	private int _activeBallCount;

	private TiltChallengeSFX SFX;

	private bool isUnloadingLevel;

	protected override void Activate()
	{
		_multiBallFlag = FindObjectOfType<MultiBallFlag>();
		if (_multiBallFlag != null)
			_multiBallFlag.OnMultiBallHit += OnMultiballFlagHit;

		if (isManualSet)
		{
			if (objectsToPut != null)
			{
				for (int i = 0; i < objectsToPut.Count; i++)
				{
					if (objectsToPut[i] != null)
					{
						var destroyable = objectsToPut[i].AddComponent<ObjectDestroyable>();
						destroyable.OnWillDestroy += OnObjectWillDestroy;
					}
				}
				_activeBallCount = objectsToPut.Count;
			}
		}
		else
		{
			if (objectsToPut == null)
				objectsToPut = new List<GameObject>();
			_controllers = FindObjectsOfType<GolfBallController>();
			if (_controllers != null)
			{
				for (int i = 0; i < _controllers.Length; i++)
				{
					if (_controllers[i] != null)
					{
						objectsToPut.Add(_controllers[i].gameObject);
						var destroyable = _controllers[i].gameObject.AddComponent<ObjectDestroyable>();
						destroyable.OnWillDestroy += OnObjectWillDestroy;
					}
				}
				_activeBallCount = _controllers.Length;
			}
		}

		var multiCam = FindObjectOfType<MultiplePlayerCameraFollow>();
		if (multiCam != null && objectsToPut != null)
		{
			multiCam.objectsToFollow = new List<Transform>();
			for (int i = 0; i < objectsToPut.Count; i++)
			{
				if (objectsToPut[i] != null)
					multiCam.objectsToFollow.Add(objectsToPut[i].transform);
			}
		}

		SFX = GetComponentInChildren<TiltChallengeSFX>();
		if (SFX != null)
			SFX.Init(ballsToWin);

		if (LevelManager.Exists && LevelManager.Instance != null)
		{
			if (LevelManager.Instance.InGameMenu != null)
				LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(ballsToWin, true, true, StrokeCounter.CounterTypes.CardsAppearing, null);
			LevelManager.Instance.OnLevelWillUnload += OnLevelWillUnload;
		}
	}

	private void OnLevelWillUnload()
	{
		isUnloadingLevel = true;
	}

	private void OnObjectWillDestroy(GameObject go)
	{
		if (isUnloadingLevel || objectsToPut == null) return;
		if (objectsToPut.Contains(go))
		{
			objectsToPut.Remove(go);
			if (objectsToPut.Count < ballsToWin - _currentPutCount)
				Fail();
		}
	}

	private void OnDestroy()
	{
		if (_multiBallFlag != null && isManualSet)
			_multiBallFlag.OnMultiBallHit -= OnMultiballFlagHit;
		if (LevelManager.Exists && LevelManager.Instance != null)
			LevelManager.Instance.OnLevelWillUnload -= OnLevelWillUnload;
	}

	private void OnMultiballFlagHit(GameObject go)
	{
		if (objectsToPut == null || !objectsToPut.Contains(go))
			return;
		_currentPutCount++;
		if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(ballsToWin - _currentPutCount, true, true, StrokeCounter.CounterTypes.CardsAppearing, null);
		if (_currentPutCount == ballsToWin)
			Complete();
		if (SFX != null)
			SFX.Play();
		if (ballDisappearParticles != null && go != null)
		{
			var pGo = Instantiate(ballDisappearParticles, go.transform.position, Quaternion.identity);
			var ps = pGo != null ? pGo.GetComponent<ParticleSystem>() : null;
			if (ps != null) ps.Play();
		}
		if (go != null)
			go.SetActive(false);
		objectsToPut.Remove(go);
	}

	public override string GetDescription()
	{
		string key = !string.IsNullOrEmpty(DescriptionLocalizationId) ? DescriptionLocalizationId : "ID_CHALLENGE_DESC_MULTIPUT";
		string fmt = Localization.Instance != null ? Localization.Instance.GetString(key) : key;
		try
		{
			return string.Format(fmt, ballsToWin);
		}
		catch
		{
			return fmt;
		}
	}

	public override string GetWinMessageID()
	{
		return !string.IsNullOrEmpty(WinMessageLocalizationId) ? WinMessageLocalizationId : "ID_WIN_MESSAGE_CHALLENGE";
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
