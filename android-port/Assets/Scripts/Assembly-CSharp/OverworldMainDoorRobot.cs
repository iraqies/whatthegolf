using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Tilemaps;

[Token(Token = "0x2000984")]
public class OverworldMainDoorRobot : MonoBehaviour
{
	[Token(Token = "0x2000985")]
	public enum State
	{
		[Token(Token = "0x4003497")]
		Closed = 0,
		[Token(Token = "0x4003498")]
		Open = 1,
		[Token(Token = "0x4003499")]
		Completed = 2
	}

	[Token(Token = "0x2000986")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x424E8", Offset = "0x424E8")]
	private sealed class _003C_003Ec__DisplayClass62_0
	{
		[Token(Token = "0x400349A")]
		[FieldOffset(Offset = "0x10")]
		public OverworldMainDoorPlate plate;

		[Token(Token = "0x400349B")]
		[FieldOffset(Offset = "0x18")]
		public OverworldMainDoorRobot _003C_003E4__this;

		[Token(Token = "0x6002CA9")]
		[Address(RVA = "0x18145A4", Offset = "0x18145A4", VA = "0x18145A4")]
		public _003C_003Ec__DisplayClass62_0()
		{
		}

		[Token(Token = "0x6002CAA")]
		[Address(RVA = "0x18145AC", Offset = "0x18145AC", VA = "0x18145AC")]
		internal void _003CInitialize_003Eb__2(bool isOn, bool onload)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000987")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x424F8", Offset = "0x424F8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400349C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400349D")]
		[FieldOffset(Offset = "0x8")]
		public static Func<OverworldMainDoorPlate, bool> _003C_003E9__62_1;

		[Token(Token = "0x400349E")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<OverworldMainDoorPlate> _003C_003E9__62_3;

		[Token(Token = "0x400349F")]
		[FieldOffset(Offset = "0x18")]
		public static Converter<OverworldMainDoorPlate, Vector3> _003C_003E9__62_4;

		[Token(Token = "0x40034A0")]
		[FieldOffset(Offset = "0x20")]
		public static Func<OverworldMainDoorPlate, bool> _003C_003E9__63_0;

		[Token(Token = "0x6002CAC")]
		[Address(RVA = "0x18144C8", Offset = "0x18144C8", VA = "0x18144C8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002CAD")]
		[Address(RVA = "0x18144D0", Offset = "0x18144D0", VA = "0x18144D0")]
		internal bool _003CInitialize_003Eb__62_1(OverworldMainDoorPlate p)
		{
			return default;
		}

		[Token(Token = "0x6002CAE")]
		[Address(RVA = "0x1814540", Offset = "0x1814540", VA = "0x1814540")]
		internal bool _003CInitialize_003Eb__62_3(OverworldMainDoorPlate p)
		{
			return default;
		}

		[Token(Token = "0x6002CAF")]
		[Address(RVA = "0x1814560", Offset = "0x1814560", VA = "0x1814560")]
		internal Vector3 _003CInitialize_003Eb__62_4(OverworldMainDoorPlate p)
		{
			return default;
		}

		[Token(Token = "0x6002CB0")]
		[Address(RVA = "0x181458C", Offset = "0x181458C", VA = "0x181458C")]
		internal bool _003CCanBeOpened_003Eb__63_0(OverworldMainDoorPlate p)
		{
			return default;
		}
	}

