using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000F01")]
public class DicePrize : MonoBehaviour
{
	[Token(Token = "0x2000F02")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45620", Offset = "0x45620")]
	private sealed class _003CWaitForDiceZeroVelocity_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005112")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005113")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005114")]
		[FieldOffset(Offset = "0x20")]
		public DicePrize _003C_003E4__this;

		[Token(Token = "0x1700074A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004631")]
			[Address(RVA = "0x179C11C", Offset = "0x179C11C", VA = "0x179C11C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700074B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004633")]
			[Address(RVA = "0x179C164", Offset = "0x179C164", VA = "0x179C164", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600462E")]
		[Address(RVA = "0x179BF78", Offset = "0x179BF78", VA = "0x179BF78")]
		[DebuggerHidden]
		public _003CWaitForDiceZeroVelocity_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600462F")]
		[Address(RVA = "0x179BFA4", Offset = "0x179BFA4", VA = "0x179BFA4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004630")]
		[Address(RVA = "0x179BFA8", Offset = "0x179BFA8", VA = "0x179BFA8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004631")]
		[Address(RVA = "0x179C11C", Offset = "0x179C11C", VA = "0x179C11C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004632")]
		[Address(RVA = "0x179C124", Offset = "0x179C124", VA = "0x179C124", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004633")]
		[Address(RVA = "0x179C164", Offset = "0x179C164", VA = "0x179C164", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000F03")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45630", Offset = "0x45630")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4005115")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4005116")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Transform, float> _003C_003E9__12_0;

		[Token(Token = "0x6004635")]
		[Address(RVA = "0x179BC58", Offset = "0x179BC58", VA = "0x179BC58")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6004636")]
		[Address(RVA = "0x179BC60", Offset = "0x179BC60", VA = "0x179BC60")]
		internal float _003CCheckDiceValue_003Eb__12_0(Transform d)
		{
			return default;
		}
	}

	[Token(Token = "0x2000F04")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45640", Offset = "0x45640")]
	private sealed class _003CSpawnCR_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005117")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005118")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005119")]
		[FieldOffset(Offset = "0x20")]
		public DicePrize _003C_003E4__this;

		[Token(Token = "0x400511A")]
		[FieldOffset(Offset = "0x28")]
		public int num;

		[Token(Token = "0x400511B")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x1700074C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600463A")]
			[Address(RVA = "0x179BF28", Offset = "0x179BF28", VA = "0x179BF28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700074D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600463C")]
			[Address(RVA = "0x179BF70", Offset = "0x179BF70", VA = "0x179BF70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004637")]
		[Address(RVA = "0x179BC94", Offset = "0x179BC94", VA = "0x179BC94")]
		[DebuggerHidden]
		public _003CSpawnCR_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004638")]
		[Address(RVA = "0x179BCC0", Offset = "0x179BCC0", VA = "0x179BCC0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004639")]
		[Address(RVA = "0x179BCC4", Offset = "0x179BCC4", VA = "0x179BCC4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600463A")]
		[Address(RVA = "0x179BF28", Offset = "0x179BF28", VA = "0x179BF28", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600463B")]
		[Address(RVA = "0x179BF30", Offset = "0x179BF30", VA = "0x179BF30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600463C")]
		[Address(RVA = "0x179BF70", Offset = "0x179BF70", VA = "0x179BF70", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4005109")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<GameObject> Prefabs;

	[Token(Token = "0x400510A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Transform> DiceSides;

	[Token(Token = "0x400510B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody rb;

	[Token(Token = "0x400510C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform spawnPosition;

	[Token(Token = "0x400510D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ParticleSystem poof;

	[Token(Token = "0x400510E")]
	[FieldOffset(Offset = "0x40")]
	private List<GameObject> Spawned;

	[Token(Token = "0x400510F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float waitBetweenSpawn;

	[Token(Token = "0x4005110")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float randomPos;

	[Token(Token = "0x4005111")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UnityEvent OnSpawn;

	[Token(Token = "0x6004626")]
	[Address(RVA = "0x18DC4D4", Offset = "0x18DC4D4", VA = "0x18DC4D4")]
	public static Vector3 RandomPointInBounds(Bounds bounds)
	{
		return default;
	}

	[Token(Token = "0x6004627")]
	[Address(RVA = "0x18DC590", Offset = "0x18DC590", VA = "0x18DC590")]
	public void StartCheck()
	{
	}

	[Token(Token = "0x6004628")]
	[Address(RVA = "0x18DC614", Offset = "0x18DC614", VA = "0x18DC614")]
	private IEnumerator WaitForDiceZeroVelocity()
	{
		return null;
	}

	[Token(Token = "0x6004629")]
	[Address(RVA = "0x18DC688", Offset = "0x18DC688", VA = "0x18DC688")]
	private void CheckDiceValue()
	{
	}

	[Token(Token = "0x600462A")]
	[Address(RVA = "0x18DC818", Offset = "0x18DC818", VA = "0x18DC818")]
	private void Spawn(int num)
	{
	}

	[Token(Token = "0x600462B")]
	[Address(RVA = "0x18DC8AC", Offset = "0x18DC8AC", VA = "0x18DC8AC")]
	private IEnumerator SpawnCR(int num)
	{
		return null;
	}

	[Token(Token = "0x600462C")]
	[Address(RVA = "0x18DC928", Offset = "0x18DC928", VA = "0x18DC928")]
	public DicePrize()
	{
	}

	[Token(Token = "0x600462D")]
	[Address(RVA = "0x18DC940", Offset = "0x18DC940", VA = "0x18DC940")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E814", Offset = "0x6E814")]
	private bool _003CWaitForDiceZeroVelocity_003Eb__11_0()
	{
		return default;
	}
}
