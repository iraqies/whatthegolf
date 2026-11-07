using UnityEngine;

public class ShortcutTunnelTraversable : MonoBehaviour
{
	public bool isTraveling;

	public bool isDebug;

	public bool EndTravelOnDisable;

	public float nextTravelTime;

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	public void StartTravel()
	{
	}

	public void EndTravel(Vector3 dir, float speed)
	{
	}

	private void OnDisable()
	{
	}
}
