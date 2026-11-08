using UnityEngine;

public class OtherCollisionEvents : MonoBehaviour
{
	public InspectorColliderEvent TriggerEnter;

	public InspectorColliderEvent TriggerStay;

	public InspectorColliderEvent TriggerExit;

	public InspectorCollisionEvent CollisionEnter;

	public InspectorCollisionEvent CollisionStay;

	public InspectorCollisionEvent CollisionExit;

	private void OnCollisionEnter(Collision collision) => CollisionEnter?.Invoke(collision);

	private void OnCollisionStay(Collision collision) => CollisionStay?.Invoke(collision);

	private void OnCollisionExit(Collision collision) => CollisionExit?.Invoke(collision);

	private void OnTriggerEnter(Collider other) => TriggerEnter?.Invoke(other);

	private void OnTriggerStay(Collider other) => TriggerStay?.Invoke(other);

	private void OnTriggerExit(Collider other) => TriggerExit?.Invoke(other);
}
