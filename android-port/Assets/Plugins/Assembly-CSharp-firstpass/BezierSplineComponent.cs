using UnityEngine;

public class BezierSplineComponent : MonoBehaviour
{
	[SerializeField]
	private BezierSpline m_spline;

	private int m_buildnum;

	private Vector3[] m_drawcache;

	public BezierSpline Spline => null;

	private void OnDrawGizmosSelected()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void DrawGizmos(Color color)
	{
	}
}
