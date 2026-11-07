using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007EE")]
public class TrafficLight : MonoBehaviour
{
	[Token(Token = "0x20007EF")]
	public enum LightId
	{
		[Token(Token = "0x4002A94")]
		red = 0,
		[Token(Token = "0x4002A95")]
		yellow = 1,
		[Token(Token = "0x4002A96")]
		green = 2,
		[Token(Token = "0x4002A97")]
		none = 3
	}

	[Token(Token = "0x20007F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x416E0", Offset = "0x416E0")]
	private sealed class _003CStart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002A98")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002A99")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002A9A")]
		[FieldOffset(Offset = "0x20")]
		public TrafficLight _003C_003E4__this;

		[Token(Token = "0x170003F9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002475")]
			[Address(RVA = "0x186A13C", Offset = "0x186A13C", VA = "0x186A13C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003FA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002477")]
			[Address(RVA = "0x186A184", Offset = "0x186A184", VA = "0x186A184", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002472")]
		[Address(RVA = "0x1869BD4", Offset = "0x1869BD4", VA = "0x1869BD4")]
		[DebuggerHidden]
		public _003CStart_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002473")]
		[Address(RVA = "0x1869C00", Offset = "0x1869C00", VA = "0x1869C00", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002474")]
		[Address(RVA = "0x1869C04", Offset = "0x1869C04", VA = "0x1869C04", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002475")]
		[Address(RVA = "0x186A13C", Offset = "0x186A13C", VA = "0x186A13C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002476")]
		[Address(RVA = "0x186A144", Offset = "0x186A144", VA = "0x186A144", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002477")]
		[Address(RVA = "0x186A184", Offset = "0x186A184", VA = "0x186A184", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002A88")]
	[FieldOffset(Offset = "0x18")]
	public Renderer[] lights;

	[Token(Token = "0x4002A89")]
	[FieldOffset(Offset = "0x20")]
	public Color[] onColors;

	[Token(Token = "0x4002A8A")]
	[FieldOffset(Offset = "0x28")]
	public Color[] offColors;

	[Token(Token = "0x4002A8B")]
	[FieldOffset(Offset = "0x30")]
	public GolfBallController Player;

	[Token(Token = "0x4002A8C")]
	[FieldOffset(Offset = "0x38")]
	public List<GolfBallController> Opponents;

	[Token(Token = "0x4002A8D")]
	[FieldOffset(Offset = "0x40")]
	public float StartDelay;

	[Token(Token = "0x4002A8E")]
	[FieldOffset(Offset = "0x44")]
	public float TimeBetweenShifts;

	[Token(Token = "0x4002A8F")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip SwitchClip;

	[Token(Token = "0x4002A90")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip GoClip;

	[Token(Token = "0x4002A91")]
	[FieldOffset(Offset = "0x58")]
	public LightId onLight;

	[Token(Token = "0x4002A92")]
	[FieldOffset(Offset = "0x5C")]
	public float lerpSpeed;

	[Token(Token = "0x600246E")]
	[Address(RVA = "0x1722CE8", Offset = "0x1722CE8", VA = "0x1722CE8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600246F")]
	[Address(RVA = "0x1722D5C", Offset = "0x1722D5C", VA = "0x1722D5C")]
	private bool IsBlocking()
	{
		return default;
	}

	[Token(Token = "0x6002470")]
	[Address(RVA = "0x1722D64", Offset = "0x1722D64", VA = "0x1722D64")]
	private void Update()
	{
	}

	[Token(Token = "0x6002471")]
	[Address(RVA = "0x1722F24", Offset = "0x1722F24", VA = "0x1722F24")]
	public TrafficLight()
	{
	}
}
