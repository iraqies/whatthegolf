using UnityEngine;

public class UniSplineComponent : MonoBehaviour
{
	[SerializeField]
	private UniSpline m_spline;

	private int m_buildnum;

	private Vector3[] m_drawcache;

	public UniSpline Spline => null;

	private void OnDrawGizmosSelected()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public void DrawGizmos(Color color)
	{
	}
}
