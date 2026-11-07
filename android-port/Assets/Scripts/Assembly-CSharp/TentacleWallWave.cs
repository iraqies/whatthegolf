using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200068E")]
public class TentacleWallWave : FrogKingBaseWave
{
	[Token(Token = "0x200068F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40EA0", Offset = "0x40EA0")]
	private sealed class _003CWaveRoutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002221")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002222")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002223")]
		[FieldOffset(Offset = "0x20")]
		public TentacleWallWave _003C_003E4__this;

		[Token(Token = "0x4002224")]
		[FieldOffset(Offset = "0x28")]
		public SHMUPFrogKing frogKing;

		[Token(Token = "0x4002225")]
		[FieldOffset(Offset = "0x30")]
		private int _003Camount_003E5__2;

		[Token(Token = "0x4002226")]
		[FieldOffset(Offset = "0x34")]
		private int _003CgabPosition_003E5__3;

		[Token(Token = "0x4002227")]
		[FieldOffset(Offset = "0x38")]
		private float _003Cx_003E5__4;

		[Token(Token = "0x4002228")]
		[FieldOffset(Offset = "0x3C")]
		private float _003Ci_003E5__5;

		[Token(Token = "0x17000363")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E0B")]
			[Address(RVA = "0x1864A24", Offset = "0x1864A24", VA = "0x1864A24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000364")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E0D")]
			[Address(RVA = "0x1864A6C", Offset = "0x1864A6C", VA = "0x1864A6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x18644D8", Offset = "0x18644D8", VA = "0x18644D8")]
		[DebuggerHidden]
		public _003CWaveRoutine_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E09")]
		[Address(RVA = "0x1864504", Offset = "0x1864504", VA = "0x1864504", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0x1864508", Offset = "0x1864508", VA = "0x1864508", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E0B")]
		[Address(RVA = "0x1864A24", Offset = "0x1864A24", VA = "0x1864A24", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E0C")]
		[Address(RVA = "0x1864A2C", Offset = "0x1864A2C", VA = "0x1864A2C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0x1864A6C", Offset = "0x1864A6C", VA = "0x1864A6C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000690")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40EB0", Offset = "0x40EB0")]
	private sealed class _003CTentacleLifeRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002229")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400222A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400222B")]
		[FieldOffset(Offset = "0x20")]
		public TentacleWallWave _003C_003E4__this;

		[Token(Token = "0x400222C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject tentacle;

		[Token(Token = "0x17000365")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E11")]
			[Address(RVA = "0x1864488", Offset = "0x1864488", VA = "0x1864488", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000366")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E13")]
			[Address(RVA = "0x18644D0", Offset = "0x18644D0", VA = "0x18644D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0x1864360", Offset = "0x1864360", VA = "0x1864360")]
		[DebuggerHidden]
		public _003CTentacleLifeRoutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x186438C", Offset = "0x186438C", VA = "0x186438C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E10")]
		[Address(RVA = "0x1864390", Offset = "0x1864390", VA = "0x1864390", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E11")]
		[Address(RVA = "0x1864488", Offset = "0x1864488", VA = "0x1864488", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E12")]
		[Address(RVA = "0x1864490", Offset = "0x1864490", VA = "0x1864490", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E13")]
		[Address(RVA = "0x18644D0", Offset = "0x18644D0", VA = "0x18644D0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002216")]
	[FieldOffset(Offset = "0x48")]
	public List<GameObject> TentaclePrefabs;

	[Token(Token = "0x4002217")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 TentacleScaleMod;

	[Token(Token = "0x4002218")]
	[FieldOffset(Offset = "0x58")]
	public float TentacleSpacing;

	[Token(Token = "0x4002219")]
	[FieldOffset(Offset = "0x5C")]
	public Vector2 TentacleDelay;

	[Token(Token = "0x400221A")]
	[FieldOffset(Offset = "0x64")]
	public float TentacleLife;

	[Token(Token = "0x400221B")]
	[FieldOffset(Offset = "0x68")]
	public float WaveDuration;

	[Token(Token = "0x400221C")]
	[FieldOffset(Offset = "0x6C")]
	public float SpawnStartX;

	[Token(Token = "0x400221D")]
	[FieldOffset(Offset = "0x70")]
	public float WaveSize;

	[Token(Token = "0x400221E")]
	[FieldOffset(Offset = "0x74")]
	public int GabSize;

	[Token(Token = "0x400221F")]
	[FieldOffset(Offset = "0x78")]
	public string ChildNameToScale;

	[Token(Token = "0x4002220")]
	[FieldOffset(Offset = "0x80")]
	private List<GameObject> activeObjects;

	[Token(Token = "0x6001E03")]
	[Address(RVA = "0x170F628", Offset = "0x170F628", VA = "0x170F628", Slot = "4")]
	public override IEnumerator WaveRoutine(SHMUPFrogKing frogKing)
	{
		return null;
	}

	[Token(Token = "0x6001E04")]
	[Address(RVA = "0x170F6A0", Offset = "0x170F6A0", VA = "0x170F6A0")]
	public Vector3 FindMidpoint(int amount, float z)
	{
		return default;
	}

	[Token(Token = "0x6001E05")]
	[Address(RVA = "0x170F6C8", Offset = "0x170F6C8", VA = "0x170F6C8", Slot = "5")]
	public override void OnSinkReset()
	{
	}

	[Token(Token = "0x6001E06")]
	[Address(RVA = "0x170F880", Offset = "0x170F880", VA = "0x170F880")]
	private IEnumerator TentacleLifeRoutine(GameObject tentacle)
	{
		return null;
	}

	[Token(Token = "0x6001E07")]
	[Address(RVA = "0x170F8F8", Offset = "0x170F8F8", VA = "0x170F8F8")]
	public TentacleWallWave()
	{
	}
}
