using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Token(Token = "0x20003E9")]
public class IOSHapticsManager : MonoBehaviour
{
	[Token(Token = "0x20003EA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F94C", Offset = "0x3F94C")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4001567")]
		[FieldOffset(Offset = "0x10")]
		public IOSHapticsManager _003C_003E4__this;

		[Token(Token = "0x4001568")]
		[FieldOffset(Offset = "0x18")]
		public OverworldBallManager ballManager;

		[Token(Token = "0x6001268")]
		[Address(RVA = "0x17C175C", Offset = "0x17C175C", VA = "0x17C175C")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6001269")]
		[Address(RVA = "0x17C1764", Offset = "0x17C1764", VA = "0x17C1764")]
		internal void _003CAddEvents_003Eb__0(GolfBallController controller)
		{
		}

		[Token(Token = "0x600126A")]
		[Address(RVA = "0x17C18BC", Offset = "0x17C18BC", VA = "0x17C18BC")]
		internal void _003CAddEvents_003Eb__1(Transmogrif.BALLSHAPES b)
		{
		}

		[Token(Token = "0x600126B")]
		[Address(RVA = "0x17C1A40", Offset = "0x17C1A40", VA = "0x17C1A40")]
		internal void _003CAddEvents_003Eb__2(OverworldGoal g)
		{
		}

		[Token(Token = "0x600126C")]
		[Address(RVA = "0x17C1AF4", Offset = "0x17C1AF4", VA = "0x17C1AF4")]
		internal void _003CAddEvents_003Eb__3(OverworldButton2D g)
		{
		}

		[Token(Token = "0x600126D")]
		[Address(RVA = "0x17C1B94", Offset = "0x17C1B94", VA = "0x17C1B94")]
		internal void _003CAddEvents_003Eb__4(Button g)
		{
		}
	}

	[Token(Token = "0x20003EB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F95C", Offset = "0x3F95C")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4001569")]
		[FieldOffset(Offset = "0x10")]
		public IOSHapticsManager _003C_003E4__this;

		[Token(Token = "0x400156A")]
		[FieldOffset(Offset = "0x18")]
		public OverworldBallManager ballManager;

		[Token(Token = "0x600126E")]
		[Address(RVA = "0x17C1C34", Offset = "0x17C1C34", VA = "0x17C1C34")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600126F")]
		[Address(RVA = "0x17C1C3C", Offset = "0x17C1C3C", VA = "0x17C1C3C")]
		internal void _003CRemoveEvents_003Eb__0(GolfBallController g)
		{
		}

		[Token(Token = "0x6001270")]
		[Address(RVA = "0x17C1D94", Offset = "0x17C1D94", VA = "0x17C1D94")]
		internal void _003CRemoveEvents_003Eb__1(Transmogrif.BALLSHAPES b)
		{
		}

		[Token(Token = "0x6001271")]
		[Address(RVA = "0x17C1F18", Offset = "0x17C1F18", VA = "0x17C1F18")]
		internal void _003CRemoveEvents_003Eb__2(OverworldGoal g)
		{
		}

		[Token(Token = "0x6001272")]
		[Address(RVA = "0x17C1FCC", Offset = "0x17C1FCC", VA = "0x17C1FCC")]
		internal void _003CRemoveEvents_003Eb__3(OverworldButton2D g)
		{
		}

		[Token(Token = "0x6001273")]
		[Address(RVA = "0x17C206C", Offset = "0x17C206C", VA = "0x17C206C")]
		internal void _003CRemoveEvents_003Eb__4(Button g)
		{
		}
	}

	[Token(Token = "0x4001560")]
	[FieldOffset(Offset = "0x18")]
	private MobileVibrator mobileVibrator;

	[Token(Token = "0x4001561")]
	[FieldOffset(Offset = "0x20")]
	private List<GolfBallController> _golfBallControllers;

	[Token(Token = "0x4001562")]
	[FieldOffset(Offset = "0x28")]
	private List<OverworldGoal> _overworldGoals;

	[Token(Token = "0x4001563")]
	[FieldOffset(Offset = "0x30")]
	private List<OverworldButton2D> overworldButton2Ds;

	[Token(Token = "0x4001564")]
	[FieldOffset(Offset = "0x38")]
	private List<Button> _buttons;

	[Token(Token = "0x4001565")]
	[FieldOffset(Offset = "0x40")]
	private GolfGoal _golfGoal;

	[Token(Token = "0x4001566")]
	[FieldOffset(Offset = "0x48")]
	private iOSHapticsContainer _container;

	[Token(Token = "0x600125C")]
	[Address(RVA = "0x14E15E4", Offset = "0x14E15E4", VA = "0x14E15E4")]
	private void Start()
	{
	}

	[Token(Token = "0x600125D")]
	[Address(RVA = "0x14E1730", Offset = "0x14E1730", VA = "0x14E1730")]
	private void AddEvents(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600125E")]
	[Address(RVA = "0x14E1F7C", Offset = "0x14E1F7C", VA = "0x14E1F7C")]
	private void RemoveEvents()
	{
	}

	[Token(Token = "0x600125F")]
	[Address(RVA = "0x14E2468", Offset = "0x14E2468", VA = "0x14E2468")]
	private void OnButtonClick()
	{
	}

	[Token(Token = "0x6001260")]
	[Address(RVA = "0x14E2488", Offset = "0x14E2488", VA = "0x14E2488")]
	private void OnTransforgriffed(Transmogrif t)
	{
	}

	[Token(Token = "0x6001261")]
	[Address(RVA = "0x14E24A8", Offset = "0x14E24A8", VA = "0x14E24A8")]
	private void OnOverworldGoalHit(OverworldGoal g, Vector3 v, OverworldBall2D ball)
	{
	}

	[Token(Token = "0x6001262")]
	[Address(RVA = "0x14E24C8", Offset = "0x14E24C8", VA = "0x14E24C8")]
	private void OnGoalHit(string s)
	{
	}

	[Token(Token = "0x6001263")]
	[Address(RVA = "0x14E24E8", Offset = "0x14E24E8", VA = "0x14E24E8")]
	private void OnAimStart()
	{
	}

	[Token(Token = "0x6001264")]
	[Address(RVA = "0x14E2508", Offset = "0x14E2508", VA = "0x14E2508")]
	private void OnShootCanceled()
	{
	}

	[Token(Token = "0x6001265")]
	[Address(RVA = "0x14E2528", Offset = "0x14E2528", VA = "0x14E2528")]
	private void OnShoot(Vector3 v)
	{
	}

	[Token(Token = "0x6001266")]
	[Address(RVA = "0x14E252C", Offset = "0x14E252C", VA = "0x14E252C")]
	private void OnDoorOpen()
	{
	}

	[Token(Token = "0x6001267")]
	[Address(RVA = "0x14E254C", Offset = "0x14E254C", VA = "0x14E254C")]
	public IOSHapticsManager()
	{
	}
}
