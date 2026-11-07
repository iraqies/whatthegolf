using UnityEngine;

[ExecuteInEditMode]
public class LineRope : MonoBehaviour
{
	public Transform LineStart;

	public Transform LineEnd;

	public bool DoLineJiggle;

	public int Segments;

	public AnimationCurve Curve;

	public AnimationCurve EffectOverTime;

	public AnimationCurve CurveEffect;

	public float JiggleStrength;

	public float JiggleTimerSpeed;

	public float IsKinematicSpeedMultiplier;

	private Rigidbody rigid;

	private LineRenderer lineRenderer;

	private float jiggleTimer;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}
}
