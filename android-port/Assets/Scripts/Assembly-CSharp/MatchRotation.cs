using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C08")]
public class MatchRotation : MonoBehaviour
{
	[Token(Token = "0x4004295")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 AxisToMatch;

	[Token(Token = "0x4004296")]
	[FieldOffset(Offset = "0x28")]
	public Transform RotationToMatch;

	[Token(Token = "0x4004297")]
	[FieldOffset(Offset = "0x30")]
	private Transform cachedTrans;

	[Token(Token = "0x60039B9")]
	[Address(RVA = "0x155EE5C", Offset = "0x155EE5C", VA = "0x155EE5C")]
	private void Start()
	{
	}

	[Token(Token = "0x60039BA")]
	[Address(RVA = "0x155EE84", Offset = "0x155EE84", VA = "0x155EE84")]
	private void Update()
	{
	}

	[Token(Token = "0x60039BB")]
	[Address(RVA = "0x155EF78", Offset = "0x155EF78", VA = "0x155EF78")]
	public MatchRotation()
	{
	}
}
