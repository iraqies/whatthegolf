using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000831")]
public class SuperGolfCannon : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000832")]
	public class MuzzleGroup
	{
		[Token(Token = "0x4002C36")]
		[FieldOffset(Offset = "0x10")]
		public SuperGolfCannonMuzzle[] Muzzles;

		[Token(Token = "0x4002C37")]
		[FieldOffset(Offset = "0x18")]
		public float postDelay;

		[Token(Token = "0x4002C38")]
		[FieldOffset(Offset = "0x1C")]
		public bool gunEnabled;

		[Token(Token = "0x60025B4")]
		[Address(RVA = "0x185C7F8", Offset = "0x185C7F8", VA = "0x185C7F8")]
		public MuzzleGroup()
		{
		}
	}

	[Token(Token = "0x2000833")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x418B8", Offset = "0x418B8")]
	private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002C39")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002C3A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002C3B")]
		[FieldOffset(Offset = "0x20")]
		public SuperGolfCannon _003C_003E4__this;

		[Token(Token = "0x4002C3C")]
		[FieldOffset(Offset = "0x28")]
		private MuzzleGroup[] _003C_003E7__wrap1;

		[Token(Token = "0x4002C3D")]
		[FieldOffset(Offset = "0x30")]
		private int _003C_003E7__wrap2;

		[Token(Token = "0x4002C3E")]
		[FieldOffset(Offset = "0x38")]
		private MuzzleGroup _003Cgroup_003E5__4;

		[Token(Token = "0x17000412")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60025B8")]
			[Address(RVA = "0x185C7A8", Offset = "0x185C7A8", VA = "0x185C7A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000413")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60025BA")]
			[Address(RVA = "0x185C7F0", Offset = "0x185C7F0", VA = "0x185C7F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60025B5")]
		[Address(RVA = "0x185C384", Offset = "0x185C384", VA = "0x185C384")]
		[DebuggerHidden]
		public _003CStart_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60025B6")]
		[Address(RVA = "0x185C3B0", Offset = "0x185C3B0", VA = "0x185C3B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60025B7")]
		[Address(RVA = "0x185C3B4", Offset = "0x185C3B4", VA = "0x185C3B4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60025B8")]
		[Address(RVA = "0x185C7A8", Offset = "0x185C7A8", VA = "0x185C7A8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60025B9")]
		[Address(RVA = "0x185C7B0", Offset = "0x185C7B0", VA = "0x185C7B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60025BA")]
		[Address(RVA = "0x185C7F0", Offset = "0x185C7F0", VA = "0x185C7F0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002C2E")]
	[FieldOffset(Offset = "0x18")]
	private float nextSoundTime;

	[Token(Token = "0x4002C2F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MuzzleGroup[] muzzleGroups;

	[Token(Token = "0x4002C30")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject bulletPrefab;

	[Token(Token = "0x4002C31")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Timeline timeline;

	[Token(Token = "0x4002C32")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<AudioClip> shootClips;

	[Token(Token = "0x4002C33")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float soundCooldown;

	[Token(Token = "0x4002C34")]
	[FieldOffset(Offset = "0x48")]
	public ObjectPool<GameObject> bulletPool;

	[Token(Token = "0x4002C35")]
	[FieldOffset(Offset = "0x50")]
	private float timer;

	[Token(Token = "0x60025AF")]
	[Address(RVA = "0x16E95B8", Offset = "0x16E95B8", VA = "0x16E95B8")]
	private void OnBulletDeath(SuperGolfBullet bullet)
	{
	}

	[Token(Token = "0x60025B0")]
	[Address(RVA = "0x16E9634", Offset = "0x16E9634", VA = "0x16E9634")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60025B1")]
	[Address(RVA = "0x16E96A8", Offset = "0x16E96A8", VA = "0x16E96A8")]
	public SuperGolfCannon()
	{
	}

	[Token(Token = "0x60025B2")]
	[Address(RVA = "0x16E96B0", Offset = "0x16E96B0", VA = "0x16E96B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x669D0", Offset = "0x669D0")]
	private void _003CStart_003Eb__10_0(GameObject go)
	{
	}

	[Token(Token = "0x60025B3")]
	[Address(RVA = "0x16E97E0", Offset = "0x16E97E0", VA = "0x16E97E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x669E0", Offset = "0x669E0")]
	private void _003CStart_003Eb__10_1(AudioSource t)
	{
	}
}
