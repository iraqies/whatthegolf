using UnityEngine;

public class FakePulley : MonoBehaviour
{
	public Vector3 Axis;

	public float Dampen;

	public SpringJoint ThisEnd;

	public SpringJoint OtherEnd;

	public Vector2 ValidSpringRange;

	private void OnCollisionEnter(Collision other)
	{
	}
}
