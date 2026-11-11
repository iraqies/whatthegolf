using System.Collections;
using UnityEngine;

public class BallBulge : MonoBehaviour
{
	public Transform ballBulge;

	public float bulgeDelayInSeconds;

	private ShortcutTunnelTraversable shortCutUser;

	private void Start()
	{
		if (ballBulge != null)
		{
			ballBulge.gameObject.SetActive(false);
		}
		ShortcutTunnel tunnel = GetComponent<ShortcutTunnel>() ?? GetComponentInParent<ShortcutTunnel>();
		if (tunnel != null)
		{
			tunnel.OnBallEnterTunnel -= StartTravelling;
			tunnel.OnBallEnterTunnel += StartTravelling;
			tunnel.OnBallExitTunnel -= EndTraveling;
			tunnel.OnBallExitTunnel += EndTraveling;
			tunnel.OnMovementUpdate -= MovementUpdate;
			tunnel.OnMovementUpdate += MovementUpdate;
		}
	}

	private void MovementUpdate(float timeRemaining)
	{
		if (shortCutUser == null && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			shortCutUser = OverworldBallManager.Instance.Ball.GetComponent<ShortcutTunnelTraversable>();
		}
		if (shortCutUser != null && ballBulge != null)
		{
			Vector3 pos = shortCutUser.transform.position;
			ballBulge.position = new Vector3(pos.x, pos.y, ballBulge.position.z);
			if (timeRemaining < bulgeDelayInSeconds)
			{
				ballBulge.gameObject.SetActive(false);
			}
		}
	}

	private void StartTravelling(ShortcutTunnel t = null)
	{
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			shortCutUser = OverworldBallManager.Instance.Ball.GetComponent<ShortcutTunnelTraversable>();
		}
		if (gameObject.activeInHierarchy)
		{
			StartCoroutine(StartTravellingRoutine());
		}
		else if (ballBulge != null)
		{
			ballBulge.gameObject.SetActive(true);
		}
	}

	private IEnumerator StartTravellingRoutine()
	{
		if (bulgeDelayInSeconds > 0f)
		{
			yield return new WaitForSecondsRealtime(bulgeDelayInSeconds);
		}
		if (ballBulge != null)
		{
			if (shortCutUser != null)
			{
				Vector3 pos = shortCutUser.transform.position;
				ballBulge.position = new Vector3(pos.x, pos.y, ballBulge.position.z);
			}
			ballBulge.gameObject.SetActive(true);
		}
	}

	public void EndTraveling(ShortcutTunnel t = null)
	{
		if (ballBulge != null)
		{
			ballBulge.gameObject.SetActive(false);
		}
	}
}
