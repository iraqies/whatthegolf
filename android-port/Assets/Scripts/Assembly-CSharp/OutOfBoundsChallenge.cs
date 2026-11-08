using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class OutOfBoundsChallenge : Challenge
{
	public bool useCustomAmount;

	public int customAmount;

	public List<GameObject> ObjectsToObserve;

	private TiltChallengeSFX sfx;

	private CBFollow _cbFollow;

	private GolfBallController _golfBallController;

	private int knockoutCount;

	private int count;

	protected override void Activate()
	{
		if (ObjectsToObserve != null)
		{
			foreach (GameObject go in ObjectsToObserve)
			{
				if (go == null) continue;
				OutOfBoundsTrigger trig = go.AddComponent<OutOfBoundsTrigger>();
				trig.OnOutOfBounds += OnOnOutOfBounds;
			}
		}
		sfx = GetComponentInParent<TiltChallengeSFX>();
		if (sfx != null && ObjectsToObserve != null)
			sfx.Init(ObjectsToObserve.Count);
		_golfBallController = FindObjectOfType<GolfBallController>();
		if (CameraManager.Instance != null)
		{
			_cbFollow = CameraManager.Instance.GetComponentInChildren<CBFollow>();
			if (_cbFollow != null && _golfBallController != null)
				_cbFollow.FollowTarget = _golfBallController.transform;
		}
		count = useCustomAmount ? customAmount : (ObjectsToObserve != null ? ObjectsToObserve.Count : 0);
		if (LevelManager.Exists && LevelManager.Instance.InGameMenu != null)
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(count, (StrokeCounter.CounterTypes)1, true, 0);
	}

	private void OnOnOutOfBounds(OutOfBoundsTrigger outOfBoundsTrigger)
	{
		if (outOfBoundsTrigger == null || ObjectsToObserve == null) return;
		if (!ObjectsToObserve.Contains(outOfBoundsTrigger.gameObject)) return;
		if (sfx != null)
			sfx.Play();
		knockoutCount++;
		ObjectsToObserve.Remove(outOfBoundsTrigger.gameObject);
		if (LevelManager.Exists && LevelManager.Instance.InGameMenu != null)
			LevelManager.Instance.InGameMenu.CountStroke(_golfBallController, knockoutCount);
		if (count - knockoutCount <= 0)
			Complete();
	}
}
