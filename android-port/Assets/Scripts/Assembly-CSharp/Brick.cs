using UnityEngine;

public class Brick : MonoBehaviour
{
	public AudioClip sfxBreak;

	private Collider2D col;

	private bool isSolid;

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
