using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000027")]
public abstract class BaseSpline
{
	[Token(Token = "0x2000028")]
	public enum UniSplineType
	{
		[Token(Token = "0x4000063")]
		CatmullRom = 0,
		[Token(Token = "0x4000064")]
		Hermite = 1,
		[Token(Token = "0x4000065")]
		KochanekBartels = 2
	}

	[Token(Token = "0x2000029")]
	public enum SplineWrapMode
	{
		[Token(Token = "0x4000067")]
		Once = 0,
		[Token(Token = "0x4000068")]
		Repeat = 1,
		[Token(Token = "0x4000069")]
		PingPong = 2,
		[Token(Token = "0x400006A")]
		Loop = 3
	}

	[Token(Token = "0x200002A")]
	public enum SplinePointType
	{
		[Token(Token = "0x400006C")]
		Corner = 0,
		[Token(Token = "0x400006D")]
		Smooth = 1,
		[Token(Token = "0x400006E")]
		Bezier = 2,
		[Token(Token = "0x400006F")]
		BezierCorner = 3
	}

	[Token(Token = "0x200002B")]
	public enum SplineSegmentType
	{
		[Token(Token = "0x4000071")]
		Linear = 0,
		[Token(Token = "0x4000072")]
		Curve = 1
	}

	[Token(Token = "0x200002C")]
	public enum SplineReparamType
	{
		[Token(Token = "0x4000074")]
		None = 0,
		[Token(Token = "0x4000075")]
		Simple = 1,
		[Token(Token = "0x4000076")]
		RungeKutta = 2
	}

	[Token(Token = "0x200002D")]
	public class SplineIterator
	{
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x10")]
		private Transform m_transform;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x18")]
		private BaseSpline m_spline;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x20")]
		private int m_segidx;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x24")]
		private int m_startidx;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x28")]
		private int m_endidx;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_reverse;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x2D")]
		private bool m_back;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x2E")]
		private bool m_onceout;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x30")]
		private float m_segpos;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1336C24", Offset = "0x1336C24", VA = "0x1336C24")]
		internal SplineIterator(BaseSpline spline, bool reverse, int startidx, int endidx)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1336D40", Offset = "0x1336D40", VA = "0x1336D40")]
		public void SetTransform(Transform trnsfrm)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1336D48", Offset = "0x1336D48", VA = "0x1336D48")]
		public Vector3 GetPosition()
		{
			return default;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1336E5C", Offset = "0x1336E5C", VA = "0x1336E5C")]
		public Vector3 GetTangent()
		{
			return default;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1336CDC", Offset = "0x1336CDC", VA = "0x1336CDC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1337064", Offset = "0x1337064", VA = "0x1337064")]
		public void SetOffset(float offset)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x13370E0", Offset = "0x13370E0", VA = "0x13370E0")]
		public void Iterate(float length)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1337054", Offset = "0x1337054", VA = "0x1337054")]
		private void SetToStart()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1337010", Offset = "0x1337010", VA = "0x1337010")]
		private void SetToEnd()
		{
		}
	}

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	protected SplineWrapMode m_wrapmode;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	protected float m_length;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected int m_stepcount;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	protected SplineReparamType m_reparam;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x20")]
	protected int m_buildnum;

	[Token(Token = "0x17000019")]
	public int BuildNum
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x12FB518", Offset = "0x12FB518", VA = "0x12FB518")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700001A")]
	public float Length
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x12FB520", Offset = "0x12FB520", VA = "0x12FB520")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700001B")]
	public SplineWrapMode WrapMode
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x12FB528", Offset = "0x12FB528", VA = "0x12FB528")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000093")]
	public abstract int GetSegmentCount();

	[Token(Token = "0x6000094")]
	protected abstract float GetSegmentLength(int segidx);

	[Token(Token = "0x6000095")]
	protected abstract float GetSegmentStartLength(int segidx);

	[Token(Token = "0x6000096")]
	protected abstract int FindSegment(float offset);

	[Token(Token = "0x6000097")]
	protected abstract Vector3 GetDrawPosition(int segidx, float segpos);

	[Token(Token = "0x6000098")]
	protected abstract Vector3 GetPosition(int segidx, float segpos);

	[Token(Token = "0x6000099")]
	protected abstract Vector3 GetTangent(int segidx, float segpos);

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x12FB530", Offset = "0x12FB530", VA = "0x12FB530")]
	public SplineIterator GetIterator()
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x12FB5B8", Offset = "0x12FB5B8", VA = "0x12FB5B8")]
	public SplineIterator GetPartialIterator(int startidx, int endidx)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x12FB63C", Offset = "0x12FB63C", VA = "0x12FB63C")]
	public Vector3[] GenerateDrawPoints(int divs)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x12FB7B4", Offset = "0x12FB7B4", VA = "0x12FB7B4")]
	protected BaseSpline()
	{
	}
}
