using Core;
using UnityEngine;

public class ObjectDraggerShooter : GolfBall2DShooterBase
{
	public float DragForce;

	public ForceMode2D DragMode;

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}
}
