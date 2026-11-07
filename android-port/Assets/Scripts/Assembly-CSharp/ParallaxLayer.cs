using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008AC")]
public class ParallaxLayer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20008AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41B90", Offset = "0x41B90")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002FA4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002FA5")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Transform, float> _003C_003E9__4_0;

		[Token(Token = "0x6002810")]
		[Address(RVA = "0x18225A8", Offset = "0x18225A8", VA = "0x18225A8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002811")]
		[Address(RVA = "0x18225B0", Offset = "0x18225B0", VA = "0x18225B0")]
		internal float _003CStart_003Eb__4_0(Transform r)
		{
			return default;
		}
	}

	[Token(Token = "0x4002FA0")]
	[FieldOffset(Offset = "0x18")]
	public float SpeedMod;

	[Token(Token = "0x4002FA1")]
	[FieldOffset(Offset = "0x20")]
	public Camera ParallaxCamera;

	[Token(Token = "0x4002FA2")]
	[FieldOffset(Offset = "0x28")]
	private float widthOfObjects;

	[Token(Token = "0x4002FA3")]
	[FieldOffset(Offset = "0x30")]
	private List<Transform> sortedChildren;

	[Token(Token = "0x600280C")]
	[Address(RVA = "0x15DAC84", Offset = "0x15DAC84", VA = "0x15DAC84")]
	private void Start()
	{
	}

	[Token(Token = "0x600280D")]
	[Address(RVA = "0x15DB23C", Offset = "0x15DB23C", VA = "0x15DB23C")]
	private void Update()
	{
	}

	[Token(Token = "0x600280E")]
	[Address(RVA = "0x15DB494", Offset = "0x15DB494", VA = "0x15DB494")]
	public ParallaxLayer()
	{
	}
}
