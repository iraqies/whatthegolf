using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004B3")]
public class InvisibleCullingObject : MonoBehaviour
{
	[Token(Token = "0x20004B4")]
	public delegate void OnVisibleDelegate();

	[Token(Token = "0x40018D2")]
	[FieldOffset(Offset = "0x18")]
	public OnVisibleDelegate OnVisible;

	[Token(Token = "0x40018D3")]
	[FieldOffset(Offset = "0x20")]
	public OnVisibleDelegate OnInvisible;

	[Token(Token = "0x60015C0")]
	[Address(RVA = "0x14F508C", Offset = "0x14F508C", VA = "0x14F508C")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x60015C1")]
	[Address(RVA = "0x14F50A0", Offset = "0x14F50A0", VA = "0x14F50A0")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x60015C2")]
	[Address(RVA = "0x14F50B4", Offset = "0x14F50B4", VA = "0x14F50B4")]
	public InvisibleCullingObject()
	{
	}
}
