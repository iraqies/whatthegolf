using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000852")]
public class ChangeSoccerPlayer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000853")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x419D8", Offset = "0x419D8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002D22")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002D23")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GolfBallController, bool> _003C_003E9__4_0;

		[Token(Token = "0x6002665")]
		[Address(RVA = "0x1783448", Offset = "0x1783448", VA = "0x1783448")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002666")]
		[Address(RVA = "0x1783450", Offset = "0x1783450", VA = "0x1783450")]
		internal bool _003COnKick_003Eb__4_0(GolfBallController c)
		{
			return default;
		}
	}

	[Token(Token = "0x4002D1F")]
	[FieldOffset(Offset = "0x18")]
	public SoccerPlayer ComputerPlayer;

	[Token(Token = "0x4002D20")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController Controller;

	[Token(Token = "0x4002D21")]
	[FieldOffset(Offset = "0x28")]
	public List<GolfBallController> OtherControllers;

	[Token(Token = "0x6002661")]
	[Address(RVA = "0x1898810", Offset = "0x1898810", VA = "0x1898810")]
	private void Start()
	{
	}

	[Token(Token = "0x6002662")]
	[Address(RVA = "0x18988D8", Offset = "0x18988D8", VA = "0x18988D8")]
	private void OnKick()
	{
	}

	[Token(Token = "0x6002663")]
	[Address(RVA = "0x1898A34", Offset = "0x1898A34", VA = "0x1898A34")]
	public ChangeSoccerPlayer()
	{
	}
}
