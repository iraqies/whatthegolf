using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008B4")]
public class TrainCargoSpawner : MonoBehaviour
{
	[Token(Token = "0x20008B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41BB0", Offset = "0x41BB0")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4002FCC")]
		[FieldOffset(Offset = "0x10")]
		public float maxScale;

		[Token(Token = "0x4002FCD")]
		[FieldOffset(Offset = "0x18")]
		public Transform ballTransform;

		[Token(Token = "0x4002FCE")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 ballSpawnPosition;

		[Token(Token = "0x4002FCF")]
		[FieldOffset(Offset = "0x30")]
		public TrainCargoSpawner _003C_003E4__this;

		[Token(Token = "0x600282C")]
		[Address(RVA = "0x186A534", Offset = "0x186A534", VA = "0x186A534")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x600282D")]
		[Address(RVA = "0x186A53C", Offset = "0x186A53C", VA = "0x186A53C")]
		internal void _003CStart_003Eb__1(float t)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20008B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41BC0", Offset = "0x41BC0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002FD0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002FD1")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__8_0;

		[Token(Token = "0x600282F")]
		[Address(RVA = "0x186A4E4", Offset = "0x186A4E4", VA = "0x186A4E4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002830")]
		[Address(RVA = "0x186A4EC", Offset = "0x186A4EC", VA = "0x186A4EC")]
		internal void _003CStart_003Eb__8_0(AudioSource src)
		{
		}
	}

	[Token(Token = "0x20008B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41BD0", Offset = "0x41BD0")]
	private sealed class _003CStart_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002FD2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002FD3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002FD4")]
		[FieldOffset(Offset = "0x20")]
		public TrainCargoSpawner _003C_003E4__this;

		[Token(Token = "0x4002FD5")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

		[Token(Token = "0x4002FD6")]
		[FieldOffset(Offset = "0x30")]
		private Collider2D _003Ccollider_003E5__2;

		[Token(Token = "0x4002FD7")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody2D _003CballRigidbody_003E5__3;

		[Token(Token = "0x1700043C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002834")]
			[Address(RVA = "0x186ACB0", Offset = "0x186ACB0", VA = "0x186ACB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700043D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002836")]
			[Address(RVA = "0x186ACF8", Offset = "0x186ACF8", VA = "0x186ACF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002831")]
		[Address(RVA = "0x186A610", Offset = "0x186A610", VA = "0x186A610")]
		[DebuggerHidden]
		public _003CStart_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002832")]
		[Address(RVA = "0x186A63C", Offset = "0x186A63C", VA = "0x186A63C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002833")]
		[Address(RVA = "0x186A640", Offset = "0x186A640", VA = "0x186A640", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002834")]
		[Address(RVA = "0x186ACB0", Offset = "0x186ACB0", VA = "0x186ACB0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002835")]
		[Address(RVA = "0x186ACB8", Offset = "0x186ACB8", VA = "0x186ACB8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002836")]
		[Address(RVA = "0x186ACF8", Offset = "0x186ACF8", VA = "0x186ACF8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002FC4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject prefab;

	[Token(Token = "0x4002FC5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform spawnPosition;

	[Token(Token = "0x4002FC6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform activationPosition;

	[Token(Token = "0x4002FC7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float inflateDuration;

	[Token(Token = "0x4002FC8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform wagon;

	[Token(Token = "0x4002FC9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioClip inflateSound;

	[Token(Token = "0x4002FCA")]
	[FieldOffset(Offset = "0x48")]
	private bool isSpawning;

	[Token(Token = "0x4002FCB")]
	[FieldOffset(Offset = "0x4C")]
	private float smallSpawnLocalScale;

	[Token(Token = "0x600282A")]
	[Address(RVA = "0x17294C4", Offset = "0x17294C4", VA = "0x17294C4")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600282B")]
	[Address(RVA = "0x1729538", Offset = "0x1729538", VA = "0x1729538")]
	public TrainCargoSpawner()
	{
	}
}
