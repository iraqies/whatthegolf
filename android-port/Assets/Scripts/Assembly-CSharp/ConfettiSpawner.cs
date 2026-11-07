using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000598")]
public class ConfettiSpawner : MonoBehaviour, IAudioEvent
{
	[Token(Token = "0x2000599")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40780", Offset = "0x40780")]
	private sealed class _003CPopulatePool_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001CA0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001CA1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001CA2")]
		[FieldOffset(Offset = "0x20")]
		public ConfettiSpawner _003C_003E4__this;

		[Token(Token = "0x4001CA3")]
		[FieldOffset(Offset = "0x28")]
		private Transform _003Ctrans_003E5__2;

		[Token(Token = "0x4001CA4")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x170002C7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001987")]
			[Address(RVA = "0x178F2F8", Offset = "0x178F2F8", VA = "0x178F2F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002C8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001989")]
			[Address(RVA = "0x178F340", Offset = "0x178F340", VA = "0x178F340", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001984")]
		[Address(RVA = "0x178F018", Offset = "0x178F018", VA = "0x178F018")]
		[DebuggerHidden]
		public _003CPopulatePool_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001985")]
		[Address(RVA = "0x178F044", Offset = "0x178F044", VA = "0x178F044", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001986")]
		[Address(RVA = "0x178F048", Offset = "0x178F048", VA = "0x178F048", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001987")]
		[Address(RVA = "0x178F2F8", Offset = "0x178F2F8", VA = "0x178F2F8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001988")]
		[Address(RVA = "0x178F300", Offset = "0x178F300", VA = "0x178F300", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001989")]
		[Address(RVA = "0x178F340", Offset = "0x178F340", VA = "0x178F340", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200059A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40790", Offset = "0x40790")]
	private sealed class _003CConfettiRoutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001CA5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001CA6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001CA7")]
		[FieldOffset(Offset = "0x20")]
		public ConfettiSpawner _003C_003E4__this;

		[Token(Token = "0x4001CA8")]
		[FieldOffset(Offset = "0x28")]
		public bool isCrown;

		[Token(Token = "0x4001CA9")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 pos;

		[Token(Token = "0x4001CAA")]
		[FieldOffset(Offset = "0x38")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170002C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600198D")]
			[Address(RVA = "0x178EFC8", Offset = "0x178EFC8", VA = "0x178EFC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600198F")]
			[Address(RVA = "0x178F010", Offset = "0x178F010", VA = "0x178F010", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600198A")]
		[Address(RVA = "0x178EE9C", Offset = "0x178EE9C", VA = "0x178EE9C")]
		[DebuggerHidden]
		public _003CConfettiRoutine_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600198B")]
		[Address(RVA = "0x178EEC8", Offset = "0x178EEC8", VA = "0x178EEC8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600198C")]
		[Address(RVA = "0x178EECC", Offset = "0x178EECC", VA = "0x178EECC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600198D")]
		[Address(RVA = "0x178EFC8", Offset = "0x178EFC8", VA = "0x178EFC8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600198E")]
		[Address(RVA = "0x178EFD0", Offset = "0x178EFD0", VA = "0x178EFD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600198F")]
		[Address(RVA = "0x178F010", Offset = "0x178F010", VA = "0x178F010", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001C93")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Confetti confettiPrefab;

	[Token(Token = "0x4001C94")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int amount;

	[Token(Token = "0x4001C95")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<AudioClip> confettiShootSounds;

	[Token(Token = "0x4001C96")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private OverworldCamera overworldCam;

	[Token(Token = "0x4001C97")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool alwaysPlay;

	[Token(Token = "0x4001C98")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ClipSettingsCollection confettiLayerOne;

	[Token(Token = "0x4001C99")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ClipSettingsCollection confettiLayerTwo;

	[Token(Token = "0x4001C9A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ClipSettingsCollection crownLayerOne;

	[Token(Token = "0x4001C9B")]
	[FieldOffset(Offset = "0x58")]
	private Queue<Confetti> spawnedConfetti;

	[Token(Token = "0x4001C9C")]
	[FieldOffset(Offset = "0x60")]
	private int maxConfettiCount;

	[Token(Token = "0x4001C9D")]
	[FieldOffset(Offset = "0x64")]
	private int innerAmount;

	[Token(Token = "0x4001C9E")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine confettiSpawnRoutine;

	[Token(Token = "0x4001C9F")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4DE3C", Offset = "0x4DE3C")]
	private Action<Vector3> OnAudioEvent__BackingField;

	[Token(Token = "0x170002C6")]
	public Action<Vector3> OnAudioEvent
	{
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x18AB750", Offset = "0x18AB750", VA = "0x18AB750", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63464", Offset = "0x63464")]
		get
		{
			return null;
		}
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x18AB758", Offset = "0x18AB758", VA = "0x18AB758", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63474", Offset = "0x63474")]
		set
		{
		}
	}

	[Token(Token = "0x600197B")]
	[Address(RVA = "0x18AB760", Offset = "0x18AB760", VA = "0x18AB760")]
	private void Awake()
	{
	}

	[Token(Token = "0x600197C")]
	[Address(RVA = "0x18AB7E8", Offset = "0x18AB7E8", VA = "0x18AB7E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600197D")]
	[Address(RVA = "0x18AB920", Offset = "0x18AB920", VA = "0x18AB920")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600197E")]
	[Address(RVA = "0x18AB8AC", Offset = "0x18AB8AC", VA = "0x18AB8AC")]
	private IEnumerator PopulatePool()
	{
		return null;
	}

	[Token(Token = "0x600197F")]
	[Address(RVA = "0x189B64C", Offset = "0x189B64C", VA = "0x189B64C")]
	public void RemoteSpawn(Vector3 position, bool isCrown)
	{
	}

	[Token(Token = "0x6001980")]
	[Address(RVA = "0x18AB928", Offset = "0x18AB928", VA = "0x18AB928")]
	private IEnumerator ConfettiRoutine(Vector3 pos, bool isCrown)
	{
		return null;
	}

	[Token(Token = "0x6001981")]
	[Address(RVA = "0x18AB9C8", Offset = "0x18AB9C8", VA = "0x18AB9C8")]
	public void PlayConfettiSound(bool isCrown)
	{
	}

	[Token(Token = "0x6001982")]
	[Address(RVA = "0x18ABBC0", Offset = "0x18ABBC0", VA = "0x18ABBC0")]
	public void SpawnConfetti(Vector3 position)
	{
	}

	[Token(Token = "0x6001983")]
	[Address(RVA = "0x18ABD38", Offset = "0x18ABD38", VA = "0x18ABD38")]
	public ConfettiSpawner()
	{
	}
}
