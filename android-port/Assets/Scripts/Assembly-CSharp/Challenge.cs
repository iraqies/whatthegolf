using System;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.Events;

public abstract class Challenge : MonoBehaviour
{
	[Serializable]
	public struct ChallengeUnityEvents
	{
		public UnityEvent OnChallengeActivated;

		public UnityEvent OnChallengeStart;

		public UnityEvent OnChallengeComplete;
	}

	public string ID;

	public string TitleLocalizationId;

	public string DescriptionLocalizationId;

	public ChallengeInfoIconSet IconDescription;

	public string WinMessageLocalizationId;

	public ChallengeUnityEvents UnityEvents;

	public bool ExitLevelOnComplete = true;

	public bool SetCameraTarget = true;

	public Sprite Icon;

	private Action<Challenge> onComplete;

	private Action<Challenge> onFailed;

	private bool hasBeenCompleted;

	public GameObject[] objectsToDeActivate;

	public CameraManager cameraManager;

	public CameraBehavior CustomCameraBehaviour;

	public CameraBehavior CustomDesktopOverrideBehaviour;

	public bool hasBeenActivated { get; private set; }

	public virtual void Disable()
	{
		if (gameObject != null)
			gameObject.SetActive(false);
	}

	public virtual string GetDescription()
	{
		string locId = !string.IsNullOrEmpty(DescriptionLocalizationId) ? DescriptionLocalizationId : TitleLocalizationId;
		if (string.IsNullOrEmpty(locId)) return string.Empty;
		if (Localization.Instance != null)
			return Localization.Instance.GetString(locId);
		return locId;
	}

	public virtual string GetWinMessageID()
	{
		return !string.IsNullOrEmpty(WinMessageLocalizationId) ? WinMessageLocalizationId : "ID_WIN_MESSAGE_CHALLENGE";
	}

	public void Activate(Action<Challenge> onComplete, Action<Challenge> onFailed)
	{
		this.onComplete = onComplete;
		this.onFailed = onFailed;

		SetChallengeCameraFollow camFollow = GetComponent<SetChallengeCameraFollow>();
		if (camFollow != null)
			camFollow.SetTargetOnAllBehaviours();

		if (Level.HasInstance && Level.Instance != null)
		{
			Level.Instance.OnComplete += OnLevelComplete;
			Level.Instance.OnFail += OnLevelFail;
		}

		if (objectsToDeActivate != null)
		{
			for (int i = 0; i < objectsToDeActivate.Length; i++)
			{
				if (objectsToDeActivate[i] != null)
					objectsToDeActivate[i].SetActive(false);
			}
		}

		if (gameObject != null)
			gameObject.SetActive(true);

		foreach (Transform child in transform)
		{
			if (child != null && child.gameObject != null)
				child.gameObject.SetActive(true);
		}

		if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			bool useIcons = PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().useChallengeIconDescriptions && IconDescription != null && IconDescription.Icons != null && IconDescription.Icons.Length > 0 && IconDescription.Icons[0] != null;
			if (useIcons)
				LevelManager.Instance.InGameMenu.ShowChallengeInfo(GetDescription(), IconDescription.Icons);
			else
				LevelManager.Instance.InGameMenu.ShowChallengeInfo(GetDescription());
		}

		var initComponents = GetComponentsInChildren<ChallengeInitializeBase>(true);
		if (initComponents != null)
		{
			for (int i = 0; i < initComponents.Length; i++)
			{
				if (initComponents[i] != null)
					initComponents[i].InitOnActivate();
			}
		}

		Activate();
		UnityEvents.OnChallengeActivated?.Invoke();
		hasBeenActivated = true;
	}

	public virtual void OnLevelFail(GolfBallController arg1, string arg2, Level.State arg3)
	{
		OnFail();
		if (!hasBeenCompleted && onFailed != null)
		{
			hasBeenCompleted = true;
			onFailed.Invoke(this);
		}
	}

	public void FailAfterTime(float time)
	{
		StartCoroutine(pTween.To(time, _ => { }).Then(Fail));
	}

	protected abstract void Activate();

	private void Update()
	{
		if (hasBeenActivated)
			ChallengeUpdate();
	}

	protected virtual void ChallengeUpdate()
	{
	}

	public void Complete(float delay)
	{
		UnityEvents.OnChallengeComplete?.Invoke();
		Invoke(nameof(Complete), delay);
	}

	public void Complete()
	{
		if (!hasBeenCompleted)
		{
			if (onComplete != null)
			{
				hasBeenCompleted = true;
				onComplete.Invoke(this);
			}
			FlagAudioForChallenges flagAudio = transform.GetComponentInChildren<FlagAudioForChallenges>();
			if (flagAudio != null)
				flagAudio.PlayFlagAudio();
		}
	}

	public virtual void OnLevelComplete(Level.CompletedState completedState)
	{
		OnFail();
		if (!hasBeenCompleted && onFailed != null)
		{
			hasBeenCompleted = true;
			onFailed.Invoke(this);
		}
	}

	public void Fail()
	{
		OnFail();
		if (!hasBeenCompleted && onFailed != null)
		{
			hasBeenCompleted = true;
			onFailed.Invoke(this);
		}
	}

	public virtual void OnFail()
	{
	}
}
