using UnityEngine;

public class OverworldRTPCZone : MonoBehaviour
{
	public uint RTPC;

	public float ValueOnEnter;

	public float ValueOnExit;

	public float timeToSet;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision != null && collision.GetComponentInParent<OverworldBall2D>() != null && AudioManager.Instance != null && AudioManager.Instance.music != null)
		{
			AudioManager.Instance.music.setRTCPRaw(RTPC, ValueOnEnter, Mathf.RoundToInt(timeToSet * 1000f));
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision != null && collision.GetComponentInParent<OverworldBall2D>() != null && AudioManager.Instance != null && AudioManager.Instance.music != null)
		{
			AudioManager.Instance.music.setRTCPRaw(RTPC, ValueOnExit, Mathf.RoundToInt(timeToSet * 1000f));
		}
	}
}
