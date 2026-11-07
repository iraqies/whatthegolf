using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200098F")]
public class OverworldRoomDoors : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000990")]
	public class DoorFlipFlopInfo
	{
		[Token(Token = "0x40034C2")]
		[FieldOffset(Offset = "0x10")]
		public OverworldButton2D door;

		[Token(Token = "0x40034C3")]
		[FieldOffset(Offset = "0x18")]
		public OverworldMainDoorPlate plate;

		[Token(Token = "0x40034C4")]
		[FieldOffset(Offset = "0x20")]
		public int offset;

		[Token(Token = "0x6002CD5")]
		[Address(RVA = "0x181CE60", Offset = "0x181CE60", VA = "0x181CE60")]
		public DoorFlipFlopInfo()
		{
		}
	}

	[Token(Token = "0x2000991")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42578", Offset = "0x42578")]
	private sealed class _003CStart_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40034C5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40034C6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40034C7")]
		[FieldOffset(Offset = "0x20")]
		public OverworldRoomDoors _003C_003E4__this;

		[Token(Token = "0x170004A8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CD9")]
			[Address(RVA = "0x181CE10", Offset = "0x181CE10", VA = "0x181CE10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004A9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CDB")]
			[Address(RVA = "0x181CE58", Offset = "0x181CE58", VA = "0x181CE58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002CD6")]
		[Address(RVA = "0x181CBC8", Offset = "0x181CBC8", VA = "0x181CBC8")]
		[DebuggerHidden]
		public _003CStart_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CD7")]
		[Address(RVA = "0x181CBF4", Offset = "0x181CBF4", VA = "0x181CBF4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CD8")]
		[Address(RVA = "0x181CBF8", Offset = "0x181CBF8", VA = "0x181CBF8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002CD9")]
		[Address(RVA = "0x181CE10", Offset = "0x181CE10", VA = "0x181CE10", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002CDA")]
		[Address(RVA = "0x181CE18", Offset = "0x181CE18", VA = "0x181CE18", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002CDB")]
		[Address(RVA = "0x181CE58", Offset = "0x181CE58", VA = "0x181CE58", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40034BE")]
	[FieldOffset(Offset = "0x18")]
	public List<DoorFlipFlopInfo> doors;

	[Token(Token = "0x40034BF")]
	[FieldOffset(Offset = "0x20")]
	public float interval;

	[Token(Token = "0x40034C0")]
	[FieldOffset(Offset = "0x24")]
	private float nextDoor;

	[Token(Token = "0x40034C1")]
	[FieldOffset(Offset = "0x28")]
	private int doorIndex;

	[Token(Token = "0x6002CD2")]
	[Address(RVA = "0x15CAAEC", Offset = "0x15CAAEC", VA = "0x15CAAEC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6002CD3")]
	[Address(RVA = "0x15CAB60", Offset = "0x15CAB60", VA = "0x15CAB60")]
	private void Update()
	{
	}

	[Token(Token = "0x6002CD4")]
	[Address(RVA = "0x15CAE08", Offset = "0x15CAE08", VA = "0x15CAE08")]
	public OverworldRoomDoors()
	{
	}
}
