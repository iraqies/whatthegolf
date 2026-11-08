using Core;
using MPuppet;
using UnityEngine;

public class MPuppetWrestlerShooter : GolfBallShooterBase
{
	public MPuppetController puppet;

	public MPuppetGrabBehaviour grab;

	protected override void Awake()
	{
	base.Awake();
	}

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnCancel()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}
}
