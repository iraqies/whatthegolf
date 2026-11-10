using UnityEngine;

public class RotateAxis2D : MonoBehaviour
{
	public bool UsePhysics;

	public Vector3 Axis;

	public float Speed;

	private Rigidbody2D rigid;

	private Transform t;

	private void Awake()
	{
		rigid = GetComponentInChildren<Rigidbody2D>();
		t = transform;
	}

	private void Update()
	{
		if (UsePhysics)
			return;
		if (t != null)
			t.RotateAround(t.position, Axis, Speed * Time.deltaTime);
	}

	private void FixedUpdate()
	{
		if (UsePhysics && rigid != null && rigid.simulated)
		{
			rigid.MoveRotation(rigid.rotation + Speed * Time.deltaTime);
		}
	}
}
