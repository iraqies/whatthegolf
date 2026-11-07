using UnityEngine;

public class BubbleSpike : MonoBehaviour
{
	[SerializeField]
	private Transform burstPointTransform;

	[SerializeField]
	private float burstPointCheckRadius;

	[SerializeField]
	private float burstPointAngle;

	[SerializeField]
	private bool failOnBurst;

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
