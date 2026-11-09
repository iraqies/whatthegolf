using Core;
using Menu;
using UnityEngine;

public class ShortcutTunnelTraversable : MonoBehaviour
{
	public bool isTraveling;
	public bool isDebug;
	public bool EndTravelOnDisable = true;
	public float nextTravelTime;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (Time.time <= nextTravelTime || isTraveling || collision == null)
			return;
		var entry = collision.gameObject.GetComponent<ShortcutTunnelEntry>();
		if (entry != null && !entry.isBlocked && !entry.isOnlyForExit)
		{
			entry.EnterTunnel(this);
		}
	}

	public void StartTravel()
	{
		isTraveling = true;
		var rb = GetComponent<Rigidbody2D>();
		if (rb != null)
		{
			rb.isKinematic = true;
			rb.simulated = false;
			rb.angularVelocity = 0f;
		}
		var col = GetComponent<Collider2D>();
		if (col != null)
			col.enabled = false;
		var ctrl = GetComponent<GolfBallController>();
		if (ctrl != null)
			ctrl.enabled = false;
	}

	public void EndTravel(Vector3 dir, float speed)
	{
		isTraveling = false;
		var rb = GetComponent<Rigidbody2D>();
		if (rb != null)
		{
			rb.isKinematic = false;
			rb.simulated = true;
			rb.velocity = new Vector2(dir.x, dir.y) * (15f * speed);
			rb.angularVelocity = 40f;
		}
		if (Menu.Menu.Exists && Menu.Menu.Instance != null && Menu.Menu.Instance.IsOpen())
			return;
		var col = GetComponent<Collider2D>();
		if (col != null)
			col.enabled = true;
		var ctrl = GetComponent<GolfBallController>();
		if (ctrl != null)
			ctrl.enabled = true;
	}

	private void OnDisable()
	{
		if (EndTravelOnDisable && isTraveling)
			EndTravel(Vector3.zero, 0f);
	}
}
