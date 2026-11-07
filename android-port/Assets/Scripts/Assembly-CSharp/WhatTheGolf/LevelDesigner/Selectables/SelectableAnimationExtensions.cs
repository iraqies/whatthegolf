using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	[Token(Token = "0x2001276")]
	public static class SelectableAnimationExtensions
	{
		[Serializable]
		[Token(Token = "0x2001277")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48714", Offset = "0x48714")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400633D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400633E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<float, float> _003C_003E9__9_0;

			[Token(Token = "0x400633F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<float, float> _003C_003E9__12_0;

			[Token(Token = "0x4006340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<float, Vector2> _003C_003E9__15_0;

			[Token(Token = "0x4006341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<float, Vector2> _003C_003E9__16_0;

			[Token(Token = "0x600555F")]
			[Address(RVA = "0x1840BD4", Offset = "0x1840BD4", VA = "0x1840BD4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005560")]
			[Address(RVA = "0x1840BDC", Offset = "0x1840BDC", VA = "0x1840BDC")]
			internal float _003CApplyLiftAnimation_003Eb__9_0(float t)
			{
				return default;
			}

			[Token(Token = "0x6005561")]
			[Address(RVA = "0x1840C50", Offset = "0x1840C50", VA = "0x1840C50")]
			internal float _003CApplyDropAnimation_003Eb__12_0(float t)
			{
				return default;
			}

			[Token(Token = "0x6005562")]
			[Address(RVA = "0x1840CC4", Offset = "0x1840CC4", VA = "0x1840CC4")]
			internal Vector2 _003CApplyVertexScaleAnimation_003Eb__15_0(float t)
			{
				return default;
			}

			[Token(Token = "0x6005563")]
			[Address(RVA = "0x1840E6C", Offset = "0x1840E6C", VA = "0x1840E6C")]
			internal Vector2 _003CApplyDeleteAnimation_003Eb__16_0(float t)
			{
				return default;
			}
		}

		[Token(Token = "0x2001278")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48724", Offset = "0x48724")]
		private sealed class _003CLiftAnimationProcess_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4006345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Selectable selectable;

			[Token(Token = "0x4006346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float speed;

			[Token(Token = "0x4006347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float targetYOffset;

			[Token(Token = "0x4006348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Func<float, float> getYOffset;

			[Token(Token = "0x4006349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x400634A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float _003CstartYOffset_003E5__3;

			[Token(Token = "0x400634B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float _003CbaseY_003E5__4;

			[Token(Token = "0x170009B5")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005567")]
				[Address(RVA = "0x1841548", Offset = "0x1841548", VA = "0x1841548", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009B6")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005569")]
				[Address(RVA = "0x1841590", Offset = "0x1841590", VA = "0x1841590", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005564")]
			[Address(RVA = "0x18412D8", Offset = "0x18412D8", VA = "0x18412D8")]
			[DebuggerHidden]
			public _003CLiftAnimationProcess_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005565")]
			[Address(RVA = "0x1841304", Offset = "0x1841304", VA = "0x1841304", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005566")]
			[Address(RVA = "0x1841308", Offset = "0x1841308", VA = "0x1841308", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005567")]
			[Address(RVA = "0x1841548", Offset = "0x1841548", VA = "0x1841548", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005568")]
			[Address(RVA = "0x1841550", Offset = "0x1841550", VA = "0x1841550", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005569")]
			[Address(RVA = "0x1841590", Offset = "0x1841590", VA = "0x1841590", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001279")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48734", Offset = "0x48734")]
		private sealed class _003CDropAnimationProcess_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400634C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400634D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400634E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Selectable selectable;

			[Token(Token = "0x400634F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool forceStartOffset;

			[Token(Token = "0x4006350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float speed;

			[Token(Token = "0x4006351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Func<float, float> getYOffset;

			[Token(Token = "0x4006352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x4006353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float _003CbaseY_003E5__3;

			[Token(Token = "0x4006354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float _003CstartYOffset_003E5__4;

			[Token(Token = "0x170009B7")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600556D")]
				[Address(RVA = "0x1841288", Offset = "0x1841288", VA = "0x1841288", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009B8")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600556F")]
				[Address(RVA = "0x18412D0", Offset = "0x18412D0", VA = "0x18412D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600556A")]
			[Address(RVA = "0x1841014", Offset = "0x1841014", VA = "0x1841014")]
			[DebuggerHidden]
			public _003CDropAnimationProcess_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600556B")]
			[Address(RVA = "0x1841040", Offset = "0x1841040", VA = "0x1841040", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600556C")]
			[Address(RVA = "0x1841044", Offset = "0x1841044", VA = "0x1841044", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600556D")]
			[Address(RVA = "0x1841288", Offset = "0x1841288", VA = "0x1841288", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600556E")]
			[Address(RVA = "0x1841290", Offset = "0x1841290", VA = "0x1841290", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600556F")]
			[Address(RVA = "0x18412D0", Offset = "0x18412D0", VA = "0x18412D0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200127A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48744", Offset = "0x48744")]
		private sealed class _003CVertexScaleAnimationProcess_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Selectable selectable;

			[Token(Token = "0x4006358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float delay;

			[Token(Token = "0x4006359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float speed;

			[Token(Token = "0x400635A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Func<float, Vector2> getScale;

			[Token(Token = "0x400635B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action onComplete;

			[Token(Token = "0x400635C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private MaterialPropertyBlock _003Cblock_003E5__2;

			[Token(Token = "0x400635D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float _003Ct_003E5__3;

			[Token(Token = "0x170009B9")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005573")]
				[Address(RVA = "0x184182C", Offset = "0x184182C", VA = "0x184182C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009BA")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005575")]
				[Address(RVA = "0x1841874", Offset = "0x1841874", VA = "0x1841874", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005570")]
			[Address(RVA = "0x1841598", Offset = "0x1841598", VA = "0x1841598")]
			[DebuggerHidden]
			public _003CVertexScaleAnimationProcess_003Ed__18(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005571")]
			[Address(RVA = "0x18415C4", Offset = "0x18415C4", VA = "0x18415C4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005572")]
			[Address(RVA = "0x18415C8", Offset = "0x18415C8", VA = "0x18415C8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005573")]
			[Address(RVA = "0x184182C", Offset = "0x184182C", VA = "0x184182C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005574")]
			[Address(RVA = "0x1841834", Offset = "0x1841834", VA = "0x1841834", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005575")]
			[Address(RVA = "0x1841874", Offset = "0x1841874", VA = "0x1841874", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200127B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48754", Offset = "0x48754")]
		private sealed class _003CWait_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400635E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400635F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4006361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float _003CdelayEnd_003E5__2;

			[Token(Token = "0x170009BB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005579")]
				[Address(RVA = "0x1841928", Offset = "0x1841928", VA = "0x1841928", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009BC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600557B")]
				[Address(RVA = "0x1841970", Offset = "0x1841970", VA = "0x1841970", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005576")]
			[Address(RVA = "0x184187C", Offset = "0x184187C", VA = "0x184187C")]
			[DebuggerHidden]
			public _003CWait_003Ed__19(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005577")]
			[Address(RVA = "0x18418A8", Offset = "0x18418A8", VA = "0x18418A8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005578")]
			[Address(RVA = "0x18418AC", Offset = "0x18418AC", VA = "0x18418AC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005579")]
			[Address(RVA = "0x1841928", Offset = "0x1841928", VA = "0x1841928", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600557A")]
			[Address(RVA = "0x1841930", Offset = "0x1841930", VA = "0x1841930", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600557B")]
			[Address(RVA = "0x1841970", Offset = "0x1841970", VA = "0x1841970", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float liftDropAnimSpeed;

		[Token(Token = "0x4006335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float liftAnimElevation;

		[Token(Token = "0x4006336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float scaleAnimDelay;

		[Token(Token = "0x4006337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float scaleAnimSpeed;

		[Token(Token = "0x4006338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static float liftAnimDelay;

		[Token(Token = "0x4006339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static float s_SwayAmount;

		[Token(Token = "0x400633A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static float s_SmoothTime;

		[Token(Token = "0x400633B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static Vector3 s_Velocity;

		[Token(Token = "0x400633C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Vector3 s_SmoothSway;

		[Token(Token = "0x600554F")]
		[Address(RVA = "0x1684080", Offset = "0x1684080", VA = "0x1684080")]
		public static void ApplyLiftAnimation(this Selectable selectable)
		{
		}

		[Token(Token = "0x6005550")]
		[Address(RVA = "0x1685404", Offset = "0x1685404", VA = "0x1685404")]
		public static void ApplyLiftAnimation(this Selectable selectable, float speed, float targetYOffset, Func<float, float> getYOffset, float delay = 0f)
		{
		}

		[Token(Token = "0x6005551")]
		[Address(RVA = "0x1685510", Offset = "0x1685510", VA = "0x1685510")]
		private static IEnumerator LiftAnimationProcess(Selectable selectable, float speed, float targetYOffset, Func<float, float> getYOffset, float delay = 0f)
		{
			return null;
		}

		[Token(Token = "0x6005552")]
		[Address(RVA = "0x168457C", Offset = "0x168457C", VA = "0x168457C")]
		public static void ApplyDropAnimation(this Selectable selectable, bool forceStartOffset)
		{
		}

		[Token(Token = "0x6005553")]
		[Address(RVA = "0x16855B0", Offset = "0x16855B0", VA = "0x16855B0")]
		public static void ApplyDropAnimation(this Selectable selectable, float speed, Func<float, float> getYOffset, bool forceStartOffset)
		{
		}

		[Token(Token = "0x6005554")]
		[Address(RVA = "0x16856B8", Offset = "0x16856B8", VA = "0x16856B8")]
		private static IEnumerator DropAnimationProcess(Selectable selectable, float speed, Func<float, float> getYOffset, bool forceStartOffset)
		{
			return null;
		}

		[Token(Token = "0x6005555")]
		[Address(RVA = "0x1683EF0", Offset = "0x1683EF0", VA = "0x1683EF0")]
		public static void ApplyVertexScaleAnimation(this Selectable selectable)
		{
		}

		[Token(Token = "0x6005556")]
		[Address(RVA = "0x168585C", Offset = "0x168585C", VA = "0x168585C")]
		public static void ApplyDeleteAnimation(this Selectable selectable, Action onComplete)
		{
		}

		[Token(Token = "0x6005557")]
		[Address(RVA = "0x1685754", Offset = "0x1685754", VA = "0x1685754")]
		public static void ApplyVertexScaleAnimation(this Selectable selectable, float speed, Func<float, Vector2> getScale, [Optional][DefaultParameterValue(0f)] float delay, [Optional] Action onComplete)
		{
		}

		[Token(Token = "0x6005558")]
		[Address(RVA = "0x16859F0", Offset = "0x16859F0", VA = "0x16859F0")]
		private static IEnumerator VertexScaleAnimationProcess(Selectable selectable, float speed, Func<float, Vector2> getScale, [Optional][DefaultParameterValue(0f)] float delay, [Optional] Action onComplete)
		{
			return null;
		}

		[Token(Token = "0x6005559")]
		[Address(RVA = "0x1685A8C", Offset = "0x1685A8C", VA = "0x1685A8C")]
		private static IEnumerator Wait(float delay)
		{
			return null;
		}

		[Token(Token = "0x600555A")]
		[Address(RVA = "0x16850DC", Offset = "0x16850DC", VA = "0x16850DC")]
		public static void SetSway(this Selectable selectable, Vector3 cursorDeltaWS, Vector3 pivotWS)
		{
		}

		[Token(Token = "0x600555C")]
		[Address(RVA = "0x1685B94", Offset = "0x1685B94", VA = "0x1685B94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71710", Offset = "0x71710")]
		internal static float _003CApplyVertexScaleAnimation_003Eg__Remap01_007C15_1(float value, float min, float max)
		{
			return default;
		}

		[Token(Token = "0x600555D")]
		[Address(RVA = "0x1685BA4", Offset = "0x1685BA4", VA = "0x1685BA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71720", Offset = "0x71720")]
		internal static float _003CApplyDeleteAnimation_003Eg__Remap01_007C16_1(float value, float min, float max)
		{
			return default;
		}
	}
}
