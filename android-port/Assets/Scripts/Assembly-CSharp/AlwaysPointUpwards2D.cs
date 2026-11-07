using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BB2")]
public class AlwaysPointUpwards2D : MonoBehaviour
{
	[Token(Token = "0x4004135")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 OverrideRotation;

	[Token(Token = "0x4004136")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 OverrideLocalPosition;

	[Token(Token = "0x600386D")]
	[Address(RVA = "0x140D644", Offset = "0x140D644", VA = "0x140D644")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600386E")]
	[Address(RVA = "0x140D704", Offset = "0x140D704", VA = "0x140D704")]
	public AlwaysPointUpwards2D()
	{
	}
}
