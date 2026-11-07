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

	public bool ExitLevelOnComplete;

	public bool SetCameraTarget;

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
	}

	public virtual string GetDescription()
	{
		return null;
	}

	public virtual string GetWinMessageID()
	{
		return null;
	}

	public void Activate(Action<Challenge> onComplete, Action<Challenge> onFailed)
	{
	}

	public virtual void OnLevelFail(GolfBallController arg1, string arg2, Level.State arg3)
	{
	}

	public void FailAfterTime(float time)
	{
	}

	protected abstract void Activate();

	private void Update()
	{
	}

	protected virtual void ChallengeUpdate()
	{
	}

	public void Complete(float delay)
	{
	}

	public void Complete()
	{
	}

	public virtual void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	public void Fail()
	{
	}

	public virtual void OnFail()
	{
	}
}
