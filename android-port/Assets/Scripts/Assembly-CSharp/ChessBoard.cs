using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006B5")]
public class ChessBoard : MonoBehaviour
{
	[Token(Token = "0x20006B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41010", Offset = "0x41010")]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[Token(Token = "0x4002330")]
		[FieldOffset(Offset = "0x10")]
		public ChessPiece piece;

		[Token(Token = "0x4002331")]
		[FieldOffset(Offset = "0x18")]
		public ChessBoard _003C_003E4__this;

		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x17836E0", Offset = "0x17836E0", VA = "0x17836E0")]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x17836E8", Offset = "0x17836E8", VA = "0x17836E8")]
		internal bool _003CStartMoving_003Eb__1(Vector2 m)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x20006B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41020", Offset = "0x41020")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002332")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002333")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ChessPiece, bool> _003C_003E9__29_0;

		[Token(Token = "0x4002334")]
		[FieldOffset(Offset = "0x10")]
		public static Func<ChessPiece, bool> _003C_003E9__29_2;

		[Token(Token = "0x6001EFF")]
		[Address(RVA = "0x178361C", Offset = "0x178361C", VA = "0x178361C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001F00")]
		[Address(RVA = "0x1783624", Offset = "0x1783624", VA = "0x1783624")]
		internal bool _003CStartMoving_003Eb__29_0(ChessPiece c)
		{
			return default;
		}

		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x1783688", Offset = "0x1783688", VA = "0x1783688")]
		internal bool _003CStartMoving_003Eb__29_2(ChessPiece c)
		{
			return default;
		}
	}

	[Token(Token = "0x20006B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41030", Offset = "0x41030")]
	private sealed class _003CStartMoving_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002335")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002336")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002337")]
		[FieldOffset(Offset = "0x20")]
		public ChessBoard _003C_003E4__this;

		[Token(Token = "0x4002338")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 _003Cmove_003E5__2;

		[Token(Token = "0x4002339")]
		[FieldOffset(Offset = "0x30")]
		private ChessPiece _003Cp_003E5__3;

		[Token(Token = "0x1700038D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F05")]
			[Address(RVA = "0x17846DC", Offset = "0x17846DC", VA = "0x17846DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700038E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001F07")]
			[Address(RVA = "0x1784724", Offset = "0x1784724", VA = "0x1784724", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x1783D50", Offset = "0x1783D50", VA = "0x1783D50")]
		[DebuggerHidden]
		public _003CStartMoving_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F03")]
		[Address(RVA = "0x1783D7C", Offset = "0x1783D7C", VA = "0x1783D7C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F04")]
		[Address(RVA = "0x1783D80", Offset = "0x1783D80", VA = "0x1783D80", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001F05")]
		[Address(RVA = "0x17846DC", Offset = "0x17846DC", VA = "0x17846DC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001F06")]
		[Address(RVA = "0x17846E4", Offset = "0x17846E4", VA = "0x17846E4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001F07")]
		[Address(RVA = "0x1784724", Offset = "0x1784724", VA = "0x1784724", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41040", Offset = "0x41040")]
	private sealed class _003CStartMovingPlayer_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400233A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400233B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400233C")]
		[FieldOffset(Offset = "0x20")]
		public ChessBoard _003C_003E4__this;

		[Token(Token = "0x400233D")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 dest;

		[Token(Token = "0x1700038F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F0B")]
			[Address(RVA = "0x17848F0", Offset = "0x17848F0", VA = "0x17848F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000390")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001F0D")]
			[Address(RVA = "0x1784938", Offset = "0x1784938", VA = "0x1784938", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001F08")]
		[Address(RVA = "0x178472C", Offset = "0x178472C", VA = "0x178472C")]
		[DebuggerHidden]
		public _003CStartMovingPlayer_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F09")]
		[Address(RVA = "0x1784758", Offset = "0x1784758", VA = "0x1784758", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F0A")]
		[Address(RVA = "0x178475C", Offset = "0x178475C", VA = "0x178475C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001F0B")]
		[Address(RVA = "0x17848F0", Offset = "0x17848F0", VA = "0x17848F0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001F0C")]
		[Address(RVA = "0x17848F8", Offset = "0x17848F8", VA = "0x17848F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001F0D")]
		[Address(RVA = "0x1784938", Offset = "0x1784938", VA = "0x1784938", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006BA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41050", Offset = "0x41050")]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x400233E")]
		[FieldOffset(Offset = "0x10")]
		public Transform hand;

		[Token(Token = "0x400233F")]
		[FieldOffset(Offset = "0x18")]
		public bool isPlayerHand;

		[Token(Token = "0x4002340")]
		[FieldOffset(Offset = "0x20")]
		public Transform p;

		[Token(Token = "0x6001F0E")]
		[Address(RVA = "0x178374C", Offset = "0x178374C", VA = "0x178374C")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}
	}

	[Token(Token = "0x20006BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41060", Offset = "0x41060")]
	private sealed class _003C_003Ec__DisplayClass40_1
	{
		[Token(Token = "0x4002341")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 start;

		[Token(Token = "0x4002342")]
		[FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0x1783754", Offset = "0x1783754", VA = "0x1783754")]
		public _003C_003Ec__DisplayClass40_1()
		{
		}

		[Token(Token = "0x6001F10")]
		[Address(RVA = "0x178375C", Offset = "0x178375C", VA = "0x178375C")]
		internal void _003CMoveHandToPiece_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20006BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41070", Offset = "0x41070")]
	private sealed class _003C_003Ec__DisplayClass40_2
	{
		[Token(Token = "0x4002343")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 start;

		[Token(Token = "0x4002344")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4002345")]
		[FieldOffset(Offset = "0x28")]
		public _003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x6001F11")]
		[Address(RVA = "0x1783824", Offset = "0x1783824", VA = "0x1783824")]
		public _003C_003Ec__DisplayClass40_2()
		{
		}

		[Token(Token = "0x6001F12")]
		[Address(RVA = "0x178382C", Offset = "0x178382C", VA = "0x178382C")]
		internal void _003CMoveHandToPiece_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x20006BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41080", Offset = "0x41080")]
	private sealed class _003CMoveHandToPiece_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002346")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002347")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002348")]
		[FieldOffset(Offset = "0x20")]
		public bool isPlayerHand;

		[Token(Token = "0x4002349")]
		[FieldOffset(Offset = "0x28")]
		public Transform p;

		[Token(Token = "0x400234A")]
		[FieldOffset(Offset = "0x30")]
		public ChessBoard _003C_003E4__this;

		[Token(Token = "0x400234B")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass40_2 _003C_003E8__1;

		[Token(Token = "0x17000391")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F16")]
			[Address(RVA = "0x1783D00", Offset = "0x1783D00", VA = "0x1783D00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000392")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001F18")]
			[Address(RVA = "0x1783D48", Offset = "0x1783D48", VA = "0x1783D48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001F13")]
		[Address(RVA = "0x1783924", Offset = "0x1783924", VA = "0x1783924")]
		[DebuggerHidden]
		public _003CMoveHandToPiece_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F14")]
		[Address(RVA = "0x1783950", Offset = "0x1783950", VA = "0x1783950", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F15")]
		[Address(RVA = "0x1783954", Offset = "0x1783954", VA = "0x1783954", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x1783D00", Offset = "0x1783D00", VA = "0x1783D00", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x1783D08", Offset = "0x1783D08", VA = "0x1783D08", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x1783D48", Offset = "0x1783D48", VA = "0x1783D48", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002319")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 BoardSize;

	[Token(Token = "0x400231A")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 CellSize;

	[Token(Token = "0x400231B")]
	[FieldOffset(Offset = "0x28")]
	public float CellPadding;

	[Token(Token = "0x400231C")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<Vector2, ChessPiece> BoardCells;

	[Token(Token = "0x400231D")]
	[FieldOffset(Offset = "0x38")]
	public bool Test;

	[Token(Token = "0x400231E")]
	[FieldOffset(Offset = "0x40")]
	public Transform Hand;

	[Token(Token = "0x400231F")]
	[FieldOffset(Offset = "0x48")]
	public Transform PlayerHand;

	[Token(Token = "0x4002320")]
	[FieldOffset(Offset = "0x50")]
	public Transform SmashHand;

	[Token(Token = "0x4002321")]
	[FieldOffset(Offset = "0x58")]
	public Transform PlayerBasket;

	[Token(Token = "0x4002322")]
	[FieldOffset(Offset = "0x60")]
	public Transform ComputerBasket;

	[Token(Token = "0x4002323")]
	[FieldOffset(Offset = "0x68")]
	public ParticleSystem MoveParticles;

	[Token(Token = "0x4002324")]
	[FieldOffset(Offset = "0x70")]
	public bool AlwaysChooseWinningMove;

	[Token(Token = "0x4002325")]
	[FieldOffset(Offset = "0x71")]
	public bool LockKingIfPlayerCanTakeHim;

	[Token(Token = "0x4002326")]
	[FieldOffset(Offset = "0x74")]
	public float MoveSpeed;

	[Token(Token = "0x4002327")]
	[FieldOffset(Offset = "0x78")]
	public RandomAudioClips DiscardEndSFX;

	[Token(Token = "0x4002328")]
	[FieldOffset(Offset = "0x80")]
	public RandomAudioClips DiscardStartClips;

	[Token(Token = "0x4002329")]
	[FieldOffset(Offset = "0x88")]
	public RandomAudioClips MoveClips;

	[Token(Token = "0x400232A")]
	[FieldOffset(Offset = "0x90")]
	private List<ChessPiece> chessPieces;

	[Token(Token = "0x400232B")]
	[FieldOffset(Offset = "0x98")]
	private GolfBallController controller;

	[Token(Token = "0x400232C")]
	[FieldOffset(Offset = "0xA0")]
	private ChessPiece playerPiece;

	[Token(Token = "0x400232D")]
	[FieldOffset(Offset = "0xA8")]
	private GolfBallShooterExperimental shooter;

	[Token(Token = "0x400232E")]
	[FieldOffset(Offset = "0xB0")]
	private bool levelHasBeenCompleted;

	[Token(Token = "0x400232F")]
	[FieldOffset(Offset = "0xB1")]
	private bool gameOver;

	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0x1898C54", Offset = "0x1898C54", VA = "0x1898C54")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EE9")]
	[Address(RVA = "0x18992C8", Offset = "0x18992C8", VA = "0x18992C8")]
	private void InstanceOnOnLevelComplete(Level.CompletedState s)
	{
	}

	[Token(Token = "0x6001EEA")]
	[Address(RVA = "0x18992D4", Offset = "0x18992D4", VA = "0x18992D4")]
	private void ControllerOnOnAimUpdate(Vector3 boost, bool isCancelled)
	{
	}

	[Token(Token = "0x6001EEB")]
	[Address(RVA = "0x189983C", Offset = "0x189983C", VA = "0x189983C")]
	private void Controller_OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6001EEC")]
	[Address(RVA = "0x1899500", Offset = "0x1899500", VA = "0x1899500")]
	private Vector2 GetCellFromBoost(Vector3 boost)
	{
		return default;
	}

	[Token(Token = "0x6001EED")]
	[Address(RVA = "0x1899B88", Offset = "0x1899B88", VA = "0x1899B88")]
	private void Update()
	{
	}

	[Token(Token = "0x6001EEE")]
	[Address(RVA = "0x1899C24", Offset = "0x1899C24", VA = "0x1899C24")]
	private IEnumerator StartMoving()
	{
		return null;
	}

	[Token(Token = "0x6001EEF")]
	[Address(RVA = "0x1899998", Offset = "0x1899998", VA = "0x1899998")]
	private IEnumerator StartMovingPlayer(Vector2 dest)
	{
		return null;
	}

	[Token(Token = "0x6001EF0")]
	[Address(RVA = "0x1899C98", Offset = "0x1899C98", VA = "0x1899C98")]
	public void RestartLevel()
	{
	}

	[Token(Token = "0x6001EF1")]
	[Address(RVA = "0x1899A20", Offset = "0x1899A20", VA = "0x1899A20")]
	public bool IsCellFree(Vector2 pos, Transform owner, bool canClaimPiece = true)
	{
		return default;
	}

	[Token(Token = "0x6001EF2")]
	[Address(RVA = "0x1899D04", Offset = "0x1899D04", VA = "0x1899D04")]
	public ChessPiece GetPieceAt(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6001EF3")]
	[Address(RVA = "0x1899DB4", Offset = "0x1899DB4", VA = "0x1899DB4")]
	public void RegisterDiscard(Vector2 pieceAt)
	{
	}

	[Token(Token = "0x6001EF4")]
	[Address(RVA = "0x1899ED0", Offset = "0x1899ED0", VA = "0x1899ED0")]
	public void PlayMoveSFX(Vector3 pos)
	{
	}

	[Token(Token = "0x6001EF5")]
	[Address(RVA = "0x1899EEC", Offset = "0x1899EEC", VA = "0x1899EEC")]
	public void PlayDiscardStartSFX(Vector3 pos)
	{
	}

	[Token(Token = "0x6001EF6")]
	[Address(RVA = "0x1899F08", Offset = "0x1899F08", VA = "0x1899F08")]
	public void PlayDiscardEndSFX(Vector3 pos)
	{
	}

	[Token(Token = "0x6001EF7")]
	[Address(RVA = "0x1899F24", Offset = "0x1899F24", VA = "0x1899F24")]
	public bool RegisterMove(Vector3 from, Vector3 to, ChessPiece p)
	{
		return default;
	}

	[Token(Token = "0x6001EF8")]
	[Address(RVA = "0x1899218", Offset = "0x1899218", VA = "0x1899218")]
	public Vector3 CellToWorldPos(Vector2 cell)
	{
		return default;
	}

	[Token(Token = "0x6001EF9")]
	[Address(RVA = "0x1899FD4", Offset = "0x1899FD4", VA = "0x1899FD4")]
	public IEnumerator MoveHandToPiece(Transform p, bool isPlayerHand)
	{
		return null;
	}

	[Token(Token = "0x6001EFA")]
	[Address(RVA = "0x189A05C", Offset = "0x189A05C", VA = "0x189A05C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6001EFB")]
	[Address(RVA = "0x189A1B8", Offset = "0x189A1B8", VA = "0x189A1B8")]
	public ChessBoard()
	{
	}
}
