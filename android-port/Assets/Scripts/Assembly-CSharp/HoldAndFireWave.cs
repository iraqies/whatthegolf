using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000687")]
public class HoldAndFireWave : FrogKingBaseWave
{
	[Token(Token = "0x2000688")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40E50", Offset = "0x40E50")]
	private sealed class _003CWaveRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40021EE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40021EF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40021F0")]
		[FieldOffset(Offset = "0x20")]
		public HoldAndFireWave _003C_003E4__this;

		[Token(Token = "0x40021F1")]
		[FieldOffset(Offset = "0x28")]
		public SHMUPFrogKing frogKing;

		[Token(Token = "0x40021F2")]
		[FieldOffset(Offset = "0x30")]
		private int _003Camount_003E5__2;

		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x34")]
		private int _003CgabPosition_003E5__3;

		[Token(Token = "0x40021F4")]
		[FieldOffset(Offset = "0x38")]
		private float _003Cx_003E5__4;

		[Token(Token = "0x40021F5")]
		[FieldOffset(Offset = "0x3C")]
		private float _003Ci_003E5__5;

		[Token(Token = "0x1700035B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001DE7")]
			[Address(RVA = "0x17BCD04", Offset = "0x17BCD04", VA = "0x17BCD04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700035C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001DE9")]
			[Address(RVA = "0x17BCD4C", Offset = "0x17BCD4C", VA = "0x17BCD4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001DE4")]
		[Address(RVA = "0x17BC798", Offset = "0x17BC798", VA = "0x17BC798")]
		[DebuggerHidden]
		public _003CWaveRoutine_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001DE5")]
		[Address(RVA = "0x17BC7C4", Offset = "0x17BC7C4", VA = "0x17BC7C4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001DE6")]
		[Address(RVA = "0x17BC7C8", Offset = "0x17BC7C8", VA = "0x17BC7C8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001DE7")]
		[Address(RVA = "0x17BCD04", Offset = "0x17BCD04", VA = "0x17BCD04", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001DE8")]
		[Address(RVA = "0x17BCD0C", Offset = "0x17BCD0C", VA = "0x17BCD0C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001DE9")]
		[Address(RVA = "0x17BCD4C", Offset = "0x17BCD4C", VA = "0x17BCD4C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000689")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40E60", Offset = "0x40E60")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x40021F6")]
		[FieldOffset(Offset = "0x10")]
		public GameObject tentacle;

		[Token(Token = "0x40021F7")]
		[FieldOffset(Offset = "0x18")]
		public Transform frog;

		[Token(Token = "0x40021F8")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x40021F9")]
		[FieldOffset(Offset = "0x30")]
		public HoldAndFireWave _003C_003E4__this;

		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0x17BC368", Offset = "0x17BC368", VA = "0x17BC368")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6001DEB")]
		[Address(RVA = "0x17BC370", Offset = "0x17BC370", VA = "0x17BC370")]
		internal void _003CTentacleLifeRoutine_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6001DEC")]
		[Address(RVA = "0x17BC3D4", Offset = "0x17BC3D4", VA = "0x17BC3D4")]
		internal void _003CTentacleLifeRoutine_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x200068A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40E70", Offset = "0x40E70")]
	private sealed class _003CTentacleLifeRoutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40021FC")]
		[FieldOffset(Offset = "0x20")]
		public GameObject tentacle;

		[Token(Token = "0x40021FD")]
		[FieldOffset(Offset = "0x28")]
		public Transform frog;

		[Token(Token = "0x40021FE")]
		[FieldOffset(Offset = "0x30")]
		public HoldAndFireWave _003C_003E4__this;

		[Token(Token = "0x40021FF")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		[Token(Token = "0x1700035D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001DF0")]
			[Address(RVA = "0x17BC748", Offset = "0x17BC748", VA = "0x17BC748", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700035E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001DF2")]
			[Address(RVA = "0x17BC790", Offset = "0x17BC790", VA = "0x17BC790", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001DED")]
		[Address(RVA = "0x17BC48C", Offset = "0x17BC48C", VA = "0x17BC48C")]
		[DebuggerHidden]
		public _003CTentacleLifeRoutine_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001DEE")]
		[Address(RVA = "0x17BC4B8", Offset = "0x17BC4B8", VA = "0x17BC4B8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001DEF")]
		[Address(RVA = "0x17BC4BC", Offset = "0x17BC4BC", VA = "0x17BC4BC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001DF0")]
		[Address(RVA = "0x17BC748", Offset = "0x17BC748", VA = "0x17BC748", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001DF1")]
		[Address(RVA = "0x17BC750", Offset = "0x17BC750", VA = "0x17BC750", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001DF2")]
		[Address(RVA = "0x17BC790", Offset = "0x17BC790", VA = "0x17BC790", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40021E1")]
	[FieldOffset(Offset = "0x48")]
	public List<GameObject> Prefabs;

	[Token(Token = "0x40021E2")]
	[FieldOffset(Offset = "0x50")]
	public string ChildNameToScale;

	[Token(Token = "0x40021E3")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 TentacleScaleMod;

	[Token(Token = "0x40021E4")]
	[FieldOffset(Offset = "0x60")]
	public float TentacleSpacing;

	[Token(Token = "0x40021E5")]
	[FieldOffset(Offset = "0x64")]
	public Vector2 TentacleDelay;

	[Token(Token = "0x40021E6")]
	[FieldOffset(Offset = "0x6C")]
	public float TentacleLife;

	[Token(Token = "0x40021E7")]
	[FieldOffset(Offset = "0x70")]
	public float WaveDuration;

	[Token(Token = "0x40021E8")]
	[FieldOffset(Offset = "0x74")]
	public float SpawnStartX;

	[Token(Token = "0x40021E9")]
	[FieldOffset(Offset = "0x78")]
	public float WaveSize;

	[Token(Token = "0x40021EA")]
	[FieldOffset(Offset = "0x7C")]
	public int GabSize;

	[Token(Token = "0x40021EB")]
	[FieldOffset(Offset = "0x80")]
	public float HoldTime;

	[Token(Token = "0x40021EC")]
	[FieldOffset(Offset = "0x84")]
	public float MoveSpeed;

	[Token(Token = "0x40021ED")]
	[FieldOffset(Offset = "0x88")]
	private List<GameObject> activeObjects;

	[Token(Token = "0x6001DDF")]
	[Address(RVA = "0x14CE814", Offset = "0x14CE814", VA = "0x14CE814", Slot = "4")]
	public override IEnumerator WaveRoutine(SHMUPFrogKing frogKing)
	{
		return null;
	}

	[Token(Token = "0x6001DE0")]
	[Address(RVA = "0x14CE88C", Offset = "0x14CE88C", VA = "0x14CE88C")]
	public Vector3 FindMidpoint(int amount, float z)
	{
		return default;
	}

	[Token(Token = "0x6001DE1")]
	[Address(RVA = "0x14CE8B4", Offset = "0x14CE8B4", VA = "0x14CE8B4", Slot = "5")]
	public override void OnSinkReset()
	{
	}

	[Token(Token = "0x6001DE2")]
	[Address(RVA = "0x14CEA6C", Offset = "0x14CEA6C", VA = "0x14CEA6C")]
	private IEnumerator TentacleLifeRoutine(GameObject tentacle, Transform frog)
	{
		return null;
	}

	[Token(Token = "0x6001DE3")]
	[Address(RVA = "0x14CEAF4", Offset = "0x14CEAF4", VA = "0x14CEAF4")]
	public HoldAndFireWave()
	{
	}
}
