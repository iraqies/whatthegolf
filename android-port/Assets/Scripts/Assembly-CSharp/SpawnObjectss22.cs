using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EAA")]
public class SpawnObjectss22 : MonoBehaviour
{
	[Token(Token = "0x2000EAB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45240", Offset = "0x45240")]
	private sealed class _003CSpawnCR_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004F36")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004F37")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004F38")]
		[FieldOffset(Offset = "0x20")]
		public SpawnObjectss22 _003C_003E4__this;

		[Token(Token = "0x4004F39")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17000708")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600447A")]
			[Address(RVA = "0x1853CC0", Offset = "0x1853CC0", VA = "0x1853CC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000709")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600447C")]
			[Address(RVA = "0x1853D08", Offset = "0x1853D08", VA = "0x1853D08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004477")]
		[Address(RVA = "0x18539F4", Offset = "0x18539F4", VA = "0x18539F4")]
		[DebuggerHidden]
		public _003CSpawnCR_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004478")]
		[Address(RVA = "0x1853A20", Offset = "0x1853A20", VA = "0x1853A20", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004479")]
		[Address(RVA = "0x1853A24", Offset = "0x1853A24", VA = "0x1853A24", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600447A")]
		[Address(RVA = "0x1853CC0", Offset = "0x1853CC0", VA = "0x1853CC0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600447B")]
		[Address(RVA = "0x1853CC8", Offset = "0x1853CC8", VA = "0x1853CC8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600447C")]
		[Address(RVA = "0x1853D08", Offset = "0x1853D08", VA = "0x1853D08", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004F30")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<GameObject> ObjectToSpawn;

	[Token(Token = "0x4004F31")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Transform> PositionsToSpawnFrom;

	[Token(Token = "0x4004F32")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float ejectForce;

	[Token(Token = "0x4004F33")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float ejectTouqe;

	[Token(Token = "0x4004F34")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int numberToSpawn;

	[Token(Token = "0x4004F35")]
	[FieldOffset(Offset = "0x38")]
	private WaitForSeconds wait;

	[Token(Token = "0x6004474")]
	[Address(RVA = "0x16C8BCC", Offset = "0x16C8BCC", VA = "0x16C8BCC")]
	public void Spawn()
	{
	}

	[Token(Token = "0x6004475")]
	[Address(RVA = "0x16C8C48", Offset = "0x16C8C48", VA = "0x16C8C48")]
	private IEnumerator SpawnCR()
	{
		return null;
	}

	[Token(Token = "0x6004476")]
	[Address(RVA = "0x16C8CBC", Offset = "0x16C8CBC", VA = "0x16C8CBC")]
	public SpawnObjectss22()
	{
	}
}
