using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200028D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3E804", Offset = "0x3E804")]
public class OverworldOLDoor : MonoBehaviour
{
	[Token(Token = "0x200028E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E86C", Offset = "0x3E86C")]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[Token(Token = "0x4000D8E")]
		[FieldOffset(Offset = "0x10")]
		public OverworldOLDoor _003C_003E4__this;

		[Token(Token = "0x4000D8F")]
		[FieldOffset(Offset = "0x18")]
		public bool hasDuration;

		[Token(Token = "0x4000D90")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 direction;

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x181BFD4", Offset = "0x181BFD4", VA = "0x181BFD4")]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x181BFDC", Offset = "0x181BFDC", VA = "0x181BFDC")]
		internal void _003COpenDoorRoutine_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x181C13C", Offset = "0x181C13C", VA = "0x181C13C")]
		internal void _003COpenDoorRoutine_003Eb__1()
		{
		}
	}

	[Token(Token = "0x200028F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E87C", Offset = "0x3E87C")]
	private sealed class _003COpenDoorRoutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000D91")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000D92")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000D93")]
		[FieldOffset(Offset = "0x20")]
		public OverworldOLDoor _003C_003E4__this;

		[Token(Token = "0x4000D94")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 direction;

		[Token(Token = "0x4000D95")]
		[FieldOffset(Offset = "0x30")]
		public float duration;

		[Token(Token = "0x4000D96")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

		[Token(Token = "0x4000D97")]
		[FieldOffset(Offset = "0x40")]
		public Action onOpen;

		[Token(Token = "0x17000167")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x181C838", Offset = "0x181C838", VA = "0x181C838", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000168")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x181C880", Offset = "0x181C880", VA = "0x181C880", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x181C284", Offset = "0x181C284", VA = "0x181C284")]
		[DebuggerHidden]
		public _003COpenDoorRoutine_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x181C2B0", Offset = "0x181C2B0", VA = "0x181C2B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x181C2B4", Offset = "0x181C2B4", VA = "0x181C2B4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x181C838", Offset = "0x181C838", VA = "0x181C838", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x181C840", Offset = "0x181C840", VA = "0x181C840", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x181C880", Offset = "0x181C880", VA = "0x181C880", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000D74")]
	[FieldOffset(Offset = "0x18")]
	public Transform door;

	[Token(Token = "0x4000D75")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody2D trophy;

	[Token(Token = "0x4000D76")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer trophyRender;

	[Token(Token = "0x4000D77")]
	[FieldOffset(Offset = "0x30")]
	public Collider2D trophyCollider;

	[Token(Token = "0x4000D78")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Button;

	[Token(Token = "0x4000D79")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer doorSide;

	[Token(Token = "0x4000D7A")]
	[FieldOffset(Offset = "0x48")]
	public SpriteRenderer doorTop;

	[Token(Token = "0x4000D7B")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4000D7C")]
	[FieldOffset(Offset = "0x58")]
	public float RoutineLength;

	[Token(Token = "0x4000D7D")]
	[FieldOffset(Offset = "0x5C")]
	public float DoorExtend;

	[Token(Token = "0x4000D7E")]
	[FieldOffset(Offset = "0x60")]
	public GameObject DoorSides;

	[Token(Token = "0x4000D7F")]
	[FieldOffset(Offset = "0x68")]
	public List<Collider2D> Colliders;

	[Token(Token = "0x4000D80")]
	[FieldOffset(Offset = "0x70")]
	public bool DebugThisDoor;

	[Token(Token = "0x4000D81")]
	[FieldOffset(Offset = "0x78")]
	public Vector3[] corners;

	[Token(Token = "0x4000D82")]
	[FieldOffset(Offset = "0x80")]
	public float BallDistanceThreshold;

	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x84")]
	public float Speed;

	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0x88")]
	public float Magnitude;

	[Token(Token = "0x4000D85")]
	[FieldOffset(Offset = "0x8C")]
	public bool canPlaySound;

	[Token(Token = "0x4000D86")]
	[FieldOffset(Offset = "0x90")]
	public PlayClipOnAudioEvent SFX;

	[Token(Token = "0x4000D87")]
	[FieldOffset(Offset = "0x98")]
	private OverworldCamera cam;

	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 doorStart;

	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0xAC")]
	public float trophyPushForce;

	[Token(Token = "0x4000D8A")]
	[FieldOffset(Offset = "0xB0")]
	public float trophyPushTorque;

	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0xB8")]
	public PlantParticles openParticles;

	[NonSerialized]
	[Token(Token = "0x4000D8C")]
	[FieldOffset(Offset = "0xC0")]
	public OverworldID overworldID;

	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0xC8")]
	private bool isOpening;

	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0x15C7BBC", Offset = "0x15C7BBC", VA = "0x15C7BBC")]
	public void SetCamera(OverworldCamera overworldCamera)
	{
	}

	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0x15C6A64", Offset = "0x15C6A64", VA = "0x15C6A64")]
	public void Init()
	{
	}

	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0x15C6C08", Offset = "0x15C6C08", VA = "0x15C6C08")]
	public void OpenDoor(Action onOpen, Vector2 direction, bool instant = false)
	{
	}

	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0x15C7BC4", Offset = "0x15C7BC4", VA = "0x15C7BC4")]
	public IEnumerator OpenDoorRoutine(Action onOpen, Vector2 direction, float duration, bool playEndSounds = true)
	{
		return null;
	}

	[Token(Token = "0x6000BAB")]
	[Address(RVA = "0x15C7C64", Offset = "0x15C7C64", VA = "0x15C7C64")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x15C7E40", Offset = "0x15C7E40", VA = "0x15C7E40")]
	public void RemoveButton()
	{
	}

	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x15C7E60", Offset = "0x15C7E60", VA = "0x15C7E60")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x15C813C", Offset = "0x15C813C", VA = "0x15C813C")]
	public OverworldOLDoor()
	{
	}
}
