using UnityEngine;
using UnityEngine.Events;

public class FollowTranformWithTag : MonoBehaviour
{
	[SerializeField]
	private string followTag;

	[SerializeField]
	private UnityEvent OnFollowDestroyed;

	[SerializeField]
	private UnityEvent OnFollowFound;

	private Transform follow;

	private bool hasFollow;

	private void FixedUpdate()
	{
	}
}
