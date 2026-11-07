using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007F1")]
public class OnTriggerEnterListener : MonoBehaviour
{
	[Token(Token = "0x20007F2")]
	public delegate void OnTriggerEnterDelegate(Collider other);

	[Token(Token = "0x4002A9B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F00C", Offset = "0x4F00C")]
	private OnTriggerEnterDelegate m_OnTriggerEnterCallback;

	[Token(Token = "0x14000032")]
	public event OnTriggerEnterDelegate OnTriggerEnterCallback
	{
		[Token(Token = "0x6002478")]
		[Address(RVA = "0x159AC50", Offset = "0x159AC50", VA = "0x159AC50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x66580", Offset = "0x66580")]
		add
		{
		}
		[Token(Token = "0x6002479")]
		[Address(RVA = "0x159ACF4", Offset = "0x159ACF4", VA = "0x159ACF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x66590", Offset = "0x66590")]
		remove
		{
		}
	}

	[Token(Token = "0x600247A")]
	[Address(RVA = "0x159AD98", Offset = "0x159AD98", VA = "0x159AD98")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600247B")]
	[Address(RVA = "0x159ADAC", Offset = "0x159ADAC", VA = "0x159ADAC")]
	public OnTriggerEnterListener()
	{
	}
}
