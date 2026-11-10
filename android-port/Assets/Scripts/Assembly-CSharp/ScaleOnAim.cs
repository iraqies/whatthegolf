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

	public float shootTime = 0.4f;

	public float controllerCooldown = 0.1f;

	private bool controllerCanShoot = true;

	private void Start()
	{
		if (Target != null)
		{
			orginalScale = Target.transform.localScale;
		}
	}

	public override void OnShootNotWrapped(Vector3 b)
	{
		if (!ExecuteOnShoot)
			return;

		StopAllCoroutines();
		StartCoroutine(OnShoot());
		base.OnShootNotWrapped(b);
	}

	public override void OnAimNotWrapped(Vector3 b)
	{
		if (InputHelper.IsNavigatingWithController() && !controllerCanShoot)
			return;

		if (!ExecuteOnAim)
			return;

		StopAllCoroutines();
		if (!InputHelper.IsNavigatingWithController() && Target != null && OnAimCurve != null)
		{
			float eval = OnAimCurve.Evaluate(b.magnitude);
			Target.transform.localScale = Vector3.LerpUnclamped(orginalScale, TargetScaleOnAim, eval);
		}
		base.OnAimNotWrapped(b);
	}

	private IEnumerator OnShoot()
	{
		controllerCanShoot = false;
		Vector3 startScale = Target != null ? Target.transform.localScale : orginalScale;

		yield return StartCoroutine(pTween.To(shootTime * 0.5f, 0f, 1f, t =>
		{
			if (Target != null && OnShootCurve != null)
			{
				float eval = OnShootCurve.Evaluate(t);
				Target.transform.localScale = Vector3.LerpUnclamped(startScale, TargetScaleOnShoot, eval);
			}
		}));

		yield return StartCoroutine(pTween.To(shootTime * 0.5f, 0f, 1f, t =>
		{
			if (Target != null && OnShootCurve != null)
			{
				float eval = OnShootCurve.Evaluate(t);
				Target.transform.localScale = Vector3.LerpUnclamped(TargetScaleOnShoot, orginalScale, eval);
			}
		}));

		yield return new WaitForSeconds(controllerCooldown);
		controllerCanShoot = true;
	}
}
