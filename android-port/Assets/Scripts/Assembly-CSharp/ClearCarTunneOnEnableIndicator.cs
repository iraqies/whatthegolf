using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCarTunneOnEnableIndicator : MonoBehaviour
{
	public OverworldMainDoorPlate plate;

	public List<ExplosionBarrel2D> barrels;

	public List<GameObject> DisableObjectsOnExplosion;

	public List<GameObject> EnableObjectsOnExplosion;

	private bool isKeepingBall;

	private IEnumerator Start()
	{
		while (plate != null && !plate.IsInitialized)
			yield return null;

		if (plate == null)
			yield break;

		if (plate.isOn)
		{
			SetObjectStates();
		}
		else
		{
			plate.OnStateChange -= Plate_OnStateChange;
			plate.OnStateChange += Plate_OnStateChange;
		}
	}

	private void SetObjectStates()
	{
		if (DisableObjectsOnExplosion != null)
		{
			foreach (GameObject go in DisableObjectsOnExplosion)
			{
				if (go != null)
					go.SetActive(false);
			}
		}
		if (EnableObjectsOnExplosion != null)
		{
			foreach (GameObject go in EnableObjectsOnExplosion)
			{
				if (go != null)
					go.SetActive(true);
			}
		}
	}

	private void Plate_OnStateChange(bool state, bool onLoad)
	{
		if (onLoad)
		{
			if (state)
				SetObjectStates();
			return;
		}
		if (state)
		{
			StartCoroutine(ExplodeRoutine());
		}
	}

	private IEnumerator ExplodeRoutine()
	{
		isKeepingBall = true;
		OverworldBall2D ball = OverworldBallManager.HasInstance && OverworldBallManager.Instance != null ? OverworldBallManager.Instance.Ball : null;
		Vector3 pos = ball != null ? ball.transform.position : transform.position;
		StartCoroutine(KeepBall(pos));

		yield return new WaitForSeconds(0.5f);

		if (barrels != null)
		{
			foreach (ExplosionBarrel2D barrel in barrels)
			{
				if (barrel != null)
				{
					barrel.Explode();
					yield return new WaitForSeconds(0.1f);
				}
			}
		}

		yield return new WaitForSeconds(0.1f);
		SetObjectStates();
		yield return new WaitForSeconds(1f);
		isKeepingBall = false;
	}

	private IEnumerator KeepBall(Vector3 pos)
	{
		while (isKeepingBall)
		{
			if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
			{
				OverworldBallManager.Instance.Ball.transform.position = pos;
			}
			yield return null;
		}
	}
}
