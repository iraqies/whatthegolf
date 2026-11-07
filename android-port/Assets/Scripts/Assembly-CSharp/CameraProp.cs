using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000294")]
public class CameraProp : MonoBehaviour
{
	[Token(Token = "0x2000295")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E89C", Offset = "0x3E89C")]
	private sealed class _003CStart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000DC1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000DC2")]
		[FieldOffset(Offset = "0x20")]
		public CameraProp _003C_003E4__this;

		[Token(Token = "0x4000DC3")]
		[FieldOffset(Offset = "0x28")]
		private Collider[] _003Ccolliders_003E5__2;

		[Token(Token = "0x17000169")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x1780F74", Offset = "0x1780F74", VA = "0x1780F74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700016A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x1780FBC", Offset = "0x1780FBC", VA = "0x1780FBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x1780A18", Offset = "0x1780A18", VA = "0x1780A18")]
		[DebuggerHidden]
		public _003CStart_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x1780A44", Offset = "0x1780A44", VA = "0x1780A44", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x1780A48", Offset = "0x1780A48", VA = "0x1780A48", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x1780F74", Offset = "0x1780F74", VA = "0x1780F74", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x1780F7C", Offset = "0x1780F7C", VA = "0x1780F7C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x1780FBC", Offset = "0x1780FBC", VA = "0x1780FBC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000DB4")]
	[FieldOffset(Offset = "0x18")]
	public float ViewDistance;

	[Token(Token = "0x4000DB5")]
	[FieldOffset(Offset = "0x1C")]
	public float UpdateInterval;

	[Token(Token = "0x4000DB6")]
	[FieldOffset(Offset = "0x20")]
	public float HoldTargetMinTime;

	[Token(Token = "0x4000DB7")]
	[FieldOffset(Offset = "0x28")]
	public ConfigurableJoint Joint;

	[Token(Token = "0x4000DB8")]
	[FieldOffset(Offset = "0x30")]
	public Transform CameraLens;

	[Token(Token = "0x4000DB9")]
	[FieldOffset(Offset = "0x38")]
	public Transform AlwaysFollow;

	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x40")]
	public bool lookForCustomKinematicTarget;

	[Token(Token = "0x4000DBB")]
	[FieldOffset(Offset = "0x48")]
	public List<Rigidbody> IgnoreList;

	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x50")]
	private Transform currentTarget;

	[Token(Token = "0x4000DBD")]
	[FieldOffset(Offset = "0x58")]
	private Rigidbody rigid;

	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody jointRigid;

	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0x68")]
	private Quaternion startRot;

	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x18842B0", Offset = "0x18842B0", VA = "0x18842B0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0x1884324", Offset = "0x1884324", VA = "0x1884324")]
	private bool IsValidTarget(Rigidbody otherRigid)
	{
		return default;
	}

	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x1884454", Offset = "0x1884454", VA = "0x1884454")]
	private bool IsValidKinematicTarget(Rigidbody otherRigid, out IMovingKinematicTarget kinematic)
	{
		return default;
	}

	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x188450C", Offset = "0x188450C", VA = "0x188450C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0x188464C", Offset = "0x188464C", VA = "0x188464C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000BD1")]
	[Address(RVA = "0x1884688", Offset = "0x1884688", VA = "0x1884688")]
	public CameraProp()
	{
	}
}
