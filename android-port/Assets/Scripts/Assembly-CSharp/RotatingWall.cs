using UnityEngine;

public class RotatingWall : MonoBehaviour
{
	public float rotationSpeed = 5f;

	public float angleOffset;

	private Rigidbody2D rigid;

	private void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
		if (rigid != null)
			rigid.MoveRotation(angleOffset);
	}

	private void Update()
	{
		if (rigid != null)
			rigid.angularVelocity = rotationSpeed;
	}
}
