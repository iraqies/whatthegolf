using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002CA")]
public class AnimateInOnEnable : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20002CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EC6C", Offset = "0x3EC6C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000F47")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0x8")]
		public static Action<GameObject> _003C_003E9__13_0;

		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x10")]
		public static Action<GameObject> _003C_003E9__15_0;

		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x176AC18", Offset = "0x176AC18", VA = "0x176AC18")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x176AC20", Offset = "0x176AC20", VA = "0x176AC20")]
		internal void _003CAwake_003Eb__13_0(GameObject g)
		{
		}

		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x176AC40", Offset = "0x176AC40", VA = "0x176AC40")]
		internal void _003CAnimateIn_003Eb__15_0(GameObject g)
		{
		}
	}

	[Token(Token = "0x20002CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EC7C", Offset = "0x3EC7C")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x10")]
		public GameObject g;

		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 end;

		[Token(Token = "0x4000F4C")]
		[FieldOffset(Offset = "0x28")]
		public AnimateInOnEnable _003C_003E4__this;

		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0x176AC60", Offset = "0x176AC60", VA = "0x176AC60")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x176AC68", Offset = "0x176AC68", VA = "0x176AC68")]
		internal void _003CAnimateIn_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x20002CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EC8C", Offset = "0x3EC8C")]
	private sealed class _003CAnimateIn_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F4D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F4E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F4F")]
		[FieldOffset(Offset = "0x20")]
		public AnimateInOnEnable _003C_003E4__this;

		[Token(Token = "0x4000F50")]
		[FieldOffset(Offset = "0x28")]
		private int _003Cindx_003E5__2;

		[Token(Token = "0x4000F51")]
		[FieldOffset(Offset = "0x30")]
		private List<GameObject>.Enumerator _003C_003E7__wrap2;

		[Token(Token = "0x17000188")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000CDB")]
			[Address(RVA = "0x176B36C", Offset = "0x176B36C", VA = "0x176B36C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000189")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x176B3B4", Offset = "0x176B3B4", VA = "0x176B3B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x176AD48", Offset = "0x176AD48", VA = "0x176AD48")]
		[DebuggerHidden]
		public _003CAnimateIn_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x176AD74", Offset = "0x176AD74", VA = "0x176AD74", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x176AE48", Offset = "0x176AE48", VA = "0x176AE48", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x176ADEC", Offset = "0x176ADEC", VA = "0x176ADEC")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x176B36C", Offset = "0x176B36C", VA = "0x176B36C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x176B374", Offset = "0x176B374", VA = "0x176B374", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x176B3B4", Offset = "0x176B3B4", VA = "0x176B3B4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000F39")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float DurationMax;

	[Token(Token = "0x4000F3A")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float DurationMin;

	[Token(Token = "0x4000F3B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 Delay;

	[Token(Token = "0x4000F3C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float Stagger;

	[Token(Token = "0x4000F3D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve curve;

	[Token(Token = "0x4000F3E")]
	[FieldOffset(Offset = "0x38")]
	public List<GameObject> gameObjects;

	[Token(Token = "0x4000F3F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool useAnimation;

	[Token(Token = "0x4000F40")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool disableOnAwake;

	[Token(Token = "0x4000F41")]
	[FieldOffset(Offset = "0x42")]
	[SerializeField]
	private bool shuffle;

	[Token(Token = "0x4000F42")]
	[FieldOffset(Offset = "0x43")]
	[SerializeField]
	private bool startOnEnable;

	[Token(Token = "0x4000F43")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool _useSetDurations;

	[Token(Token = "0x4000F44")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<float> _setDurations;

	[Token(Token = "0x4000F45")]
	[FieldOffset(Offset = "0x50")]
	private bool isStarted;

	[Token(Token = "0x4000F46")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private Vector3 _startScale;

	[Token(Token = "0x6000CCC")]
	[Address(RVA = "0x1416318", Offset = "0x1416318", VA = "0x1416318")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000CCD")]
	[Address(RVA = "0x1416494", Offset = "0x1416494", VA = "0x1416494")]
	private IEnumerator AnimateIn()
	{
		return null;
	}

	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0x1416508", Offset = "0x1416508", VA = "0x1416508")]
	private void Start()
	{
	}

	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x14165A0", Offset = "0x14165A0", VA = "0x14165A0")]
	public void StartAnimateIn()
	{
	}

	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0x141661C", Offset = "0x141661C", VA = "0x141661C")]
	public AnimateInOnEnable()
	{
	}
}
