using UnityEngine;

public class ArcheryDummy : MonoBehaviour
{
	public int breakJointCount = 40;

	public float breakDistance = 5f;

	private Joint2D joint;

	private int count;

	private bool didBreak;

	private Vector3 basePos;

	public float breakMass = 50f;

	public float breakDrag = 5f;

	public bool breakOnAngle;

	private void OnEnable()
	{
		basePos = base.transform.position;
		joint = GetComponent<Joint2D>();
	}

	private void Update()
	{
		if (breakOnAngle && Vector3.Angle(base.transform.up, Vector3.up) > 70f)
		{
			BreakJoint();
		}
		if (Vector3.Distance(basePos, base.transform.position) > breakDistance)
		{
			BreakJoint();
		}
	}

	private void BreakJoint()
	{
		if (!didBreak)
		{
			Rigidbody2D component = GetComponent<Rigidbody2D>();
			component.mass = breakMass;
			component.gravityScale = 2f;
			component.drag = breakDrag;
			component.angularDrag = 4f;
			didBreak = true;
			Object.Destroy(joint);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.attachedRigidbody.gameObject.GetComponent<Arrow2D>() != null)
		{
			count++;
			if (count > breakJointCount)
			{
				BreakJoint();
			}
		}
	}
}
