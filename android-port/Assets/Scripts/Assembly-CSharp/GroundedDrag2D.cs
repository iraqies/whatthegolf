using UnityEngine;

public class GroundedDrag2D : MonoBehaviour
{
	public float GroundedDrag;

	public float InAirDrag;

	public LayerMask GroundLayers;

	private Rigidbody2D rigid;

	private void Awake()
	{
	}

	private void OnCollisionStay2D(Collision2D col)
	{
	}

	private void OnCollisionExit2D(Collision2D col)
	{
	}
}
