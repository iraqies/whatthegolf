using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Il2CppDummyDll;
using Rewired;
using TMPro;
using UnityEngine;

[Token(Token = "0x200048D")]
public class ManageControllerDisconnects : MonoBehaviour
{
	[Token(Token = "0x200048E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FC4C", Offset = "0x3FC4C")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x400182A")]
		[FieldOffset(Offset = "0x10")]
		public ControllerStatusChangedEventArgs args;

		[Token(Token = "0x6001521")]
		[Address(RVA = "0x17F2F50", Offset = "0x17F2F50", VA = "0x17F2F50")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6001522")]
		[Address(RVA = "0x17F2F58", Offset = "0x17F2F58", VA = "0x17F2F58")]
		internal bool _003COnControllerPreDisconnectEvent_003Eb__2(GolfBallController c)
		{
			return default;
		}

		[Token(Token = "0x6001523")]
		[Address(RVA = "0x17F2F88", Offset = "0x17F2F88", VA = "0x17F2F88")]
		internal bool _003COnControllerPreDisconnectEvent_003Eb__3(GolfBallController c)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x200048F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FC5C", Offset = "0x3FC5C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400182B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400182C")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GolfBallController, int> _003C_003E9__6_0;

		[Token(Token = "0x400182D")]
		[FieldOffset(Offset = "0x10")]
		public static Func<IGrouping<int, GolfBallController>, GolfBallController> _003C_003E9__6_1;

		[Token(Token = "0x6001525")]
		[Address(RVA = "0x17F2EDC", Offset = "0x17F2EDC", VA = "0x17F2EDC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001526")]
		[Address(RVA = "0x17F2EE4", Offset = "0x17F2EE4", VA = "0x17F2EE4")]
		internal int _003COnControllerPreDisconnectEvent_003Eb__6_0(GolfBallController c)
		{
			return default;
		}

		[Token(Token = "0x6001527")]
		[Address(RVA = "0x17F2EFC", Offset = "0x17F2EFC", VA = "0x17F2EFC")]
		internal GolfBallController _003COnControllerPreDisconnectEvent_003Eb__6_1(IGrouping<int, GolfBallController> c)
		{
			return null;
		}
	}

	[Token(Token = "0x4001826")]
	[FieldOffset(Offset = "0x18")]
	public GameObject WarningContainer;

	[Token(Token = "0x4001827")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Text;

	[Token(Token = "0x4001828")]
	[FieldOffset(Offset = "0x28")]
	private List<Player> disconnectedPlayers;

	[Token(Token = "0x4001829")]
	[FieldOffset(Offset = "0x30")]
	private bool checkForMouseClick;

	[Token(Token = "0x600151B")]
	[Address(RVA = "0x155A1C4", Offset = "0x155A1C4", VA = "0x155A1C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600151C")]
	[Address(RVA = "0x155A36C", Offset = "0x155A36C", VA = "0x155A36C")]
	private void Update()
	{
	}

	[Token(Token = "0x600151D")]
	[Address(RVA = "0x155A770", Offset = "0x155A770", VA = "0x155A770")]
	private void OnControllerPreDisconnectEvent(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x600151E")]
	[Address(RVA = "0x155AD54", Offset = "0x155AD54", VA = "0x155AD54")]
	private void OnControllerConnectedEvent(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x600151F")]
	[Address(RVA = "0x155A50C", Offset = "0x155A50C", VA = "0x155A50C")]
	private void ControllerReconnected(int id)
	{
	}

	[Token(Token = "0x6001520")]
	[Address(RVA = "0x155AD6C", Offset = "0x155AD6C", VA = "0x155AD6C")]
	public ManageControllerDisconnects()
	{
	}
}
