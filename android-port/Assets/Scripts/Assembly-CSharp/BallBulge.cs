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
			var sr = ballBulge.GetComponentInChildren<SpriteRenderer>(true);
			if (sr != null && sr.drawMode != SpriteDrawMode.Simple)
			{
				Vector2 targetSize = sr.size;
				sr.drawMode = SpriteDrawMode.Simple;
				float spriteWorldSize = (sr.sprite != null && sr.sprite.pixelsPerUnit > 0f && sr.sprite.rect.width > 0f)
					? (sr.sprite.rect.width / sr.sprite.pixelsPerUnit)
					: 0.5f;
				float factor = spriteWorldSize > 0.001f ? (targetSize.x / spriteWorldSize) : 20f;
				Vector3 ls = sr.transform.localScale;
				sr.transform.localScale = new Vector3(ls.x * factor, ls.y * factor, 1f);
			}
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
