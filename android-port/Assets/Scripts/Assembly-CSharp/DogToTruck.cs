using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002EF")]
public class DogToTruck : MonoBehaviour
{
	[Token(Token = "0x20002F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ED7C", Offset = "0x3ED7C")]
	private sealed class _003CAddTwoWheels_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001041")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001042")]
		[FieldOffset(Offset = "0x20")]
		public DogToTruck _003C_003E4__this;

		[Token(Token = "0x4001043")]
		[FieldOffset(Offset = "0x28")]
		public int i;

		[Token(Token = "0x1700019C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D93")]
			[Address(RVA = "0x179CCF4", Offset = "0x179CCF4", VA = "0x179CCF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700019D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D95")]
			[Address(RVA = "0x179CD3C", Offset = "0x179CD3C", VA = "0x179CD3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x179CB68", Offset = "0x179CB68", VA = "0x179CB68")]
		[DebuggerHidden]
		public _003CAddTwoWheels_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x179CB94", Offset = "0x179CB94", VA = "0x179CB94", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x179CB98", Offset = "0x179CB98", VA = "0x179CB98", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x179CCF4", Offset = "0x179CCF4", VA = "0x179CCF4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x179CCFC", Offset = "0x179CCFC", VA = "0x179CCFC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x179CD3C", Offset = "0x179CD3C", VA = "0x179CD3C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20002F1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ED8C", Offset = "0x3ED8C")]
	private sealed class _003CToTruck_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001044")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001045")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x20")]
		public DogToTruck _003C_003E4__this;

		[Token(Token = "0x1700019E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D99")]
			[Address(RVA = "0x179D00C", Offset = "0x179D00C", VA = "0x179D00C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700019F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D9B")]
			[Address(RVA = "0x179D054", Offset = "0x179D054", VA = "0x179D054", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x179CD44", Offset = "0x179CD44", VA = "0x179CD44")]
		[DebuggerHidden]
		public _003CToTruck_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x179CD70", Offset = "0x179CD70", VA = "0x179CD70", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x179CD74", Offset = "0x179CD74", VA = "0x179CD74", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x179D00C", Offset = "0x179D00C", VA = "0x179D00C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x179D014", Offset = "0x179D014", VA = "0x179D014", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x179D054", Offset = "0x179D054", VA = "0x179D054", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20002F2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ED9C", Offset = "0x3ED9C")]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		[Token(Token = "0x4001047")]
		[FieldOffset(Offset = "0x10")]
		public DogToTruck _003C_003E4__this;

		[Token(Token = "0x4001048")]
		[FieldOffset(Offset = "0x18")]
		public int i;

		[Token(Token = "0x4001049")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 startScale;

		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x179CA58", Offset = "0x179CA58", VA = "0x179CA58")]
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x179CA60", Offset = "0x179CA60", VA = "0x179CA60")]
		internal void _003CAddWheel_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4001034")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> Objects;

	[Token(Token = "0x4001036")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int shotsBeforeWheels;

	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ClipSettingsCollection mySfx;

	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0x38")]
	private int numShots;

	[Token(Token = "0x4001039")]
	[FieldOffset(Offset = "0x3C")]
	private int index;

	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject truck;

	[Token(Token = "0x400103B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Vector3 ForceOnWheelsAdded;

	[Token(Token = "0x400103C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private CBFollow FollowCam;

	[Token(Token = "0x400103D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private CBFollow FollowCamDesktop;

	[Token(Token = "0x400103E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ParticleSystem poofParticles;

	[Token(Token = "0x400103F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool AddWheelsOnShoot;

	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x142FDE4", Offset = "0x142FDE4", VA = "0x142FDE4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x142FE94", Offset = "0x142FE94", VA = "0x142FE94")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x142FF44", Offset = "0x142FF44", VA = "0x142FF44")]
	public void Next()
	{
	}

	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x143016C", Offset = "0x143016C", VA = "0x143016C")]
	private void Controller_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x143007C", Offset = "0x143007C", VA = "0x143007C")]
	private IEnumerator AddTwoWheels(int i)
	{
		return null;
	}

	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x14300F8", Offset = "0x14300F8", VA = "0x14300F8")]
	private IEnumerator ToTruck(Vector3 obj)
	{
		return null;
	}

	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x143032C", Offset = "0x143032C", VA = "0x143032C")]
	private void AddWheel(int i)
	{
	}

	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x14304E4", Offset = "0x14304E4", VA = "0x14304E4")]
	public DogToTruck()
	{
	}
}
