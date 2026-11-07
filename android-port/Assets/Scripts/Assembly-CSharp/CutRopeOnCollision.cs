using Audio;
using UnityEngine;

public class CutRopeOnCollision : MonoBehaviour
{
	public AudioClipSettings cutSounds;

	public float DisableDurationAfterCut;

	private void Update()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}
}
