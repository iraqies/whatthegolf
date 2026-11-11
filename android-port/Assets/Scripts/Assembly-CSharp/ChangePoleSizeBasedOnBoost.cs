using Core;
using UnityEngine;

public class ChangePoleSizeBasedOnBoost : MonoBehaviour
{
	public GolfBallController Controller;

	public Vector2 ScaleRange = new Vector2(0.5f, 5f);

	public AnimationCurve GrowCurve;

	public float GrowSmoothTime = 0.2f;

	private Vector3 targetScale;

	private Vector3 velRef;

	private void Start()
	{
		Controller.OnAimUpdate += ControllerOnOnAimUpdate;
		targetScale = base.transform.localScale;
	}

	private void ControllerOnOnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (!onlyAimArrow)
		{
			targetScale = Vector3.Lerp(new Vector3(base.transform.localScale.x, ScaleRange.x, base.transform.localScale.z), new Vector3(base.transform.localScale.x, ScaleRange.y, base.transform.localScale.z), GrowCurve.Evaluate(boost.magnitude));
		}
	}

	private void Update()
	{
		if (base.transform.localScale != targetScale)
		{
			base.transform.localScale = Vector3.SmoothDamp(base.transform.localScale, targetScale, ref velRef, GrowSmoothTime);
		}
	}
}
