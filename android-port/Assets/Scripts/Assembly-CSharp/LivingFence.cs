using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Triband.Splines;
using UnityEngine;

[Token(Token = "0x2000D9F")]
public class LivingFence : MonoBehaviour
{
	[Token(Token = "0x2000DA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44BC0", Offset = "0x44BC0")]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		[Token(Token = "0x4004A45")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody r;

		[Token(Token = "0x4004A46")]
		[FieldOffset(Offset = "0x18")]
		public LivingFence _003C_003E4__this;

		[Token(Token = "0x6004015")]
		[Address(RVA = "0x17E9E34", Offset = "0x17E9E34", VA = "0x17E9E34")]
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		[Token(Token = "0x6004016")]
		[Address(RVA = "0x17E9E3C", Offset = "0x17E9E3C", VA = "0x17E9E3C")]
		internal void _003CStart_003Eb__0(Rigidbody rigidbody1)
		{
		}
	}

	[Token(Token = "0x2000DA1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44BD0", Offset = "0x44BD0")]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x4004A47")]
		[FieldOffset(Offset = "0x10")]
		public Transform child;

		[Token(Token = "0x4004A48")]
		[FieldOffset(Offset = "0x18")]
		public Quaternion start;

		[Token(Token = "0x4004A49")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion end;

		[Token(Token = "0x4004A4A")]
		[FieldOffset(Offset = "0x38")]
		public LivingFence _003C_003E4__this;

		[Token(Token = "0x6004017")]
		[Address(RVA = "0x17E9F0C", Offset = "0x17E9F0C", VA = "0x17E9F0C")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x6004018")]
		[Address(RVA = "0x17E9F14", Offset = "0x17E9F14", VA = "0x17E9F14")]
		internal void _003CRotate_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6004019")]
		[Address(RVA = "0x17E9FC0", Offset = "0x17E9FC0", VA = "0x17E9FC0")]
		internal void _003CRotate_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000DA2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44BE0", Offset = "0x44BE0")]
	private sealed class _003CRotate_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004A4B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004A4C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004A4D")]
		[FieldOffset(Offset = "0x20")]
		public LivingFence _003C_003E4__this;

		[Token(Token = "0x4004A4E")]
		[FieldOffset(Offset = "0x28")]
		public Transform parent;

		[Token(Token = "0x4004A4F")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x4004A50")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

		[Token(Token = "0x4004A51")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _003CstartPos_003E5__2;

		[Token(Token = "0x1700068F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600401D")]
			[Address(RVA = "0x17EA3FC", Offset = "0x17EA3FC", VA = "0x17EA3FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000690")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600401F")]
			[Address(RVA = "0x17EA444", Offset = "0x17EA444", VA = "0x17EA444", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600401A")]
		[Address(RVA = "0x17EA06C", Offset = "0x17EA06C", VA = "0x17EA06C")]
		[DebuggerHidden]
		public _003CRotate_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600401B")]
		[Address(RVA = "0x17EA098", Offset = "0x17EA098", VA = "0x17EA098", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600401C")]
		[Address(RVA = "0x17EA09C", Offset = "0x17EA09C", VA = "0x17EA09C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600401D")]
		[Address(RVA = "0x17EA3FC", Offset = "0x17EA3FC", VA = "0x17EA3FC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600401E")]
		[Address(RVA = "0x17EA404", Offset = "0x17EA404", VA = "0x17EA404", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600401F")]
		[Address(RVA = "0x17EA444", Offset = "0x17EA444", VA = "0x17EA444", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004A30")]
	[FieldOffset(Offset = "0x18")]
	private List<Rigidbody> _rbs;

	[Token(Token = "0x4004A31")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Spline _spline;

	[Token(Token = "0x4004A32")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _speed;

	[Token(Token = "0x4004A33")]
	[FieldOffset(Offset = "0x2C")]
	private float _mT;

	[Token(Token = "0x4004A34")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 _rotationOffSet;

	[Token(Token = "0x4004A35")]
	[FieldOffset(Offset = "0x40")]
	private double _time;

	[Token(Token = "0x4004A36")]
	[FieldOffset(Offset = "0x48")]
	private bool _moving;

	[Token(Token = "0x4004A37")]
	[FieldOffset(Offset = "0x49")]
	[SerializeField]
	private bool _canMove;

	[Token(Token = "0x4004A38")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private int _numRotate;

	[Token(Token = "0x4004A39")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _waitDownTime;

	[Token(Token = "0x4004A3A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AnimationCurve _curve;

	[Token(Token = "0x4004A3B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AnimationCurve _up;

	[Token(Token = "0x4004A3C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float angleDiff;

	[Token(Token = "0x4004A3D")]
	[FieldOffset(Offset = "0x6C")]
	private float _splineLength;

	[Token(Token = "0x4004A3E")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float _spacing;

	[Token(Token = "0x4004A3F")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float _duration;

	[Token(Token = "0x4004A40")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> _faceThings;

	[Token(Token = "0x4004A41")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private bool _looping;

	[Token(Token = "0x4004A42")]
	[FieldOffset(Offset = "0x84")]
	private float _dir;

	[Token(Token = "0x4004A43")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float _blockPlayerTime;

	[Token(Token = "0x4004A44")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private float _lateness;

	[Token(Token = "0x1700068D")]
	private float spacing
	{
		[Token(Token = "0x6004012")]
		[Address(RVA = "0x1535D2C", Offset = "0x1535D2C", VA = "0x1535D2C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700068E")]
	private float speed
	{
		[Token(Token = "0x6004013")]
		[Address(RVA = "0x1536950", Offset = "0x1536950", VA = "0x1536950")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x600400C")]
	[Address(RVA = "0x1535AEC", Offset = "0x1535AEC", VA = "0x1535AEC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6CC3C", Offset = "0x6CC3C")]
	public void Place()
	{
	}

	[Token(Token = "0x600400D")]
	[Address(RVA = "0x1535D38", Offset = "0x1535D38", VA = "0x1535D38")]
	private void Start()
	{
	}

	[Token(Token = "0x600400E")]
	[Address(RVA = "0x153624C", Offset = "0x153624C", VA = "0x153624C")]
	private void OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x600400F")]
	[Address(RVA = "0x15363B8", Offset = "0x15363B8", VA = "0x15363B8")]
	private void Hit(Rigidbody ball, int fencePiece)
	{
	}

	[Token(Token = "0x6004010")]
	[Address(RVA = "0x15365C4", Offset = "0x15365C4", VA = "0x15365C4")]
	private IEnumerator Rotate(float angle, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6004011")]
	[Address(RVA = "0x153664C", Offset = "0x153664C", VA = "0x153664C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6004014")]
	[Address(RVA = "0x1536960", Offset = "0x1536960", VA = "0x1536960")]
	public LivingFence()
	{
	}
}
