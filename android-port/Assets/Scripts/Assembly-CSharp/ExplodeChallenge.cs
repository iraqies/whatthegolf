using System;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class ExplodeChallenge : Challenge
{
	public FlyingExplosionShooter flyingExplosionShooterPrefab;

	public Transform spawnPoint;

	private FlyingExplosionShooter _currentFlyingExplosion;

	private CBFollow _cbFollow;

	public int destructionToWin = 10;

	private int _destructionCount;

	public List<GameObject> objectsToDestroy = new List<GameObject>();

	public float explosionPower = 2500f;

	protected override void Activate()
	{
		foreach (GameObject item in objectsToDestroy)
		{
			item.AddComponent<OutOfBoundsTrigger>().OnOutOfBounds += OnOnOutOfBounds;
		}
		SpawnNewBarrel();
		if (CustomCameraBehaviour != null && CustomCameraBehaviour is ICameraBehaviourFollowing cameraBehaviourFollowing)
		{
			cameraBehaviourFollowing.SetFollowTarget(_currentFlyingExplosion.transform);
		}
		if (CustomDesktopOverrideBehaviour != null && CustomDesktopOverrideBehaviour is ICameraBehaviourFollowing cameraBehaviourFollowing2)
		{
			cameraBehaviourFollowing2.SetFollowTarget(_currentFlyingExplosion.transform);
		}
		if (CameraManager.Instance.CurrentBehaviour is ICameraBehaviourFollowing cameraBehaviourFollowing3)
		{
			cameraBehaviourFollowing3.SetFollowTarget(_currentFlyingExplosion.transform);
		}
		AddressableSingleton<LevelManager>.Instance.InGameMenu.SetStrokeCounterSettings(destructionToWin, StrokeCounter.CounterTypes.ReverseCounting, true);
	}

	private void OnOnOutOfBounds(OutOfBoundsTrigger obj)
	{
		UnityEngine.Object.Destroy(obj.gameObject);
		_destructionCount++;
		AddressableSingleton<LevelManager>.Instance.InGameMenu.CountStroke(_destructionCount);
		if (_destructionCount >= destructionToWin)
		{
			Complete();
		}
	}

	private void SpawnNewBarrel()
	{
		_currentFlyingExplosion = UnityEngine.Object.Instantiate(flyingExplosionShooterPrefab, spawnPoint.position, spawnPoint.rotation);
		FlyingExplosionShooter currentFlyingExplosion = _currentFlyingExplosion;
		currentFlyingExplosion.onExplode = (Action<GameObject>)Delegate.Combine(currentFlyingExplosion.onExplode, new Action<GameObject>(OnExplode));
		_currentFlyingExplosion.failLevelOnExplode = false;
		_currentFlyingExplosion.GetComponent<ExplosionBarrel>().power = explosionPower;
		if (CameraManager.Instance.CurrentBehaviour is ICameraBehaviourFollowing cameraBehaviourFollowing)
		{
			cameraBehaviourFollowing.SetFollowTarget(_currentFlyingExplosion.transform);
		}
	}

	private void OnExplode(GameObject explodeObject)
	{
		if (objectsToDestroy.Contains(explodeObject))
		{
			_currentFlyingExplosion.GetComponent<Rigidbody>().useGravity = true;
			UnityEngine.Object.Destroy(_currentFlyingExplosion);
			SpawnNewBarrel();
		}
		else
		{
			Fail();
		}
	}
}
