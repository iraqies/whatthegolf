using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200021A")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200021B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33DBC", Offset = "0x33DBC")]
		private sealed class _003CSwitchRotation_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000E0C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000E0D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000E0E")]
			[FieldOffset(Offset = "0x20")]
			public PlatformRotator _003C_003E4__this;

			[Token(Token = "0x170001C6")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000E7C")]
				[Address(RVA = "0x1352010", Offset = "0x1352010", VA = "0x1352010", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001C7")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000E7E")]
				[Address(RVA = "0x1352058", Offset = "0x1352058", VA = "0x1352058", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000E79")]
			[Address(RVA = "0x1351EC8", Offset = "0x1351EC8", VA = "0x1351EC8")]
			[DebuggerHidden]
			public _003CSwitchRotation_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000E7A")]
			[Address(RVA = "0x1351EF4", Offset = "0x1351EF4", VA = "0x1351EF4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000E7B")]
			[Address(RVA = "0x1351EF8", Offset = "0x1351EF8", VA = "0x1351EF8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000E7C")]
			[Address(RVA = "0x1352010", Offset = "0x1352010", VA = "0x1352010", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000E7D")]
			[Address(RVA = "0x1352018", Offset = "0x1352018", VA = "0x1352018", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000E7E")]
			[Address(RVA = "0x1352058", Offset = "0x1352058", VA = "0x1352058", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000E00")]
		[FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000E01")]
		[FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000E02")]
		[FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000E03")]
		[FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000E04")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000E05")]
		[FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000E07")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000E08")]
		[FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000E09")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000E0A")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000E0B")]
		[FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x13C03A8", Offset = "0x13C03A8", VA = "0x13C03A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x13C0524", Offset = "0x13C0524", VA = "0x13C0524")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x13C04B0", Offset = "0x13C04B0", VA = "0x13C04B0")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x13C06C0", Offset = "0x13C06C0", VA = "0x13C06C0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x13C07AC", Offset = "0x13C07AC", VA = "0x13C07AC")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x13C0890", Offset = "0x13C0890", VA = "0x13C0890")]
		public PlatformRotator()
		{
		}
	}
}
