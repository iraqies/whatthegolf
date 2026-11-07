using System.Collections;
using UnityEngine;

public class ScaleOnAim : BaseDailyPrizeInteractions
{
	public AnimationCurve OnAimCurve;

	public AnimationCurve OnShootCurve;

	public Vector3 TargetScaleOnAim;

	public Vector3 TargetScaleOnShoot;

	private Vector3 orginalScale;

	public GameObject Target;

	public float shootTime;

	public float controllerCooldown;

	private bool controllerCanShoot;

	private void Start()
	{
	}

	public override void OnShootNotWrapped(Vector3 b)
	{
	}

	public override void OnAimNotWrapped(Vector3 b)
	{
	}

	private IEnumerator OnShoot()
	{
		return null;
	}
}
