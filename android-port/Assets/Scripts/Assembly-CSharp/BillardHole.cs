using UnityEngine;

public class BillardHole : MonoBehaviour
{
	public BilliardGolf BilliardParent;

	public bool DestroyBall;

	public bool OnlyPlayerBall;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
