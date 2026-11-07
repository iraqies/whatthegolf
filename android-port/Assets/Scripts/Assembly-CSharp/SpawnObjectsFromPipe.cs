using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E32")]
public class SpawnObjectsFromPipe : MonoBehaviour
{
	[Token(Token = "0x2000E33")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44ED8", Offset = "0x44ED8")]
	private sealed class _003CSpawnCR_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004D0E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004D0F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004D10")]
		[FieldOffset(Offset = "0x20")]
		public SpawnObjectsFromPipe _003C_003E4__this;

		[Token(Token = "0x4004D11")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170006D7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600429B")]
			[Address(RVA = "0x18539A4", Offset = "0x18539A4", VA = "0x18539A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006D8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600429D")]
			[Address(RVA = "0x18539EC", Offset = "0x18539EC", VA = "0x18539EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004298")]
		[Address(RVA = "0x1853664", Offset = "0x1853664", VA = "0x1853664")]
		[DebuggerHidden]
		public _003CSpawnCR_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004299")]
		[Address(RVA = "0x1853690", Offset = "0x1853690", VA = "0x1853690", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600429A")]
		[Address(RVA = "0x1853694", Offset = "0x1853694", VA = "0x1853694", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600429B")]
		[Address(RVA = "0x18539A4", Offset = "0x18539A4", VA = "0x18539A4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600429C")]
		[Address(RVA = "0x18539AC", Offset = "0x18539AC", VA = "0x18539AC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600429D")]
		[Address(RVA = "0x18539EC", Offset = "0x18539EC", VA = "0x18539EC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004D05")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<GameObject> ObjectToSpawn;

	[Token(Token = "0x4004D06")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform PositionToSpawnFrom;

	[Token(Token = "0x4004D07")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float ejectForce;

	[Token(Token = "0x4004D08")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private ForceMode ejectForceMode;

	[Token(Token = "0x4004D09")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float ejectTorque;

	[Token(Token = "0x4004D0A")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int numberToSpawn;

	[Token(Token = "0x4004D0B")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 forceDirection;

	[Token(Token = "0x4004D0C")]
	[FieldOffset(Offset = "0x48")]
	private WaitForSeconds wait;

	[Token(Token = "0x4004D0D")]
	[FieldOffset(Offset = "0x50")]
	public float delay;

	[Token(Token = "0x6004295")]
	[Address(RVA = "0x16C8A64", Offset = "0x16C8A64", VA = "0x16C8A64")]
	public void Spawn()
	{
	}

	[Token(Token = "0x6004296")]
	[Address(RVA = "0x16C8AE0", Offset = "0x16C8AE0", VA = "0x16C8AE0")]
	private IEnumerator SpawnCR()
	{
		return null;
	}

	[Token(Token = "0x6004297")]
	[Address(RVA = "0x16C8B54", Offset = "0x16C8B54", VA = "0x16C8B54")]
	public SpawnObjectsFromPipe()
	{
	}
}
