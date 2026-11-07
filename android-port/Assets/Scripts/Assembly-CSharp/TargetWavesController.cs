using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000034")]
public class TargetWavesController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000035")]
	public class Wave
	{
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x10")]
		public List<SnowBallTargetBehaviour> Targets;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x18")]
		public bool StartsDisabled;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1861610", Offset = "0x1861610", VA = "0x1861610")]
		public Wave()
		{
		}
	}

	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D348", Offset = "0x3D348")]
	private sealed class _003CSetupNewWave_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x20")]
		public TargetWavesController _003C_003E4__this;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x1700002E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x18615C0", Offset = "0x18615C0", VA = "0x18615C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700002F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1861608", Offset = "0x1861608", VA = "0x1861608", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1861304", Offset = "0x1861304", VA = "0x1861304")]
		[DebuggerHidden]
		public _003CSetupNewWave_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1861330", Offset = "0x1861330", VA = "0x1861330", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1861334", Offset = "0x1861334", VA = "0x1861334", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x18615C0", Offset = "0x18615C0", VA = "0x18615C0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x18615C8", Offset = "0x18615C8", VA = "0x18615C8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1861608", Offset = "0x1861608", VA = "0x1861608", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x18")]
	public ClipSettingsCollection sfxOnClimbSpawn;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x20")]
	public List<Wave> Waves;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x28")]
	private Wave currentWave;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x16F7718", Offset = "0x16F7718", VA = "0x16F7718")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x16F784C", Offset = "0x16F784C", VA = "0x16F784C")]
	private void OnCollapsed(SnowBallTargetBehaviour snowBallTargetBehaviour)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x16F77D8", Offset = "0x16F77D8", VA = "0x16F77D8")]
	private IEnumerator SetupNewWave()
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x16F79D0", Offset = "0x16F79D0", VA = "0x16F79D0")]
	public TargetWavesController()
	{
	}
}
