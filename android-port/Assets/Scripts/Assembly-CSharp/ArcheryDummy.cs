using UnityEngine;

public class ArcheryDummy : MonoBehaviour
{
	public int breakJointCount;

	public float breakDistance;

	private Joint2D joint;

	private int count;

	private bool didBreak;

	private Vector3 basePos;

	public float breakMass;

	public float breakDrag;

	public bool breakOnAngle;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void BreakJoint()
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}
}
