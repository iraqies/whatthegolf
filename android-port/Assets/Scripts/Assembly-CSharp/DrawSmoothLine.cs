using UnityEngine;

public class DrawSmoothLine : MonoBehaviour
{
	public bool UpdateAutomatically;

	public LineRenderer brush;

	public float StepDetail;

	public bool UseBezier;

	public bool UseEndPointAsStartPoint;

	public Vector3 Offset;

	private float t;

	private int[] controlIndex;

	private int[] endIndex;

	private float detail;

	private Transform start;

	private Transform end;

	private Transform control;

	private void UpdateLine()
	{
	}

	private float DetermineLength()
	{
		return 0f;
	}

	private void OnDrawGizmos()
	{
	}

	private void UpdateIndexes()
	{
	}
}
