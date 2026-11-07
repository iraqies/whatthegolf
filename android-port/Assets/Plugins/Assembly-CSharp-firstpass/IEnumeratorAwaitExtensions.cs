using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000008")]
public static class IEnumeratorAwaitExtensions
{
	[Token(Token = "0x2000009")]
	public class SimpleCoroutineAwaiter<T> : INotifyCompletion
	{
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x0")]
		private bool _isDone;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x0")]
		private Exception _exception;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x0")]
		private Action _continuation;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		private T _result;

		[Token(Token = "0x17000005")]
		public bool IsCompleted
		{
			[Token(Token = "0x6000023")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000024")]
		public T GetResult()
		{
			return (T)null;
		}

		[Token(Token = "0x6000025")]
		public void Complete(T result, Exception e)
		{
		}

		[Token(Token = "0x6000026")]
		private void System_002ERuntime_002ECompilerServices_002EINotifyCompletion_002EOnCompleted(Action continuation)
		{
		}

		[Token(Token = "0x6000027")]
		public SimpleCoroutineAwaiter()
		{
		}
	}

	[Token(Token = "0x200000A")]
	public class SimpleCoroutineAwaiter : INotifyCompletion
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x10")]
		private bool _isDone;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x18")]
		private Exception _exception;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x20")]
		private Action _continuation;

		[Token(Token = "0x17000006")]
		public bool IsCompleted
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x133DFD8", Offset = "0x133DFD8", VA = "0x133DFD8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1332B28", Offset = "0x1332B28", VA = "0x1332B28")]
		public void GetResult()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x133DFE0", Offset = "0x133DFE0", VA = "0x133DFE0")]
		public void Complete(Exception e)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x133E040", Offset = "0x133E040", VA = "0x133E040", Slot = "4")]
		private void System_002ERuntime_002ECompilerServices_002EINotifyCompletion_002EOnCompleted(Action continuation)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x133E08C", Offset = "0x133E08C", VA = "0x133E08C")]
		public SimpleCoroutineAwaiter()
		{
		}
	}

	[Token(Token = "0x200000B")]
	private class CoroutineWrapper<T>
	{
		[Token(Token = "0x200000C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3302C", Offset = "0x3302C")]
		private sealed class _003CRun_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400001B")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x400001C")]
			[FieldOffset(Offset = "0x0")]
			private object _003C_003E2__current;

			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x0")]
			public CoroutineWrapper<T> _003C_003E4__this;