	[Token(Token = "0x2000988")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42508", Offset = "0x42508")]
	private sealed class _003C_003Ec__DisplayClass64_0
	{
		[Token(Token = "0x40034A1")]
		[FieldOffset(Offset = "0x10")]
		public OverworldBall2D ball;

		[Token(Token = "0x40034A2")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x40034A3")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 endPosition;

		[Token(Token = "0x6002CB1")]
		[Address(RVA = "0x18146E0", Offset = "0x18146E0", VA = "0x18146E0")]
		public _003C_003Ec__DisplayClass64_0()
		{
		}

		[Token(Token = "0x6002CB2")]
		[Address(RVA = "0x18146E8", Offset = "0x18146E8", VA = "0x18146E8")]
		internal void _003CButtonRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000989")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42518", Offset = "0x42518")]
	private sealed class _003CButtonRoutine_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40034A4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40034A5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40034A6")]
		[FieldOffset(Offset = "0x20")]
		public OverworldMainDoorRobot _003C_003E4__this;

		[Token(Token = "0x40034A7")]
		[FieldOffset(Offset = "0x28")]
		public OverworldMainDoorPlate plate;

		[Token(Token = "0x40034A8")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass64_0 _003C_003E8__1;

		[Token(Token = "0x40034A9")]
		[FieldOffset(Offset = "0x38")]
		public bool isLastPlate;

		[Token(Token = "0x170004A0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CB6")]
			[Address(RVA = "0x1815140", Offset = "0x1815140", VA = "0x1815140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004A1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CB8")]
			[Address(RVA = "0x1815188", Offset = "0x1815188", VA = "0x1815188", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002CB3")]
		[Address(RVA = "0x1814ADC", Offset = "0x1814ADC", VA = "0x1814ADC")]
		[DebuggerHidden]
		public _003CButtonRoutine_003Ed__64(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CB4")]
		[Address(RVA = "0x1814B08", Offset = "0x1814B08", VA = "0x1814B08", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CB5")]
		[Address(RVA = "0x1814B0C", Offset = "0x1814B0C", VA = "0x1814B0C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002CB6")]
		[Address(RVA = "0x1815140", Offset = "0x1815140", VA = "0x1815140", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002CB7")]
		[Address(RVA = "0x1815148", Offset = "0x1815148", VA = "0x1815148", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002CB8")]
		[Address(RVA = "0x1815188", Offset = "0x1815188", VA = "0x1815188", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200098A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42528", Offset = "0x42528")]
	private sealed class _003C_003Ec__DisplayClass67_0
	{
		[Token(Token = "0x40034AA")]
		[FieldOffset(Offset = "0x10")]
		public OverworldMainDoorRobot _003C_003E4__this;

		[Token(Token = "0x40034AB")]
		[FieldOffset(Offset = "0x18")]
		public Camera mainCamera;

		[Token(Token = "0x40034AC")]
		[FieldOffset(Offset = "0x20")]
		public float startSize;

		[Token(Token = "0x40034AD")]
		[FieldOffset(Offset = "0x24")]
		public float targetSize;

		[Token(Token = "0x40034AE")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 startPosition;

		[Token(Token = "0x40034AF")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 targetPosition;

		[Token(Token = "0x6002CB9")]
		[Address(RVA = "0x1814788", Offset = "0x1814788", VA = "0x1814788")]
		public _003C_003Ec__DisplayClass67_0()
		{
		}

		[Token(Token = "0x6002CBA")]
		[Address(RVA = "0x1814790", Offset = "0x1814790", VA = "0x1814790")]
		internal void _003CStartLevelRoutine_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6002CBB")]
		[Address(RVA = "0x18147D8", Offset = "0x18147D8", VA = "0x18147D8")]
		internal void _003CStartLevelRoutine_003Eb__1(float t)
		{
		}

		[Token(Token = "0x6002CBC")]
		[Address(RVA = "0x18148A4", Offset = "0x18148A4", VA = "0x18148A4")]
		internal void _003CStartLevelRoutine_003Eb__2(bool didComplete)
		{
		}
	}

	[Token(Token = "0x200098B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42538", Offset = "0x42538")]
	private sealed class _003CStartLevelRoutine_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40034B0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40034B1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40034B2")]
		[FieldOffset(Offset = "0x20")]
		public OverworldMainDoorRobot _003C_003E4__this;

		[Token(Token = "0x40034B3")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass67_0 _003C_003E8__1;

		[Token(Token = "0x170004A2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CC0")]
			[Address(RVA = "0x1815D38", Offset = "0x1815D38", VA = "0x1815D38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004A3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CC2")]
			[Address(RVA = "0x1815D80", Offset = "0x1815D80", VA = "0x1815D80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002CBD")]
		[Address(RVA = "0x1815884", Offset = "0x1815884", VA = "0x1815884")]
		[DebuggerHidden]
		public _003CStartLevelRoutine_003Ed__67(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CBE")]
		[Address(RVA = "0x18158B0", Offset = "0x18158B0", VA = "0x18158B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CBF")]
		[Address(RVA = "0x18158B4", Offset = "0x18158B4", VA = "0x18158B4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002CC0")]
		[Address(RVA = "0x1815D38", Offset = "0x1815D38", VA = "0x1815D38", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002CC1")]
		[Address(RVA = "0x1815D40", Offset = "0x1815D40", VA = "0x1815D40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002CC2")]
		[Address(RVA = "0x1815D80", Offset = "0x1815D80", VA = "0x1815D80", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200098C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42548", Offset = "0x42548")]
	private sealed class _003C_003Ec__DisplayClass68_0
	{
		[Token(Token = "0x40034B4")]
		[FieldOffset(Offset = "0x10")]
		public AudioSource audioSource;

		[Token(Token = "0x6002CC3")]
		[Address(RVA = "0x1814A9C", Offset = "0x1814A9C", VA = "0x1814A9C")]
		public _003C_003Ec__DisplayClass68_0()
		{
		}

		[Token(Token = "0x6002CC4")]
		[Address(RVA = "0x1814AA4", Offset = "0x1814AA4", VA = "0x1814AA4")]
		internal void _003CFadeOut_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6002CC5")]
		[Address(RVA = "0x1814AC0", Offset = "0x1814AC0", VA = "0x1814AC0")]
		internal void _003CFadeOut_003Eb__1()
		{
		}
	}

	[Token(Token = "0x200098D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42558", Offset = "0x42558")]
	private sealed class _003CExplode_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40034B5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40034B6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40034B7")]
		[FieldOffset(Offset = "0x20")]
		public bool didComplete;

		[Token(Token = "0x40034B8")]
		[FieldOffset(Offset = "0x28")]
		public OverworldMainDoorRobot _003C_003E4__this;

		[Token(Token = "0x40034B9")]
		[FieldOffset(Offset = "0x30")]
		public float delayBeforeShake;

		[Token(Token = "0x40034BA")]
		[FieldOffset(Offset = "0x34")]
		public float delayBeforeExplosion;

		[Token(Token = "0x170004A4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CC9")]
			[Address(RVA = "0x1815834", Offset = "0x1815834", VA = "0x1815834", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004A5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CCB")]
			[Address(RVA = "0x181587C", Offset = "0x181587C", VA = "0x181587C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002CC6")]
		[Address(RVA = "0x181529C", Offset = "0x181529C", VA = "0x181529C")]
		[DebuggerHidden]
		public _003CExplode_003Ed__71(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CC7")]
		[Address(RVA = "0x18152C8", Offset = "0x18152C8", VA = "0x18152C8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CC8")]
		[Address(RVA = "0x18152CC", Offset = "0x18152CC", VA = "0x18152CC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002CC9")]
		[Address(RVA = "0x1815834", Offset = "0x1815834", VA = "0x1815834", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002CCA")]
		[Address(RVA = "0x181583C", Offset = "0x181583C", VA = "0x181583C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002CCB")]
		[Address(RVA = "0x181587C", Offset = "0x181587C", VA = "0x181587C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200098E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42568", Offset = "0x42568")]
	private sealed class _003CCheatingRoutine_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40034BB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40034BC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40034BD")]
		[FieldOffset(Offset = "0x20")]
		public OverworldMainDoorRobot _003C_003E4__this;

		[Token(Token = "0x170004A6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CCF")]
			[Address(RVA = "0x181524C", Offset = "0x181524C", VA = "0x181524C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004A7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CD1")]
			[Address(RVA = "0x1815294", Offset = "0x1815294", VA = "0x1815294", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002CCC")]
		[Address(RVA = "0x1815190", Offset = "0x1815190", VA = "0x1815190")]
		[DebuggerHidden]
		public _003CCheatingRoutine_003Ed__73(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CCD")]
		[Address(RVA = "0x18151BC", Offset = "0x18151BC", VA = "0x18151BC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CCE")]
		[Address(RVA = "0x18151C0", Offset = "0x18151C0", VA = "0x18151C0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002CCF")]
		[Address(RVA = "0x181524C", Offset = "0x181524C", VA = "0x181524C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002CD0")]
		[Address(RVA = "0x1815254", Offset = "0x1815254", VA = "0x1815254", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002CD1")]
		[Address(RVA = "0x1815294", Offset = "0x1815294", VA = "0x1815294", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003468")]
	[FieldOffset(Offset = "0x18")]
	public LevelData bossLevel;

	[Token(Token = "0x4003469")]
	[FieldOffset(Offset = "0x20")]
	public string bossLevelID;

	[Token(Token = "0x400346A")]
	[FieldOffset(Offset = "0x28")]
	public string bossLevelName;

	[Token(Token = "0x400346B")]
	[FieldOffset(Offset = "0x30")]
	public bool hasLevels;

	[Token(Token = "0x400346C")]
	[FieldOffset(Offset = "0x38")]
	public Action OnCompleted;

	[Token(Token = "0x400346D")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FCFC", Offset = "0x4FCFC")]
	private Action m_OnIsReady;

	[Token(Token = "0x400346E")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FD0C", Offset = "0x4FD0C")]
	private Action m_OnPlateChanged;

	[Token(Token = "0x400346F")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FD1C", Offset = "0x4FD1C")]
	private Action<OverworldMainDoorRobot> m_OnBallExitedAndIsExploding;

	[Token(Token = "0x4003470")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FD2C", Offset = "0x4FD2C")]
	private Action m_OnOpen;

	[Token(Token = "0x4003471")]
	[FieldOffset(Offset = "0x60")]
	public Transmogrif transmogrif;

	[Token(Token = "0x4003472")]
	[FieldOffset(Offset = "0x68")]
	public ShowSpeechbubbleOnHit speech;

	[Token(Token = "0x4003473")]
	[FieldOffset(Offset = "0x70")]
	public List<OverworldMainDoorPlate> plates;

	[Token(Token = "0x4003474")]
	[FieldOffset(Offset = "0x78")]
	public OverworldMainDoorButton button;

	[Token(Token = "0x4003475")]
	[FieldOffset(Offset = "0x80")]
	public GameObject hintArrow;

	[Token(Token = "0x4003476")]
	[FieldOffset(Offset = "0x88")]
	public Transform ballStartPosition;

	[Token(Token = "0x4003477")]
	[FieldOffset(Offset = "0x90")]
	public GameObject normalBase;

	[Token(Token = "0x4003478")]
	[FieldOffset(Offset = "0x98")]
	public GameObject normalColliders;

	[Token(Token = "0x4003479")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject destroyedBase;

	[Token(Token = "0x400347A")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject destroyedColliders;

	[Token(Token = "0x400347B")]
	[FieldOffset(Offset = "0xB0")]
	public List<ParticleSystem> particlesBeforeTakingOff;

	[Token(Token = "0x400347C")]
	[FieldOffset(Offset = "0xB8")]
	public Transform screenCenterTransform;

	[Token(Token = "0x400347D")]
	[FieldOffset(Offset = "0xC0")]
	public AudioSource srcBootingUp;

	[Token(Token = "0x400347E")]
	[FieldOffset(Offset = "0xC8")]
	public ClipSettingsCollection sfxShootOutBall;

	[Token(Token = "0x400347F")]
	[FieldOffset(Offset = "0xD0")]
	public ClipSettingsCollection sfxFirstButtonOn;

	[Token(Token = "0x4003480")]
	[FieldOffset(Offset = "0xD8")]
	public ClipSettingsCollection sfxFinalButtonOn;

	[Token(Token = "0x4003481")]
	[FieldOffset(Offset = "0xE0")]
	public ClipSettingsCollection explosionBuildupSFX;

	[Token(Token = "0x4003482")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string saveFormatUnlockedPlate;

	[Token(Token = "0x4003483")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string saveFormatCompleted;

	[Token(Token = "0x4003484")]
	[FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FD3C", Offset = "0x4FD3C")]
	private Action<OverworldMainDoorRobot> m_OnExitedCable;

	[Token(Token = "0x4003485")]
	[FieldOffset(Offset = "0x100")]
	public string notificationId;

	[Token(Token = "0x4003486")]
	[FieldOffset(Offset = "0x108")]
	private Tilemap tileMap;

	[Token(Token = "0x4003487")]
	[FieldOffset(Offset = "0x110")]
	private OverworldCamera overworldCamera;

	[Token(Token = "0x4003488")]
	[FieldOffset(Offset = "0x118")]
	private OverworldBall2D currentBall;

	[Token(Token = "0x4003489")]
	[FieldOffset(Offset = "0x120")]
	public Animator AnimatorFace;

	[Token(Token = "0x400348A")]
	[FieldOffset(Offset = "0x128")]
	public Animator AnimatorDoor;

	[Token(Token = "0x400348B")]
	[FieldOffset(Offset = "0x130")]
	public Explosion2D Explosion;

	[Token(Token = "0x400348C")]
	[FieldOffset(Offset = "0x138")]
	public Explosion2D[] ExplosionsSmall;

	[Token(Token = "0x400348D")]
	[FieldOffset(Offset = "0x140")]
	public State state;

	[Token(Token = "0x400348E")]
	[FieldOffset(Offset = "0x148")]
	private OverworldManager2d overworldManager;

	[Token(Token = "0x400348F")]
	[FieldOffset(Offset = "0x150")]
	private OverworldID overworldID;

	[Token(Token = "0x4003490")]
	[FieldOffset(Offset = "0x158")]
	private float lastActivationTime;

	[Token(Token = "0x4003491")]
	[FieldOffset(Offset = "0x15C")]
	private float activationCooldown;

	[Token(Token = "0x4003492")]
	[FieldOffset(Offset = "0x160")]
	private UnlockAchievement achievement;

	[Token(Token = "0x4003493")]
	[FieldOffset(Offset = "0x168")]
	private bool currentlyCheating;

	[Token(Token = "0x4003494")]
	[FieldOffset(Offset = "0x16C")]
	private float cheatUnlockTimer;

	[Token(Token = "0x4003495")]
	[FieldOffset(Offset = "0x170")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FD4C", Offset = "0x4FD4C")]
	private bool IsInitialized__BackingField;

	[Token(Token = "0x1700049F")]
	public bool IsInitialized
	{
		[Token(Token = "0x6002C96")]
		[Address(RVA = "0x15BE7EC", Offset = "0x15BE7EC", VA = "0x15BE7EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x680A4", Offset = "0x680A4")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002C97")]
		[Address(RVA = "0x15BE7F4", Offset = "0x15BE7F4", VA = "0x15BE7F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x680B4", Offset = "0x680B4")]
		private set
		{
		}
	}

	[Token(Token = "0x14000044")]
	public event Action OnIsReady
	{
		[Token(Token = "0x6002C8A")]
		[Address(RVA = "0x15BE0C4", Offset = "0x15BE0C4", VA = "0x15BE0C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68004", Offset = "0x68004")]
		add
		{
		}
		[Token(Token = "0x6002C8B")]
		[Address(RVA = "0x15BE168", Offset = "0x15BE168", VA = "0x15BE168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68014", Offset = "0x68014")]
		remove
		{
		}
	}

	[Token(Token = "0x14000045")]
	public event Action OnPlateChanged
	{
		[Token(Token = "0x6002C8C")]
		[Address(RVA = "0x15BE20C", Offset = "0x15BE20C", VA = "0x15BE20C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68024", Offset = "0x68024")]
		add
		{
		}
		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x15BE2B0", Offset = "0x15BE2B0", VA = "0x15BE2B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68034", Offset = "0x68034")]
		remove
		{
		}
	}

	[Token(Token = "0x14000046")]
	public event Action<OverworldMainDoorRobot> OnBallExitedAndIsExploding
	{
		[Token(Token = "0x6002C8E")]
		[Address(RVA = "0x15BE354", Offset = "0x15BE354", VA = "0x15BE354")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68044", Offset = "0x68044")]
		add
		{
		}
		[Token(Token = "0x6002C8F")]
		[Address(RVA = "0x15BE3F8", Offset = "0x15BE3F8", VA = "0x15BE3F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68054", Offset = "0x68054")]
		remove
		{
		}
	}

	[Token(Token = "0x14000047")]
	public event Action OnOpen
	{
		[Token(Token = "0x6002C90")]
		[Address(RVA = "0x15BE49C", Offset = "0x15BE49C", VA = "0x15BE49C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68064", Offset = "0x68064")]
		add
		{
		}
		[Token(Token = "0x6002C91")]
		[Address(RVA = "0x15BE540", Offset = "0x15BE540", VA = "0x15BE540")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68074", Offset = "0x68074")]
		remove
		{
		}
	}

	[Token(Token = "0x14000048")]
	public event Action<OverworldMainDoorRobot> OnExitedCable
	{
		[Token(Token = "0x6002C92")]
		[Address(RVA = "0x15BE5E4", Offset = "0x15BE5E4", VA = "0x15BE5E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68084", Offset = "0x68084")]
		add
		{
		}
		[Token(Token = "0x6002C93")]
		[Address(RVA = "0x15BE688", Offset = "0x15BE688", VA = "0x15BE688")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68094", Offset = "0x68094")]
		remove
		{
		}
	}

	[Token(Token = "0x6002C94")]
	[Address(RVA = "0x15BE72C", Offset = "0x15BE72C", VA = "0x15BE72C")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6002C95")]
	[Address(RVA = "0x15BE7D8", Offset = "0x15BE7D8", VA = "0x15BE7D8")]
	public bool IsOpen()
	{
		return default;
	}

	[Token(Token = "0x6002C98")]
	[Address(RVA = "0x15BE7FC", Offset = "0x15BE7FC", VA = "0x15BE7FC")]
	public void Initialize(OverworldManager2d overworldManager, Tilemap tilemap)
	{
	}

	[Token(Token = "0x6002C99")]
	[Address(RVA = "0x15BF24C", Offset = "0x15BF24C", VA = "0x15BF24C")]
	private bool CanBeOpened()
	{
		return default;
	}

	[Token(Token = "0x6002C9A")]
	[Address(RVA = "0x15BF59C", Offset = "0x15BF59C", VA = "0x15BF59C")]
	private IEnumerator ButtonRoutine(OverworldMainDoorPlate plate, bool isLastPlate)
	{
		return null;
	}

	[Token(Token = "0x6002C9B")]
	[Address(RVA = "0x15BF624", Offset = "0x15BF624", VA = "0x15BF624")]
	private void OnHitActiveButton(OverworldBall2D ball)
	{
	}

	[Token(Token = "0x6002C9C")]
	[Address(RVA = "0x15BF380", Offset = "0x15BF380", VA = "0x15BF380")]
	private void Change(State newState, bool forceChange = false)
	{
	}

	[Token(Token = "0x6002C9D")]
	[Address(RVA = "0x15BF6E0", Offset = "0x15BF6E0", VA = "0x15BF6E0")]
	private IEnumerator StartLevelRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002C9E")]
	[Address(RVA = "0x15BF754", Offset = "0x15BF754", VA = "0x15BF754")]
	private void FadeOut(AudioSource audioSource, float duration)
	{
	}

	[Token(Token = "0x6002C9F")]
	[Address(RVA = "0x15BF8D0", Offset = "0x15BF8D0", VA = "0x15BF8D0")]
	public bool IsCompleted()
	{
		return default;
	}

	[Token(Token = "0x6002CA0")]
	[Address(RVA = "0x15BF8E0", Offset = "0x15BF8E0", VA = "0x15BF8E0")]
	public void OpenDoor()
	{
	}

	[Token(Token = "0x6002CA1")]
	[Address(RVA = "0x15BF8EC", Offset = "0x15BF8EC", VA = "0x15BF8EC")]
	public IEnumerator Explode(bool didComplete, float delayBeforeShake = 1.8f, float delayBeforeExplosion = 2.2f)
	{
		return null;
	}

	[Token(Token = "0x6002CA2")]
	[Address(RVA = "0x15BF97C", Offset = "0x15BF97C", VA = "0x15BF97C")]
	public void SetCompleted()
	{
	}

	[Token(Token = "0x6002CA3")]
	[Address(RVA = "0x15BF988", Offset = "0x15BF988", VA = "0x15BF988")]
	private IEnumerator CheatingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002CA4")]
	[Address(RVA = "0x15BF9FC", Offset = "0x15BF9FC", VA = "0x15BF9FC")]
	public void OnMouseDown()
	{
	}

	[Token(Token = "0x6002CA5")]
	[Address(RVA = "0x15BFAE0", Offset = "0x15BFAE0", VA = "0x15BFAE0")]
	public void OnMouseExit()
	{
	}

	[Token(Token = "0x6002CA6")]
	[Address(RVA = "0x15BFAF8", Offset = "0x15BFAF8", VA = "0x15BFAF8")]
	public void OnMouseUp()
	{
	}

	[Token(Token = "0x6002CA7")]
	[Address(RVA = "0x15BFB04", Offset = "0x15BFB04", VA = "0x15BFB04")]
	public OverworldMainDoorRobot()
	{
	}

	[Token(Token = "0x6002CA8")]
	[Address(RVA = "0x15BFB94", Offset = "0x15BFB94", VA = "0x15BFB94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x680C4", Offset = "0x680C4")]
	private void _003CInitialize_003Eb__62_0(OverworldBall2D ball)
	{
	}
}
