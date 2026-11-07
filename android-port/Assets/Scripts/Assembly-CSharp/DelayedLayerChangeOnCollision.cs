using System.Collections;
using UnityEngine;

public class DelayedLayerChangeOnCollision : MonoBehaviour
{
	public LayerMask ValidLayers;

	public int NewLayer;

	public float delayInSeconds;

	public Vector3 force;

	private bool collided;

	private void OnCollisionEnter(Collision other)
	{
	}

	private IEnumerator DelayedLayerChange()
	{
		return null;
	}
}
