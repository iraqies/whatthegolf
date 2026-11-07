using UnityEngine;

public class PushBoat : MonoBehaviour
{
	public Vector3 PushForce;

	public SHMUPController Boat;

	public SHMUPFrogKing Frog;

	private Rigidbody rigid;

	private Vector3 basePos;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
