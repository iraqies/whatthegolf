using UnityEngine;

public class SetMaxAngularVelocity2D : MonoBehaviour
{
	[SerializeField]
	private float maxAngularVelocity;

	[SerializeField]
	private bool includeChildren;

	private Rigidbody2D[] bodies;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
