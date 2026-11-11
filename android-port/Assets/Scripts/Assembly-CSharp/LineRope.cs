using UnityEngine;

[ExecuteInEditMode]
public class LineRope : MonoBehaviour
{
	public Transform LineStart;

	public Transform LineEnd;

	public Transform Target
	{
		get => LineEnd;
		set => LineEnd = value;
	}

	public bool DoLineJiggle;

	public int Segments;

	public AnimationCurve Curve;

	public AnimationCurve EffectOverTime;

	public AnimationCurve CurveEffect;

	public float JiggleStrength = 1f;

	public float JiggleTimerSpeed = 1f;

	public float IsKinematicSpeedMultiplier = 3f;

	private Rigidbody rigid;

	private LineRenderer lineRenderer;

	private float jiggleTimer;

	private void Start()
	{
		if (DoLineJiggle)
		{
			rigid = GetComponent<Rigidbody>();
		}
		lineRenderer = GetComponent<LineRenderer>();
		if (lineRenderer != null)
		{
			lineRenderer.positionCount = (DoLineJiggle ? (Segments + 2) : 2);
		}
	}

	private void Update()
	{
		if (lineRenderer == null)
		{
			return;
		}
		if (LineStart == null || LineEnd == null)
		{
			lineRenderer.enabled = false;
			return;
		}
		lineRenderer.enabled = true;
		Vector3 startPos = (lineRenderer.useWorldSpace ? LineStart.position : base.transform.InverseTransformPoint(LineStart.position));
		Vector3 endPos = (lineRenderer.useWorldSpace ? LineEnd.position : base.transform.InverseTransformPoint(LineEnd.position));
		lineRenderer.SetPosition(0, startPos);
		lineRenderer.SetPosition(1, endPos);
		if (!DoLineJiggle)
		{
			return;
		}
		lineRenderer.SetPosition(0, startPos);
		Vector3 jiggleAxis = (base.transform.right + base.transform.up).normalized;
		Vector3 delta = endPos - startPos;
		for (int i = 1; i <= Segments; i++)
		{
			float t = (float)i / (float)Segments;
			Vector3 rotatedDir = Quaternion.AngleAxis(t * 360f, base.transform.forward) * jiggleAxis;
			float c1 = ((Curve != null) ? Curve.Evaluate(t) : 0f);
			float c2 = ((EffectOverTime != null) ? EffectOverTime.Evaluate(jiggleTimer) : 0f);
			float c3 = ((CurveEffect != null) ? CurveEffect.Evaluate(t) : 0f);
			Vector3 pos = startPos + delta * t + rotatedDir * (c1 * c2 * c3 * JiggleStrength);
			lineRenderer.SetPosition(i, pos);
		}
		lineRenderer.SetPosition(Segments + 1, endPos);
		float mult = ((rigid != null && rigid.isKinematic) ? IsKinematicSpeedMultiplier : 1f);
		jiggleTimer += Time.deltaTime * JiggleTimerSpeed * mult;
	}

	private void OnEnable()
	{
		jiggleTimer = 0f;
		if (lineRenderer == null)
		{
			Start();
		}
		Update();
	}
}
