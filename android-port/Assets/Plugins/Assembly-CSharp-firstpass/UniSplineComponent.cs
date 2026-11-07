using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000039")]
public class UniSplineComponent : MonoBehaviour
{
	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UniSpline m_spline;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x20")]
	private int m_buildnum;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x28")]
	private Vector3[] m_drawcache;

	[Token(Token = "0x1700001D")]
	public UniSpline Spline
	{
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1325884", Offset = "0x1325884", VA = "0x1325884")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x132588C", Offset = "0x132588C", VA = "0x132588C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1325A28", Offset = "0x1325A28", VA = "0x1325A28")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x13258B4", Offset = "0x13258B4", VA = "0x13258B4")]
	public void DrawGizmos(Color color)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1325A50", Offset = "0x1325A50", VA = "0x1325A50")]
	public UniSplineComponent()
	{
	}
}
