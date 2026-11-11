using UnityEngine;

public class Portal3D : MonoBehaviour
{
	[SerializeField]
	private Portal3D ConnectedPortal;

	public Animation PortalAnimation;

	private bool used;

	private readonly float cooldown = 1f;

	private float cooldownTimer = 1f;

	private void OnTriggerEnter(Collider collision)
	{
		if (used || collision == null || collision.gameObject == null)
		{
			return;
		}
		PortableObject portable = collision.gameObject.GetComponent<PortableObject>();
		if (portable != null && ConnectedPortal != null)
		{
			portable.Port(ConnectedPortal.transform.position);
			if (PortalAnimation != null)
			{
				PortalAnimation.Play();
			}
			ConnectedPortal.used = true;
			used = true;
		}
	}

	private void OnTriggerStay(Collider other)
	{
		used = true;
		cooldownTimer = 0f;
	}

	private void Update()
	{
		if (used)
		{
			cooldownTimer += Time.deltaTime;
			if (cooldownTimer > cooldown)
			{
				used = false;
				cooldownTimer = 0f;
			}
		}
	}

	private void OnDrawGizmos()
	{
		if (ConnectedPortal != null)
		{
			Gizmos.DrawLine(transform.position, ConnectedPortal.transform.position);
		}
	}
}
