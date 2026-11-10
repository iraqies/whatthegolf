using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class DistanceEvents : MonoBehaviour
{
	public UnityEvent OnGotClose;

	public float radius;

	public List<Transform> targets;

	public bool addGolfBallControllersToTargets;

	public float updateInterval = 0.1f;

	public float activationDelayMin;

	public float activationDelayMax;

	public bool enableOnStart = true;

	private bool isActivated;

	public void Reset()
	{
		isActivated = false;
		StopAllCoroutines();
		StartCoroutine(CheckDistanceRoutine());
	}

	public void SetDistanceCheckStatus(bool enabled)
	{
		isActivated = false;
		StopAllCoroutines();
		if (enabled)
		{
			StartCoroutine(CheckDistanceRoutine());
		}
	}

	private void Start()
	{
		if (targets == null)
		{
			targets = new List<Transform>();
		}
		if (addGolfBallControllersToTargets)
		{
			GolfBallController[] controllers = Object.FindObjectsOfType<GolfBallController>();
			for (int i = 0; i < controllers.Length; i++)
			{
				if (controllers[i] != null && controllers[i].gameObject.scene == base.gameObject.scene)
				{
					targets.Add(controllers[i].transform);
				}
			}
		}
		if (Level.Instance != null)
		{
			Level.Instance.OnMultiplayerSetup += Instance_OnMultiplayerSetup;
		}
		if (enableOnStart)
		{
			StartCoroutine(CheckDistanceRoutine());
		}
	}

	private void Instance_OnMultiplayerSetup(MultiplayerLevelInfo multiplayerLevel)
	{
		if (Level.Instance != null)
		{
			Level.Instance.OnMultiplayerSetup -= Instance_OnMultiplayerSetup;
			if (Level.Instance.IsMultiplayer && multiplayerLevel != null)
			{
				foreach (GolfBallController ctrl in multiplayerLevel.GetAllControllers())
				{
					if (ctrl != null && targets != null)
					{
						targets.Add(ctrl.transform);
					}
				}
				multiplayerLevel.onPlayerSpawned += HandleNewPlayerSpawned;
				Level.Instance.OnFail += Instance_OnFail;
			}
		}
	}

	private void Instance_OnFail(GolfBallController player, string arg2, Level.State arg3)
	{
		if (player != null && targets != null)
		{
			targets.Remove(player.transform);
		}
	}

	private void HandleNewPlayerSpawned(GolfBallController newPlayer)
	{
		if (newPlayer != null && targets != null && !targets.Contains(newPlayer.transform))
		{
			targets.Add(newPlayer.transform);
		}
	}

	private IEnumerator CheckDistanceRoutine()
	{
		yield return new WaitForSeconds(Mathf.Max(Time.fixedDeltaTime, updateInterval));
		while (!isActivated)
		{
			if (targets != null)
			{
				foreach (Transform target in targets)
				{
					if (target != null && Vector3.Distance(base.transform.position, target.position) < radius)
					{
						yield return new WaitForSeconds(Random.Range(activationDelayMin, activationDelayMax));
						OnGotClose?.Invoke();
						isActivated = true;
						break;
					}
				}
			}
			yield return new WaitForSeconds(Mathf.Max(Time.fixedDeltaTime, updateInterval));
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(base.transform.position, radius);
	}
}
