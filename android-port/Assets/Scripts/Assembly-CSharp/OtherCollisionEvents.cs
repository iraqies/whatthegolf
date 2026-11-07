using UnityEngine;

public class OtherCollisionEvents : MonoBehaviour
{
	public InspectorColliderEvent TriggerEnter;

	public InspectorColliderEvent TriggerStay;

	public InspectorColliderEvent TriggerExit;

	public InspectorCollisionEvent CollisionEnter;

	public InspectorCollisionEvent CollisionStay;

	public InspectorCollisionEvent CollisionExit;

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionStay(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
