using UnityEngine;

public class UniSplineTest : MonoBehaviour
{
	public UniSplineComponent m_spline;

	public float m_speed;

	public float m_curspeed;

	public float m_position;

	public Vector3 m_up;

	public Ease.Easing m_easing;

	private BaseSpline.SplineIterator m_iter;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
