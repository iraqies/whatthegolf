using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000031")]
public class BezierSplineComponent : MonoBehaviour
{
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private BezierSpline m_spline;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x20")]
	private int m_buildnum;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x28")]
	private Vector3[] m_drawcache;

	[Token(Token = "0x1700001C")]
	public BezierSpline Spline
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1300C68", Offset = "0x1300C68", VA = "0x1300C68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1300C70", Offset = "0x1300C70", VA = "0x1300C70")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1300E0C", Offset = "0x1300E0C", VA = "0x1300E0C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1300C98", Offset = "0x1300C98", VA = "0x1300C98")]
	private void DrawGizmos(Color color)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1300E34", Offset = "0x1300E34", VA = "0x1300E34")]
	public BezierSplineComponent()
	{
	}
}