			[Token(Token = "0x17000007")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000034")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000008")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000036")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000031")]
			[DebuggerHidden]
			public _003CRun_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000032")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000033")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000034")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000035")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000036")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x0")]
		private readonly SimpleCoroutineAwaiter<T> _awaiter;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		private readonly Stack<IEnumerator> _processStack;

		[Token(Token = "0x600002D")]
		public CoroutineWrapper(IEnumerator coroutine, SimpleCoroutineAwaiter<T> awaiter)
		{
		}

		[Token(Token = "0x600002E")]
		public IEnumerator Run()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		private string GenerateObjectTraceMessage(List<Type> objTrace)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		private static List<Type> GenerateObjectTrace(IEnumerable<IEnumerator> enumerators)
		{
			return null;
		}
	}

	[Token(Token = "0x200000D")]
	private static class InstructionWrappers
	{
		[Token(Token = "0x200000E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3303C", Offset = "0x3303C")]
		private sealed class _003CReturnVoid_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x20")]
			public object instruction;

			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter awaiter;

			[Token(Token = "0x17000009")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600003E")]
				[Address(RVA = "0x135AE68", Offset = "0x135AE68", VA = "0x135AE68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700000A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000040")]
				[Address(RVA = "0x135AEB0", Offset = "0x135AEB0", VA = "0x135AEB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0x135ADD4", Offset = "0x135ADD4", VA = "0x135ADD4")]
			[DebuggerHidden]
			public _003CReturnVoid_003Ed__0(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x135AE00", Offset = "0x135AE00", VA = "0x135AE00", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600003D")]
			[Address(RVA = "0x135AE04", Offset = "0x135AE04", VA = "0x135AE04", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x135AE68", Offset = "0x135AE68", VA = "0x135AE68", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600003F")]
			[Address(RVA = "0x135AE70", Offset = "0x135AE70", VA = "0x135AE70", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0x135AEB0", Offset = "0x135AEB0", VA = "0x135AEB0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3304C", Offset = "0x3304C")]
		private sealed class _003CAssetBundleCreateRequest_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x20")]
			public AssetBundleCreateRequest instruction;

			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter<AssetBundle> awaiter;

			[Token(Token = "0x1700000B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000044")]
				[Address(RVA = "0x135AC5C", Offset = "0x135AC5C", VA = "0x135AC5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700000C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000046")]
				[Address(RVA = "0x135ACA4", Offset = "0x135ACA4", VA = "0x135ACA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x135AB84", Offset = "0x135AB84", VA = "0x135AB84")]
			[DebuggerHidden]
			public _003CAssetBundleCreateRequest_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x135ABB0", Offset = "0x135ABB0", VA = "0x135ABB0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000043")]
			[Address(RVA = "0x135ABB4", Offset = "0x135ABB4", VA = "0x135ABB4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x135AC5C", Offset = "0x135AC5C", VA = "0x135AC5C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0x135AC64", Offset = "0x135AC64", VA = "0x135AC64", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x135ACA4", Offset = "0x135ACA4", VA = "0x135ACA4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3305C", Offset = "0x3305C")]
		private sealed class _003CReturnSelf_003Ed__2<T> : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x0")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000028")]
			[FieldOffset(Offset = "0x0")]
			public T instruction;

			[Token(Token = "0x4000029")]
			[FieldOffset(Offset = "0x0")]
			public SimpleCoroutineAwaiter<T> awaiter;

			[Token(Token = "0x1700000D")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600004A")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700000E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600004C")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000047")]
			[DebuggerHidden]
			public _003CReturnSelf_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000048")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000049")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600004A")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600004B")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600004C")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000011")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3306C", Offset = "0x3306C")]
		private sealed class _003CAssetBundleRequest_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400002A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400002B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400002C")]
			[FieldOffset(Offset = "0x20")]
			public AssetBundleRequest instruction;

			[Token(Token = "0x400002D")]
			[FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

			[Token(Token = "0x1700000F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000050")]
				[Address(RVA = "0x135AD84", Offset = "0x135AD84", VA = "0x135AD84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000010")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000052")]
				[Address(RVA = "0x135ADCC", Offset = "0x135ADCC", VA = "0x135ADCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x135ACAC", Offset = "0x135ACAC", VA = "0x135ACAC")]
			[DebuggerHidden]
			public _003CAssetBundleRequest_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x135ACD8", Offset = "0x135ACD8", VA = "0x135ACD8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x135ACDC", Offset = "0x135ACDC", VA = "0x135ACDC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0x135AD84", Offset = "0x135AD84", VA = "0x135AD84", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x135AD8C", Offset = "0x135AD8C", VA = "0x135AD8C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0x135ADCC", Offset = "0x135ADCC", VA = "0x135ADCC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x133DF3C", Offset = "0x133DF3C", VA = "0x133DF3C")]
		public static IEnumerator ReturnVoid(SimpleCoroutineAwaiter awaiter, object instruction)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x133DC38", Offset = "0x133DC38", VA = "0x133DC38")]
		public static IEnumerator AssetBundleCreateRequest(SimpleCoroutineAwaiter<AssetBundle> awaiter, AssetBundleCreateRequest instruction)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		public static IEnumerator ReturnSelf<T>(SimpleCoroutineAwaiter<T> awaiter, T instruction)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x133DD50", Offset = "0x133DD50", VA = "0x133DD50")]
		public static IEnumerator AssetBundleRequest(SimpleCoroutineAwaiter<UnityEngine.Object> awaiter, AssetBundleRequest instruction)
		{
			return null;
		}
	}

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3307C", Offset = "0x3307C")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter<AssetBundle> awaiter;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x18")]
		public AssetBundleCreateRequest instruction;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x133DB98", Offset = "0x133DB98", VA = "0x133DB98")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x133DBA0", Offset = "0x133DBA0", VA = "0x133DBA0")]
		internal void _003CGetAwaiter_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3308C", Offset = "0x3308C")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x18")]
		public AssetBundleRequest instruction;

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x133DCB0", Offset = "0x133DCB0", VA = "0x133DCB0")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x133DCB8", Offset = "0x133DCB8", VA = "0x133DCB8")]
		internal void _003CGetAwaiter_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3309C", Offset = "0x3309C")]
	private sealed class _003C_003Ec__DisplayClass12_0<T>
	{
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x0")]
		public IEnumerator<T> coroutine;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x0")]
		public SimpleCoroutineAwaiter<T> awaiter;

		[Token(Token = "0x6000057")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6000058")]
		internal void _003CGetAwaiter_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x330AC", Offset = "0x330AC")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x10")]
		public IEnumerator coroutine;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x18")]
		public SimpleCoroutineAwaiter<object> awaiter;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x133DDC8", Offset = "0x133DDC8", VA = "0x133DDC8")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x133DDD0", Offset = "0x133DDD0", VA = "0x133DDD0")]
		internal void _003CGetAwaiter_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x330BC", Offset = "0x330BC")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter awaiter;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x18")]
		public object instruction;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x133DE9C", Offset = "0x133DE9C", VA = "0x133DE9C")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x133DEA4", Offset = "0x133DEA4", VA = "0x133DEA4")]
		internal void _003CGetAwaiterReturnVoid_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x330CC", Offset = "0x330CC")]
	private sealed class _003C_003Ec__DisplayClass15_0<T>
	{
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x0")]
		public SimpleCoroutineAwaiter<T> awaiter;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x0")]
		public T instruction;

		[Token(Token = "0x600005D")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x600005E")]
		internal void _003CGetAwaiterReturnSelf_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x330DC", Offset = "0x330DC")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x10")]
		public Action action;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x133DFB4", Offset = "0x133DFB4", VA = "0x133DFB4")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x133DFBC", Offset = "0x133DFBC", VA = "0x133DFBC")]
		internal void _003CRunOnUnityScheduler_003Eb__0(object _)
		{
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1384B28", Offset = "0x1384B28", VA = "0x1384B28")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSeconds instruction)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1384C14", Offset = "0x1384C14", VA = "0x1384C14")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForUpdate instruction)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1384C18", Offset = "0x1384C18", VA = "0x1384C18")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForEndOfFrame instruction)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1384C1C", Offset = "0x1384C1C", VA = "0x1384C1C")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSecondsRealtime instruction)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1384C20", Offset = "0x1384C20", VA = "0x1384C20")]
	public static SimpleCoroutineAwaiter<AsyncOperation> GetAwaiter(this AsyncOperation instruction)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1384C78", Offset = "0x1384C78", VA = "0x1384C78")]
	public static SimpleCoroutineAwaiter<WWW> GetAwaiter(this WWW instruction)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1384CD0", Offset = "0x1384CD0", VA = "0x1384CD0")]
	public static SimpleCoroutineAwaiter<AssetBundle> GetAwaiter(this AssetBundleCreateRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1384F34", Offset = "0x1384F34", VA = "0x1384F34")]
	public static SimpleCoroutineAwaiter<UnityEngine.Object> GetAwaiter(this AssetBundleRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	public static SimpleCoroutineAwaiter<T> GetAwaiter<T>(this IEnumerator<T> coroutine)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1385038", Offset = "0x1385038", VA = "0x1385038")]
	public static SimpleCoroutineAwaiter<object> GetAwaiter(this IEnumerator coroutine)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1384B2C", Offset = "0x1384B2C", VA = "0x1384B2C")]
	private static SimpleCoroutineAwaiter GetAwaiterReturnVoid(object instruction)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	private static SimpleCoroutineAwaiter<T> GetAwaiterReturnSelf<T>(T instruction)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1384DD4", Offset = "0x1384DD4", VA = "0x1384DD4")]
	private static void RunOnUnityScheduler(Action action)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x138513C", Offset = "0x138513C", VA = "0x138513C")]
	private static void Assert(bool condition)
	{
	}
}
