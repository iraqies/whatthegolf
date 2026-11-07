using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002CE")]
public class AnimateInOnEnableAxis : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20002CF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EC9C", Offset = "0x3EC9C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000F5F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000F60")]
		[FieldOffset(Offset = "0x8")]
		public static Action<GameObject> _003C_003E9__13_0;

		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x176B41C", Offset = "0x176B41C", VA = "0x176B41C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x176B424", Offset = "0x176B424", VA = "0x176B424")]
		internal void _003CAwake_003Eb__13_0(GameObject g)
		{
		}
	}

	[Token(Token = "0x20002D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ECAC", Offset = "0x3ECAC")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4000F61")]
		[FieldOffset(Offset = "0x10")]
		public GameObject g;

		[Token(Token = "0x4000F62")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 end;

		[Token(Token = "0x4000F63")]
		[FieldOffset(Offset = "0x28")]
		public AnimateInOnEnableAxis _003C_003E4__this;

		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x176B444", Offset = "0x176B444", VA = "0x176B444")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x176B44C", Offset = "0x176B44C", VA = "0x176B44C")]
		internal void _003CAnimateIn_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20002D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ECBC", Offset = "0x3ECBC")]
	private sealed class _003CAnimateIn_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F64")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F66")]
		[FieldOffset(Offset = "0x20")]
		public AnimateInOnEnableAxis _003C_003E4__this;

		[Token(Token = "0x4000F67")]
		[FieldOffset(Offset = "0x28")]
		private List<GameObject>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x1700018A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000CEC")]
			[Address(RVA = "0x176BA04", Offset = "0x176BA04", VA = "0x176BA04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700018B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000CEE")]
			[Address(RVA = "0x176BA4C", Offset = "0x176BA4C", VA = "0x176BA4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x176B550", Offset = "0x176B550", VA = "0x176B550")]
		[DebuggerHidden]
		public _003CAnimateIn_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x176B57C", Offset = "0x176B57C", VA = "0x176B57C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x176B650", Offset = "0x176B650", VA = "0x176B650", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x176B5F4", Offset = "0x176B5F4", VA = "0x176B5F4")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x176BA04", Offset = "0x176BA04", VA = "0x176BA04", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x176BA0C", Offset = "0x176BA0C", VA = "0x176BA0C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x176BA4C", Offset = "0x176BA4C", VA = "0x176BA4C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000F52")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float DurationMax;

	[Token(Token = "0x4000F53")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float DurationMin;

	[Token(Token = "0x4000F54")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 Delay;

	[Token(Token = "0x4000F55")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float Stagger;

	[Token(Token = "0x4000F56")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve curveX;

	[Token(Token = "0x4000F57")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve curveY;

	[Token(Token = "0x4000F58")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve curveZ;

	[Token(Token = "0x4000F59")]
	[FieldOffset(Offset = "0x48")]
	public List<GameObject> gameObjects;

	[Token(Token = "0x4000F5A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool useAnimation;

	[Token(Token = "0x4000F5B")]
	[FieldOffset(Offset = "0x51")]
	[SerializeField]
	private bool disableOnAwake;

	[Token(Token = "0x4000F5C")]
	[FieldOffset(Offset = "0x52")]
	[SerializeField]
	private bool shuffle;

	[Token(Token = "0x4000F5D")]
	[FieldOffset(Offset = "0x53")]
	[SerializeField]
	private bool startOnEnable;

	[Token(Token = "0x4000F5E")]
	[FieldOffset(Offset = "0x54")]
	private bool isStarted;

	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0x1416668", Offset = "0x1416668", VA = "0x1416668")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x14167E4", Offset = "0x14167E4", VA = "0x14167E4")]
	private IEnumerator AnimateIn()
	{
		return null;
	}

	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x1416858", Offset = "0x1416858", VA = "0x1416858")]
	private void Start()
	{
	}

	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x14168F0", Offset = "0x14168F0", VA = "0x14168F0")]
	public void StartAnimateIn()
	{
	}

	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x141696C", Offset = "0x141696C", VA = "0x141696C")]
	public AnimateInOnEnableAxis()
	{
	}
}
