using UnityEngine;
using VFX;

public class StraightLineProjector2D : TrajectoryProjector
{
	[SerializeField]
	private LineRenderer line;

	[SerializeField]
	private LayerMask layers;

	protected override void Awake()
	{
		line = GetComponent<LineRenderer>();
	}

	protected override void Start()
	{
	}

	private void Update()
	{
		if (line == null)
		{
			return;
		}
		Vector2 origin = base.transform.position;
		Vector2 direction = -base.transform.right;
		RaycastHit2D raycastHit2D = Physics2D.Raycast(origin, direction, float.PositiveInfinity, layers);
		if (raycastHit2D.collider != null)
		{
			line.positionCount = 2;
			line.SetPosition(0, base.transform.position);
			line.SetPosition(1, new Vector3(raycastHit2D.point.x, raycastHit2D.point.y, 0f));
		}
		else
		{
			line.positionCount = 2;
			line.SetPosition(0, base.transform.position);
			line.SetPosition(1, base.transform.position + base.transform.forward * 1000f);
		}
	}

	protected override void OnDisable()
	{
		if (line != null)
		{
			line.positionCount = 0;
		}
	}
}
