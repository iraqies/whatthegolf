using UnityEngine;

public class Portal3D : MonoBehaviour
{
	[SerializeField]
	private Portal3D ConnectedPortal;

	public Animation PortalAnimation;

	private bool used;

	private readonly float cooldown;

	private float cooldownTimer;

	private void OnTriggerEnter(Collider collision)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
