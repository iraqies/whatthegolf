using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200003A")]
public class UniSplineTest : MonoBehaviour
{
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x18")]
	public UniSplineComponent m_spline;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x20")]
	public float m_speed;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x24")]
	public float m_curspeed;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x28")]
	public float m_position;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 m_up;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x38")]
	public Ease.Easing m_easing;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x40")]
	private BaseSpline.SplineIterator m_iter;

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1325B2C", Offset = "0x1325B2C", VA = "0x1325B2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1325B84", Offset = "0x1325B84", VA = "0x1325B84")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1325CFC", Offset = "0x1325CFC", VA = "0x1325CFC")]
	public UniSplineTest()
	{
	}
}
