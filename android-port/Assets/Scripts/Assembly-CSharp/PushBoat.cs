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
		rigid = GetComponent<Rigidbody>();
		basePos = transform.position;
	}

	private void FixedUpdate()
	{
		if (Frog != null && Frog.IsAlive && Boat != null && rigid != null)
		{
			Vector3 boatPos = Boat.transform.position;
			rigid.MovePosition(new Vector3(basePos.x, basePos.y, boatPos.z));
		}
	}
}
