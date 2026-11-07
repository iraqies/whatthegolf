using UnityEngine;
using UnityEngine.Events;

public class TeleportHole : MonoBehaviour
{
	public TeleportHole teleportConnection;

	[SerializeField]
	private Vector3 UpModifier;

	[SerializeField]
	private float force;

	[SerializeField]
	private UnityEvent _onTeleportedToHere;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
