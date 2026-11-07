using UnityEngine;

public abstract class BaseSpline
{
	public enum UniSplineType
	{
		CatmullRom = 0,
		Hermite = 1,
		KochanekBartels = 2
	}

	public enum SplineWrapMode
	{
		Once = 0,
		Repeat = 1,
		PingPong = 2,
		Loop = 3
	}

	public enum SplinePointType
	{
		Corner = 0,
		Smooth = 1,
		Bezier = 2,
		BezierCorner = 3
	}

	public enum SplineSegmentType
	{
		Linear = 0,
		Curve = 1
	}

	public enum SplineReparamType
	{
		None = 0,
		Simple = 1,
		RungeKutta = 2
	}

	public class SplineIterator
	{
		private Transform m_transform;

		private BaseSpline m_spline;

		private int m_segidx;

		private int m_startidx;

		private int m_endidx;

		private bool m_reverse;

		private bool m_back;

		private bool m_onceout;

		private float m_segpos;

		internal SplineIterator(BaseSpline spline, bool reverse, int startidx, int endidx)
		{
		}

		public void SetTransform(Transform trnsfrm)
		{
		}

		public Vector3 GetPosition()
		{
			return default;
		}

		public Vector3 GetTangent()
		{
			return default;
		}

		public void Reset()
		{
		}

		public void SetOffset(float offset)
		{
		}

		public void Iterate(float length)
		{
		}

		private void SetToStart()
		{
		}

		private void SetToEnd()
		{
		}
	}

	[SerializeField]
	protected SplineWrapMode m_wrapmode;

	[SerializeField]
	protected float m_length;

	[SerializeField]
	protected int m_stepcount;

	[SerializeField]
	protected SplineReparamType m_reparam;

	protected int m_buildnum;

	public int BuildNum => 0;

	public float Length => 0f;

	public SplineWrapMode WrapMode => SplineWrapMode.Once;

	public abstract int GetSegmentCount();

	protected abstract float GetSegmentLength(int segidx);

	protected abstract float GetSegmentStartLength(int segidx);

	protected abstract int FindSegment(float offset);

	protected abstract Vector3 GetDrawPosition(int segidx, float segpos);

	protected abstract Vector3 GetPosition(int segidx, float segpos);

	protected abstract Vector3 GetTangent(int segidx, float segpos);

	public SplineIterator GetIterator()
	{
		return null;
	}

	public SplineIterator GetPartialIterator(int startidx, int endidx)
	{
		return null;
	}

	public Vector3[] GenerateDrawPoints(int divs)
	{
		return null;
	}
}
