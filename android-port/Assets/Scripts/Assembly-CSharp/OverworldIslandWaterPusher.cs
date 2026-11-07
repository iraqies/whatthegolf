using UnityEngine;

public class OverworldIslandWaterPusher : MonoBehaviour
{
	public Transform PushTowards;

	public float PushForce;

	public LayerMask PushLayer;

	private void OnTriggerStay2D(Collider2D other)
	{
	}
}
