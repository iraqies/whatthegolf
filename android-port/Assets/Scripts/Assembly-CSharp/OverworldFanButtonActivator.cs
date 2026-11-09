using UnityEngine;

public class OverworldFanButtonActivator : MonoBehaviour
{
	public float brakeOnButton = 0.5f;

	public bool isOnButton;

	private Rigidbody2D rigid;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		if (!isOnButton)
			return;
		if (rigid != null)
			rigid.velocity *= brakeOnButton;
		var hj = GetComponent<HingeJoint2D>();
		if (hj != null)
			Destroy(hj);
	}
}
