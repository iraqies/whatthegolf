using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BF7")]
public class SaveGifsOnIntervals : BaseSaveGif
{
	[Serializable]
	[Token(Token = "0x2000BF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43ED8", Offset = "0x43ED8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400424E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400424F")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__4_0;

		[Token(Token = "0x6003974")]
		[Address(RVA = "0x183DA80", Offset = "0x183DA80", VA = "0x183DA80")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003975")]
		[Address(RVA = "0x183DA88", Offset = "0x183DA88", VA = "0x183DA88")]
		internal void _003CInstance_OnGoal_003Eb__4_0(float t)
		{
		}
	}

	[Token(Token = "0x400424C")]
	[FieldOffset(Offset = "0x38")]
	public List<int> RecordOnShots;

	[Token(Token = "0x400424D")]
	[FieldOffset(Offset = "0x40")]
	private float gifDuration;

	[Token(Token = "0x600396E")]
	[Address(RVA = "0x16765F0", Offset = "0x16765F0", VA = "0x16765F0", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600396F")]
	[Address(RVA = "0x1676700", Offset = "0x1676700", VA = "0x1676700")]
	private void InstanceOnOnGolfStroke(GolfBallController controller, int strokes)
	{
	}

	[Token(Token = "0x6003970")]
	[Address(RVA = "0x16767EC", Offset = "0x16767EC", VA = "0x16767EC")]
	private void Instance_OnGoal(string obj)
	{
	}

	[Token(Token = "0x6003971")]
	[Address(RVA = "0x1676998", Offset = "0x1676998", VA = "0x1676998")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003972")]
	[Address(RVA = "0x1676A2C", Offset = "0x1676A2C", VA = "0x1676A2C")]
	public SaveGifsOnIntervals()
	{
	}
}
