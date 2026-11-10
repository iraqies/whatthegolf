using UnityEngine;

public class DrawSmoothLine : MonoBehaviour
{
	public bool UpdateAutomatically;

	public LineRenderer brush;

	public float StepDetail = 0.25f;

	public bool UseBezier = true;

	public bool UseEndPointAsStartPoint;

	public Vector3 Offset;

	private float t;

	private int[] controlIndex;

	private int[] endIndex;

	private float detail;

	private Transform start;

	private Transform end;

	private Transform control;

	private void Awake()
	{
		if (brush == null)
		{
			brush = GetComponent<LineRenderer>();
		}
		UpdateIndexes();
		UpdateLine();
	}

	private void Update()
	{
		if (UpdateAutomatically)
		{
			UpdateLine();
		}
	}

	private void UpdateLine()
	{
		if (brush == null || transform.childCount < 2)
		{
			return;
		}
		UpdateIndexes();
		if (start == null || end == null)
		{
			return;
		}
		float len = DetermineLength();
		int steps = Mathf.Clamp(Mathf.CeilToInt(len / Mathf.Max(0.05f, StepDetail)), 4, 64);
		brush.positionCount = steps + 1;
		Vector3 p0 = start.position + Offset;
		Vector3 p2 = end.position + Offset;
		Vector3 p1 = control != null ? (control.position + Offset) : ((p0 + p2) * 0.5f);
		for (int i = 0; i <= steps; i++)
		{
			float u = (float)i / steps;
			if (UseBezier && control != null)
			{
				float oneMinusU = 1f - u;
				Vector3 pt = oneMinusU * oneMinusU * p0 + 2f * oneMinusU * u * p1 + u * u * p2;
				brush.SetPosition(i, pt);
			}
			else
			{
				brush.SetPosition(i, Vector3.Lerp(p0, p2, u));
			}
		}
	}

	private float DetermineLength()
	{
		if (start == null || end == null)
		{
			return 1f;
		}
		if (UseBezier && control != null)
		{
			return Vector3.Distance(start.position, control.position) + Vector3.Distance(control.position, end.position);
		}
		return Vector3.Distance(start.position, end.position);
	}

	private void OnDrawGizmos()
	{
	}

	private void UpdateIndexes()
	{
		if (transform.childCount >= 3)
		{
			start = transform.GetChild(0);
			control = transform.GetChild(1);
			end = transform.GetChild(2);
		}
		else if (transform.childCount == 2)
		{
			start = transform.GetChild(0);
			control = null;
			end = transform.GetChild(1);
		}
	}
}
