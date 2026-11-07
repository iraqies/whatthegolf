using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C5E")]
public class ToggleGameObjectBasedOnPlatform : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000C5F")]
	public class PlatformToggle
	{
		[Token(Token = "0x40043E8")]
		[FieldOffset(Offset = "0x10")]
		public RuntimePlatform Platform;

		[Token(Token = "0x40043E9")]
		[FieldOffset(Offset = "0x14")]
		public bool State;

		[Token(Token = "0x6003AC9")]
		[Address(RVA = "0x1868EA4", Offset = "0x1868EA4", VA = "0x1868EA4")]
		public PlatformToggle()
		{
		}
	}

	[Token(Token = "0x40043E7")]
	[FieldOffset(Offset = "0x18")]
	public List<PlatformToggle> Platforms;

	[Token(Token = "0x6003AC7")]
	[Address(RVA = "0x171A3E8", Offset = "0x171A3E8", VA = "0x171A3E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003AC8")]
	[Address(RVA = "0x171A574", Offset = "0x171A574", VA = "0x171A574")]
	public ToggleGameObjectBasedOnPlatform()
	{
	}
}
