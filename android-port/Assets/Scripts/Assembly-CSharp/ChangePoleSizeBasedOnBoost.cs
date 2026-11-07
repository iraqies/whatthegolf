using Core;
using UnityEngine;

public class ChangePoleSizeBasedOnBoost : MonoBehaviour
{
	public GolfBallController Controller;

	public Vector2 ScaleRange;

	public AnimationCurve GrowCurve;

	public float GrowSmoothTime;

	private Vector3 targetScale;

	private Vector3 velRef;

	private void Start()
	{
	}

	private void ControllerOnOnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private void Update()
	{
	}
}
