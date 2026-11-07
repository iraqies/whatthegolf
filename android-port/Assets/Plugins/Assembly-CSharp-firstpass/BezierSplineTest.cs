using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000033")]
public class BezierSplineTest : MonoBehaviour
{
	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x18")]
	public BezierSplineComponent m_spline;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x20")]
	public float m_speed;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x24")]
	public float m_curspeed;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_up;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x38")]
	private BaseSpline.SplineIterator m_iter;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1301064", Offset = "0x1301064", VA = "0x1301064")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x13010BC", Offset = "0x13010BC", VA = "0x13010BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1301200", Offset = "0x1301200", VA = "0x1301200")]
	public BezierSplineTest()
	{
	}
}
