using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnitySA.Utility
{
	[Serializable]
	[Token(Token = "0x2000F41")]
	public class FOVZoom
	{
		[Token(Token = "0x2000F42")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x458F4", Offset = "0x458F4")]
		private sealed class _003CFOVKickUp_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005275")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005276")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005277")]
			[FieldOffset(Offset = "0x20")]
			public FOVZoom _003C_003E4__this;

			[Token(Token = "0x4005278")]
			[FieldOffset(Offset = "0x28")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x1700075C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004751")]
				[Address(RVA = "0x17A2000", Offset = "0x17A2000", VA = "0x17A2000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700075D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004753")]
				[Address(RVA = "0x17A2048", Offset = "0x17A2048", VA = "0x17A2048", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600474E")]
			[Address(RVA = "0x17A1EA0", Offset = "0x17A1EA0", VA = "0x17A1EA0")]
			[DebuggerHidden]
			public _003CFOVKickUp_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600474F")]
			[Address(RVA = "0x17A1ECC", Offset = "0x17A1ECC", VA = "0x17A1ECC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004750")]
			[Address(RVA = "0x17A1ED0", Offset = "0x17A1ED0", VA = "0x17A1ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004751")]
			[Address(RVA = "0x17A2000", Offset = "0x17A2000", VA = "0x17A2000", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004752")]
			[Address(RVA = "0x17A2008", Offset = "0x17A2008", VA = "0x17A2008", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004753")]
			[Address(RVA = "0x17A2048", Offset = "0x17A2048", VA = "0x17A2048", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000F43")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45904", Offset = "0x45904")]
		private sealed class _003CFOVKickDown_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005279")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400527A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400527B")]
			[FieldOffset(Offset = "0x20")]
			public FOVZoom _003C_003E4__this;

			[Token(Token = "0x400527C")]
			[FieldOffset(Offset = "0x28")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x1700075E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004757")]
				[Address(RVA = "0x17A1E50", Offset = "0x17A1E50", VA = "0x17A1E50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700075F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004759")]
				[Address(RVA = "0x17A1E98", Offset = "0x17A1E98", VA = "0x17A1E98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004754")]
			[Address(RVA = "0x17A1CD8", Offset = "0x17A1CD8", VA = "0x17A1CD8")]
			[DebuggerHidden]
			public _003CFOVKickDown_003Ed__10(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004755")]
			[Address(RVA = "0x17A1D04", Offset = "0x17A1D04", VA = "0x17A1D04", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004756")]
			[Address(RVA = "0x17A1D08", Offset = "0x17A1D08", VA = "0x17A1D08", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004757")]
			[Address(RVA = "0x17A1E50", Offset = "0x17A1E50", VA = "0x17A1E50", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004758")]
			[Address(RVA = "0x17A1E58", Offset = "0x17A1E58", VA = "0x17A1E58", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004759")]
			[Address(RVA = "0x17A1E98", Offset = "0x17A1E98", VA = "0x17A1E98", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400526F")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4005270")]
		[FieldOffset(Offset = "0x18")]
		public float originalFov;

		[Token(Token = "0x4005271")]
		[FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4005272")]
		[FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4005273")]
		[FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4005274")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6004749")]
		[Address(RVA = "0x145566C", Offset = "0x145566C", VA = "0x145566C")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x600474A")]
		[Address(RVA = "0x14556AC", Offset = "0x14556AC", VA = "0x14556AC")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x600474B")]
		[Address(RVA = "0x1455798", Offset = "0x1455798", VA = "0x1455798")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x600474C")]
		[Address(RVA = "0x145580C", Offset = "0x145580C", VA = "0x145580C")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x600474D")]
		[Address(RVA = "0x1455880", Offset = "0x1455880", VA = "0x1455880")]
		public FOVZoom()
		{
		}
	}
}
