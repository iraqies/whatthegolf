using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000032")]
public class BezierSplinePartialTest : MonoBehaviour
{
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x18")]
	public BezierSplineComponent m_spline;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x20")]
	public float m_speed;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 m_up;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x30")]
	private BaseSpline.SplineIterator m_iter;

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1300F10", Offset = "0x1300F10", VA = "0x1300F10")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1300F70", Offset = "0x1300F70", VA = "0x1300F70")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1301028", Offset = "0x1301028", VA = "0x1301028")]
	public BezierSplinePartialTest()
	{
	}
}
