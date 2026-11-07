using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Token(Token = "0x200004C")]
	public class FOVKick
	{
		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x331E4", Offset = "0x331E4")]
		private sealed class _003CFOVKickUp_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000134")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000135")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick _003C_003E4__this;

			[Token(Token = "0x4000137")]
			[FieldOffset(Offset = "0x28")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x17000021")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000139")]
				[Address(RVA = "0x133AA04", Offset = "0x133AA04", VA = "0x133AA04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000022")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600013B")]
				[Address(RVA = "0x133AA4C", Offset = "0x133AA4C", VA = "0x133AA4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x133A8A4", Offset = "0x133A8A4", VA = "0x133A8A4")]
			[DebuggerHidden]
			public _003CFOVKickUp_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000137")]
			[Address(RVA = "0x133A8D0", Offset = "0x133A8D0", VA = "0x133A8D0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x133A8D4", Offset = "0x133A8D4", VA = "0x133A8D4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000139")]
			[Address(RVA = "0x133AA04", Offset = "0x133AA04", VA = "0x133AA04", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0x133AA0C", Offset = "0x133AA0C", VA = "0x133AA0C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0x133AA4C", Offset = "0x133AA4C", VA = "0x133AA4C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x331F4", Offset = "0x331F4")]
		private sealed class _003CFOVKickDown_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000138")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000139")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400013A")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick _003C_003E4__this;

			[Token(Token = "0x400013B")]
			[FieldOffset(Offset = "0x28")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x17000023")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600013F")]
				[Address(RVA = "0x133A854", Offset = "0x133A854", VA = "0x133A854", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000024")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000141")]
				[Address(RVA = "0x133A89C", Offset = "0x133A89C", VA = "0x133A89C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x133A6DC", Offset = "0x133A6DC", VA = "0x133A6DC")]
			[DebuggerHidden]
			public _003CFOVKickDown_003Ed__10(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600013D")]
			[Address(RVA = "0x133A708", Offset = "0x133A708", VA = "0x133A708", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0x133A70C", Offset = "0x133A70C", VA = "0x133A70C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600013F")]
			[Address(RVA = "0x133A854", Offset = "0x133A854", VA = "0x133A854", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000140")]
			[Address(RVA = "0x133A85C", Offset = "0x133A85C", VA = "0x133A85C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000141")]
			[Address(RVA = "0x133A89C", Offset = "0x133A89C", VA = "0x133A89C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x18")]
		public float originalFov;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x136F53C", Offset = "0x136F53C", VA = "0x136F53C")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x136F57C", Offset = "0x136F57C", VA = "0x136F57C")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x136F668", Offset = "0x136F668", VA = "0x136F668")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x136F6DC", Offset = "0x136F6DC", VA = "0x136F6DC")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x136F750", Offset = "0x136F750", VA = "0x136F750")]
		public FOVKick()
		{
		}
	}
}
