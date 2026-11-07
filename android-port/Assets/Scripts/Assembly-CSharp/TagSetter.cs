using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000207")]
public class TagSetter : MonoBehaviour
{
	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private new string tag;

	[Token(Token = "0x40009E8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool setOnAwake;

	[Token(Token = "0x6000912")]
	[Address(RVA = "0x16F6E88", Offset = "0x16F6E88", VA = "0x16F6E88")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000913")]
	[Address(RVA = "0x16F6ED4", Offset = "0x16F6ED4", VA = "0x16F6ED4")]
	public void SetTag()
	{
	}

	[Token(Token = "0x6000914")]
	[Address(RVA = "0x16F6F08", Offset = "0x16F6F08", VA = "0x16F6F08")]
	public TagSetter()
	{
	}
}
