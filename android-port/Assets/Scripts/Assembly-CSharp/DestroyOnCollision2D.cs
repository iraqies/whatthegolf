using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision2D : MonoBehaviour
{
	public LayerMask DestroyLayers;

	public List<AudioClip> DestroyClips;

	public float Volume;

	private void OnCollisionEnter2D(Collision2D other)
	{
	}
}
