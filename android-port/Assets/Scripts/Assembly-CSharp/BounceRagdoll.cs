using UnityEngine;
using UnityEngine.Events;

public class BounceRagdoll : MonoBehaviour
{
	[SerializeField]
	private float bouncePower;

	private Transform lastObject;

	[SerializeField]
	private UnityEvent onRagdollHit;

	private void OnCollisionEnter(Collision collision)
	{
	}
}
