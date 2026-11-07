using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000964")]
public class ChestManager : GolfBehaviour
{
	[Serializable]
	[Token(Token = "0x2000965")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42308", Offset = "0x42308")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400339C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400339D")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ChestTrophee, bool> _003C_003E9__8_0;

		[Token(Token = "0x6002BD5")]
		[Address(RVA = "0x17859D4", Offset = "0x17859D4", VA = "0x17859D4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002BD6")]
		[Address(RVA = "0x17859DC", Offset = "0x17859DC", VA = "0x17859DC")]
		internal bool _003Cget_OpenedChests_003Eb__8_0(ChestTrophee c)
		{
			return default;
		}
	}

	[Token(Token = "0x2000966")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42318", Offset = "0x42318")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x400339E")]
		[FieldOffset(Offset = "0x10")]
		public ChestTrophee trophee;

		[Token(Token = "0x400339F")]
		[FieldOffset(Offset = "0x18")]
		public ChestManager _003C_003E4__this;

		[Token(Token = "0x6002BD7")]
		[Address(RVA = "0x17859F8", Offset = "0x17859F8", VA = "0x17859F8")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6002BD8")]
		[Address(RVA = "0x1785A00", Offset = "0x1785A00", VA = "0x1785A00")]
		internal void _003CStart_003Eb__0(Chest c)
		{
		}
	}

	[Token(Token = "0x2000967")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42328", Offset = "0x42328")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x40033A0")]
		[FieldOffset(Offset = "0x10")]
		public ChestManager _003C_003E4__this;

		[Token(Token = "0x40033A1")]
		[FieldOffset(Offset = "0x18")]
		public ChestTrophee trophee;

		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x1785A28", Offset = "0x1785A28", VA = "0x1785A28")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6002BDA")]
		[Address(RVA = "0x1785A30", Offset = "0x1785A30", VA = "0x1785A30")]
		internal void _003CChest_OnChestPreOpen_003Eb__0(Chest c)
		{
		}

		[Token(Token = "0x6002BDB")]
		[Address(RVA = "0x1785A58", Offset = "0x1785A58", VA = "0x1785A58")]
		internal void _003CChest_OnChestPreOpen_003Eb__1(float t)
		{
		}

		[Token(Token = "0x6002BDC")]
		[Address(RVA = "0x1785A80", Offset = "0x1785A80", VA = "0x1785A80")]
		internal void _003CChest_OnChestPreOpen_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000968")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42338", Offset = "0x42338")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x40033A2")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 target;

		[Token(Token = "0x40033A3")]
		[FieldOffset(Offset = "0x20")]
		public OverworldBall2D ball;

		[Token(Token = "0x40033A4")]
		[FieldOffset(Offset = "0x28")]
		public ChestManager _003C_003E4__this;

		[Token(Token = "0x6002BDD")]
		[Address(RVA = "0x1785AAC", Offset = "0x1785AAC", VA = "0x1785AAC")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6002BDE")]
		[Address(RVA = "0x1785AB4", Offset = "0x1785AB4", VA = "0x1785AB4")]
		internal void _003COnOpenChestPost_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6002BDF")]
		[Address(RVA = "0x1785AF8", Offset = "0x1785AF8", VA = "0x1785AF8")]
		internal void _003COnOpenChestPost_003Eb__1(float t)
		{
		}

		[Token(Token = "0x6002BE0")]
		[Address(RVA = "0x1785B3C", Offset = "0x1785B3C", VA = "0x1785B3C")]
		internal void _003COnOpenChestPost_003Eb__2(float t)
		{
		}
	}

	[Token(Token = "0x2000969")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42348", Offset = "0x42348")]
	private sealed class _003C_003Ec__DisplayClass14_1
	{
		[Token(Token = "0x40033A5")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 portalPosition;

		[Token(Token = "0x40033A6")]
		[FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6002BE1")]
		[Address(RVA = "0x1785B6C", Offset = "0x1785B6C", VA = "0x1785B6C")]
		public _003C_003Ec__DisplayClass14_1()
		{
		}

		[Token(Token = "0x6002BE2")]
		[Address(RVA = "0x1785B74", Offset = "0x1785B74", VA = "0x1785B74")]
		internal void _003COnOpenChestPost_003Eb__3(float t)
		{
		}
	}

	[Token(Token = "0x200096A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42358", Offset = "0x42358")]
	private sealed class _003COnOpenChestPost_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40033A7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40033A8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40033A9")]
		[FieldOffset(Offset = "0x20")]
		public ChestManager _003C_003E4__this;

		[Token(Token = "0x40033AA")]
		[FieldOffset(Offset = "0x28")]
		public ChestTrophee trophee;

		[Token(Token = "0x40033AB")]
		[FieldOffset(Offset = "0x30")]
		public Chest chest;

		[Token(Token = "0x40033AC")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		[Token(Token = "0x40033AD")]
		[FieldOffset(Offset = "0x40")]
		private bool _003CisTeleportingBall_003E5__2;

		[Token(Token = "0x40033AE")]
		[FieldOffset(Offset = "0x48")]
		private OverworldBallFollower _003CproxyBall_003E5__3;

		[Token(Token = "0x1700048F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002BE6")]
			[Address(RVA = "0x17866B0", Offset = "0x17866B0", VA = "0x17866B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000490")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BE8")]
			[Address(RVA = "0x17866F8", Offset = "0x17866F8", VA = "0x17866F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002BE3")]
		[Address(RVA = "0x1785C60", Offset = "0x1785C60", VA = "0x1785C60")]
		[DebuggerHidden]
		public _003COnOpenChestPost_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002BE4")]
		[Address(RVA = "0x1785C8C", Offset = "0x1785C8C", VA = "0x1785C8C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002BE5")]
		[Address(RVA = "0x1785C90", Offset = "0x1785C90", VA = "0x1785C90", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002BE6")]
		[Address(RVA = "0x17866B0", Offset = "0x17866B0", VA = "0x17866B0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BE7")]
		[Address(RVA = "0x17866B8", Offset = "0x17866B8", VA = "0x17866B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002BE8")]
		[Address(RVA = "0x17866F8", Offset = "0x17866F8", VA = "0x17866F8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003394")]
	[FieldOffset(Offset = "0x20")]
	public Transmogrif grif;

	[Token(Token = "0x4003395")]
	[FieldOffset(Offset = "0x28")]
	public Transform tropheeCenter;

	[Token(Token = "0x4003396")]
	[FieldOffset(Offset = "0x30")]
	public OverworldCameraSettings cameraForOpeningChest;

	[Token(Token = "0x4003397")]
	[FieldOffset(Offset = "0x38")]
	public OverworldCameraSettings CameraSettingsForTeleport;

	[Token(Token = "0x4003398")]
	[FieldOffset(Offset = "0x40")]
	public bool isAlwaysTeleportingBall;

	[Token(Token = "0x4003399")]
	[FieldOffset(Offset = "0x48")]
	public List<ChestTrophee> allChestsTrophees;

	[Token(Token = "0x400339A")]
	[FieldOffset(Offset = "0x50")]
	public OverworldTriggerCameraBlender winAreaBlender;

	[Token(Token = "0x400339B")]
	[FieldOffset(Offset = "0x58")]
	private bool previousBallState;

	[Token(Token = "0x1700048E")]
	public int OpenedChests
	{
		[Token(Token = "0x6002BCD")]
		[Address(RVA = "0x189B72C", Offset = "0x189B72C", VA = "0x189B72C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6002BCE")]
	[Address(RVA = "0x189B860", Offset = "0x189B860", VA = "0x189B860", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002BCF")]
	[Address(RVA = "0x189B8C0", Offset = "0x189B8C0", VA = "0x189B8C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002BD0")]
	[Address(RVA = "0x189BFE4", Offset = "0x189BFE4", VA = "0x189BFE4")]
	private void Chest_OnChestPreOpen(ChestTrophee trophee, Chest chest)
	{
	}

	[Token(Token = "0x6002BD1")]
	[Address(RVA = "0x189C3AC", Offset = "0x189C3AC", VA = "0x189C3AC")]
	private void Chest_OnPostChestOpenFirst(ChestTrophee trophee, Chest chest)
	{
	}

	[Token(Token = "0x6002BD2")]
	[Address(RVA = "0x189C43C", Offset = "0x189C43C", VA = "0x189C43C")]
	private IEnumerator OnOpenChestPost(ChestTrophee trophee, Chest chest)
	{
		return null;
	}

	[Token(Token = "0x6002BD3")]
	[Address(RVA = "0x189C4C4", Offset = "0x189C4C4", VA = "0x189C4C4")]
	public ChestManager()
	{
	}
}
