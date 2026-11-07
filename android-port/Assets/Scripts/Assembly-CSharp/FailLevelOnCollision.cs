using UnityEngine;

public class FailLevelOnCollision : MonoBehaviour
{
	public LayerMask FailLayerMask;

	public float Delay;

	private void OnCollisionEnter(Collision other)
	{
	}
}
