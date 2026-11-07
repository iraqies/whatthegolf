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
	}

	protected override void Start()
	{
	}

	private void Update()
	{
	}

	protected override void OnDisable()
	{
	}
}
