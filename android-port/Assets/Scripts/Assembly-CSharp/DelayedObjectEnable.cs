using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BD4")]
public class DelayedObjectEnable : MonoBehaviour
{
	[Token(Token = "0x40041C9")]
	[FieldOffset(Offset = "0x18")]
	public List<Behaviour> BehavioursToToggle;

	[Token(Token = "0x60038DE")]
	[Address(RVA = "0x18D957C", Offset = "0x18D957C", VA = "0x18D957C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60038DF")]
	[Address(RVA = "0x18D97F4", Offset = "0x18D97F4", VA = "0x18D97F4")]
	private void OnStart()
	{
	}

	[Token(Token = "0x60038E0")]
	[Address(RVA = "0x18D969C", Offset = "0x18D969C", VA = "0x18D969C")]
	private void Toggle(bool state)
	{
	}

	[Token(Token = "0x60038E1")]
	[Address(RVA = "0x18D97FC", Offset = "0x18D97FC", VA = "0x18D97FC")]
	public DelayedObjectEnable()
	{
	}
}
