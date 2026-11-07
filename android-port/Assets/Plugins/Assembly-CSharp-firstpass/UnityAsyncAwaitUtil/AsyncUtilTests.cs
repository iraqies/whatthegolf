using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace UnityAsyncAwaitUtil
{
	[Token(Token = "0x20002CA")]
	public class AsyncUtilTests : MonoBehaviour
	{
		[Token(Token = "0x20002CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x342D0", Offset = "0x342D0")]
		private sealed class _003CRunAsyncFromCoroutineTest_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40011D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40011D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40011D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x1700027C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60012D1")]
				[Address(RVA = "0x13337FC", Offset = "0x13337FC", VA = "0x13337FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700027D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60012D3")]
				[Address(RVA = "0x1333844", Offset = "0x1333844", VA = "0x1333844", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60012CE")]
			[Address(RVA = "0x1333618", Offset = "0x1333618", VA = "0x1333618")]
			[DebuggerHidden]
			public _003CRunAsyncFromCoroutineTest_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60012CF")]
			[Address(RVA = "0x1333644", Offset = "0x1333644", VA = "0x1333644", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60012D0")]
			[Address(RVA = "0x1333648", Offset = "0x1333648", VA = "0x1333648", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60012D1")]
			[Address(RVA = "0x13337FC", Offset = "0x13337FC", VA = "0x13337FC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60012D2")]
			[Address(RVA = "0x1333804", Offset = "0x1333804", VA = "0x1333804", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60012D3")]
			[Address(RVA = "0x1333844", Offset = "0x1333844", VA = "0x1333844", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x342E0", Offset = "0x342E0")]
		private struct _003CRunMultipleThreadsTestAsync_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40011D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40011D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40011D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x40011D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x40011D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x40011DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private object _003C_003Eu__3;

			[Token(Token = "0x60012D4")]
			[Address(RVA = "0x1334B5C", Offset = "0x1334B5C", VA = "0x1334B5C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012D5")]
			[Address(RVA = "0x13351F8", Offset = "0x13351F8", VA = "0x13351F8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x342F0", Offset = "0x342F0")]
		private struct _003CRunMultipleThreadsTestAsyncWait_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40011DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40011DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40011DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x40011DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60012D6")]
			[Address(RVA = "0x1335204", Offset = "0x1335204", VA = "0x1335204", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012D7")]
			[Address(RVA = "0x13354B0", Offset = "0x13354B0", VA = "0x13354B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34300", Offset = "0x34300")]
		private struct _003CRunAsyncFromCoroutineTest2_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40011DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40011E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40011E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60012D8")]
			[Address(RVA = "0x13333D8", Offset = "0x13333D8", VA = "0x13333D8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012D9")]
			[Address(RVA = "0x133360C", Offset = "0x133360C", VA = "0x133360C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34310", Offset = "0x34310")]
		private struct _003CRunWwwAsync_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40011E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40011E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40011E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60012DA")]
			[Address(RVA = "0x1335E0C", Offset = "0x1335E0C", VA = "0x1335E0C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012DB")]
			[Address(RVA = "0x1336164", Offset = "0x1336164", VA = "0x1336164", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34320", Offset = "0x34320")]
		private struct _003CRunOpenNotepadTestAsync_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40011E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40011E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40011E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter<int> _003C_003Eu__1;

			[Token(Token = "0x60012DC")]
			[Address(RVA = "0x13354BC", Offset = "0x13354BC", VA = "0x13354BC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012DD")]
			[Address(RVA = "0x13356F8", Offset = "0x13356F8", VA = "0x13356F8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34330", Offset = "0x34330")]
		private struct _003CRunUnhandledExceptionTestAsync_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40011E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40011E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40011EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x40011EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60012DE")]
			[Address(RVA = "0x1335C6C", Offset = "0x1335C6C", VA = "0x1335C6C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012DF")]
			[Address(RVA = "0x1335E00", Offset = "0x1335E00", VA = "0x1335E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34340", Offset = "0x34340")]
		private struct _003CRunTryCatchExceptionTestAsync_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40011EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40011ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40011EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x40011EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60012E0")]
			[Address(RVA = "0x133598C", Offset = "0x133598C", VA = "0x133598C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012E1")]
			[Address(RVA = "0x1335C60", Offset = "0x1335C60", VA = "0x1335C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34350", Offset = "0x34350")]
		private struct _003CNestedRunAsync_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40011F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40011F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40011F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60012E2")]
			[Address(RVA = "0x13331D4", Offset = "0x13331D4", VA = "0x13331D4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012E3")]
			[Address(RVA = "0x13333CC", Offset = "0x13333CC", VA = "0x13333CC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34360", Offset = "0x34360")]
		private struct _003CWaitThenThrowException_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x40011F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40011F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40011F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60012E4")]
			[Address(RVA = "0x13365FC", Offset = "0x13365FC", VA = "0x13365FC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012E5")]
			[Address(RVA = "0x13367F4", Offset = "0x13367F4", VA = "0x13367F4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34370", Offset = "0x34370")]
		private struct _003CRunAsyncOperationAsync_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40011F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40011F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40011F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x40011F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60012E6")]
			[Address(RVA = "0x133384C", Offset = "0x133384C", VA = "0x133384C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012E7")]
			[Address(RVA = "0x1333A10", Offset = "0x1333A10", VA = "0x1333A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34380", Offset = "0x34380")]
		private struct _003CInstantiateAssetBundleAsync_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x40011FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40011FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40011FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x40011FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string abUrl;

			[Token(Token = "0x40011FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string assetName;

			[Token(Token = "0x40011FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AssetBundle _003CassetBundle_003E5__2;

			[Token(Token = "0x4001200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<byte[]> _003C_003Eu__1;

			[Token(Token = "0x4001201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private object _003C_003Eu__2;

			[Token(Token = "0x60012E8")]
			[Address(RVA = "0x1332BD4", Offset = "0x1332BD4", VA = "0x1332BD4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012E9")]
			[Address(RVA = "0x13331C8", Offset = "0x13331C8", VA = "0x13331C8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34390", Offset = "0x34390")]
		private struct _003CDownloadRawDataAsync_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4001202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

			[Token(Token = "0x4001204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x4001205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest _003Crequest_003E5__2;

			[Token(Token = "0x4001206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60012EA")]
			[Address(RVA = "0x13325C8", Offset = "0x13325C8", VA = "0x13325C8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012EB")]
			[Address(RVA = "0x1332860", Offset = "0x1332860", VA = "0x1332860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x343A0", Offset = "0x343A0")]
		private struct _003CRunIEnumeratorTryCatchExceptionAsync_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4001207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x400120A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60012EC")]
			[Address(RVA = "0x13342AC", Offset = "0x13342AC", VA = "0x13342AC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012ED")]
			[Address(RVA = "0x1334608", Offset = "0x1334608", VA = "0x1334608", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x343B0", Offset = "0x343B0")]
		private struct _003CRunIEnumeratorUnhandledExceptionAsync_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x400120B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400120C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400120D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x400120E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60012EE")]
			[Address(RVA = "0x1334614", Offset = "0x1334614", VA = "0x1334614", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012EF")]
			[Address(RVA = "0x1334838", Offset = "0x1334838", VA = "0x1334838", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20002DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x343C0", Offset = "0x343C0")]
		private sealed class _003CWaitThenThrow_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400120F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x1700027E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60012F3")]
				[Address(RVA = "0x13365AC", Offset = "0x13365AC", VA = "0x13365AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700027F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60012F5")]
				[Address(RVA = "0x13365F4", Offset = "0x13365F4", VA = "0x13365F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60012F0")]
			[Address(RVA = "0x133650C", Offset = "0x133650C", VA = "0x133650C")]
			[DebuggerHidden]
			public _003CWaitThenThrow_003Ed__22(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60012F1")]
			[Address(RVA = "0x1336538", Offset = "0x1336538", VA = "0x1336538", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60012F2")]
			[Address(RVA = "0x133653C", Offset = "0x133653C", VA = "0x133653C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60012F3")]
			[Address(RVA = "0x13365AC", Offset = "0x13365AC", VA = "0x13365AC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60012F4")]
			[Address(RVA = "0x13365B4", Offset = "0x13365B4", VA = "0x13365B4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60012F5")]
			[Address(RVA = "0x13365F4", Offset = "0x13365F4", VA = "0x13365F4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20002DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x343D0", Offset = "0x343D0")]
		private sealed class _003CWaitThenThrowNested_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000280")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60012F9")]
				[Address(RVA = "0x133695C", Offset = "0x133695C", VA = "0x133695C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000281")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60012FB")]
				[Address(RVA = "0x13369A4", Offset = "0x13369A4", VA = "0x13369A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60012F6")]
			[Address(RVA = "0x1336800", Offset = "0x1336800", VA = "0x1336800")]
			[DebuggerHidden]
			public _003CWaitThenThrowNested_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60012F7")]
			[Address(RVA = "0x133682C", Offset = "0x133682C", VA = "0x133682C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60012F8")]
			[Address(RVA = "0x1336830", Offset = "0x1336830", VA = "0x1336830", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60012F9")]
			[Address(RVA = "0x133695C", Offset = "0x133695C", VA = "0x133695C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60012FA")]
			[Address(RVA = "0x1336964", Offset = "0x1336964", VA = "0x1336964", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60012FB")]
			[Address(RVA = "0x13369A4", Offset = "0x13369A4", VA = "0x13369A4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x343E0", Offset = "0x343E0")]
		private struct _003CRunIEnumeratorStringTestAsync_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4001214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x4001217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60012FC")]
			[Address(RVA = "0x1333CF0", Offset = "0x1333CF0", VA = "0x1333CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012FD")]
			[Address(RVA = "0x1333FD8", Offset = "0x1333FD8", VA = "0x1333FD8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x343F0", Offset = "0x343F0")]
		private struct _003CRunIEnumeratorUntypedStringTestAsync_003Ed__25 : IAsyncStateMachine
		{
			[Token(Token = "0x4001218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400121A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x400121B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60012FE")]
			[Address(RVA = "0x1334844", Offset = "0x1334844", VA = "0x1334844", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60012FF")]
			[Address(RVA = "0x1334B50", Offset = "0x1334B50", VA = "0x1334B50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34400", Offset = "0x34400")]
		private struct _003CRunIEnumeratorTestAsync_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x400121C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400121D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400121E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x400121F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6001300")]
			[Address(RVA = "0x1333FE4", Offset = "0x1333FE4", VA = "0x1333FE4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6001301")]
			[Address(RVA = "0x13342A0", Offset = "0x13342A0", VA = "0x13342A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20002DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34410", Offset = "0x34410")]
		private sealed class _003CWaitForString_003Ed__27 : IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string _003C_003E2__current;

			[Token(Token = "0x4001222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float _003CstartTime_003E5__2;

			[Token(Token = "0x17000282")]
			private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
			{
				[Token(Token = "0x6001305")]
				[Address(RVA = "0x1336384", Offset = "0x1336384", VA = "0x1336384", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000283")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001307")]
				[Address(RVA = "0x13363CC", Offset = "0x13363CC", VA = "0x13363CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001302")]
			[Address(RVA = "0x1336288", Offset = "0x1336288", VA = "0x1336288")]
			[DebuggerHidden]
			public _003CWaitForString_003Ed__27(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6001303")]
			[Address(RVA = "0x13362B4", Offset = "0x13362B4", VA = "0x13362B4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6001304")]
			[Address(RVA = "0x13362B8", Offset = "0x13362B8", VA = "0x13362B8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001305")]
			[Address(RVA = "0x1336384", Offset = "0x1336384", VA = "0x1336384", Slot = "4")]
			[DebuggerHidden]
			private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001306")]
			[Address(RVA = "0x133638C", Offset = "0x133638C", VA = "0x133638C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001307")]
			[Address(RVA = "0x13363CC", Offset = "0x13363CC", VA = "0x13363CC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20002E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34420", Offset = "0x34420")]
		private sealed class _003CWaitForStringUntyped_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x17000284")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600130B")]
				[Address(RVA = "0x13364BC", Offset = "0x13364BC", VA = "0x13364BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000285")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600130D")]
				[Address(RVA = "0x1336504", Offset = "0x1336504", VA = "0x1336504", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001308")]
			[Address(RVA = "0x13363D4", Offset = "0x13363D4", VA = "0x13363D4")]
			[DebuggerHidden]
			public _003CWaitForStringUntyped_003Ed__28(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6001309")]
			[Address(RVA = "0x1336400", Offset = "0x1336400", VA = "0x1336400", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600130A")]
			[Address(RVA = "0x1336404", Offset = "0x1336404", VA = "0x1336404", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600130B")]
			[Address(RVA = "0x13364BC", Offset = "0x13364BC", VA = "0x13364BC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600130C")]
			[Address(RVA = "0x13364C4", Offset = "0x13364C4", VA = "0x13364C4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600130D")]
			[Address(RVA = "0x1336504", Offset = "0x1336504", VA = "0x1336504", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20002E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34430", Offset = "0x34430")]
		private sealed class _003CWaitABit_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000286")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6001311")]
				[Address(RVA = "0x1336238", Offset = "0x1336238", VA = "0x1336238", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000287")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001313")]
				[Address(RVA = "0x1336280", Offset = "0x1336280", VA = "0x1336280", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600130E")]
			[Address(RVA = "0x1336170", Offset = "0x1336170", VA = "0x1336170")]
			[DebuggerHidden]
			public _003CWaitABit_003Ed__29(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600130F")]
			[Address(RVA = "0x133619C", Offset = "0x133619C", VA = "0x133619C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6001310")]
			[Address(RVA = "0x13361A0", Offset = "0x13361A0", VA = "0x13361A0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001311")]
			[Address(RVA = "0x1336238", Offset = "0x1336238", VA = "0x1336238", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001312")]
			[Address(RVA = "0x1336240", Offset = "0x1336240", VA = "0x1336240", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001313")]
			[Address(RVA = "0x1336280", Offset = "0x1336280", VA = "0x1336280", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34440", Offset = "0x34440")]
		private struct _003CRunReturnValueTestAsync_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x4001228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400122A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests _003C_003E4__this;

			[Token(Token = "0x400122B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<string> _003C_003Eu__1;

			[Token(Token = "0x6001314")]
			[Address(RVA = "0x1335704", Offset = "0x1335704", VA = "0x1335704", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6001315")]
			[Address(RVA = "0x1335980", Offset = "0x1335980", VA = "0x1335980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34450", Offset = "0x34450")]
		private struct _003CGetValueExampleAsync_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x400122C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400122D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			[Token(Token = "0x400122E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6001316")]
			[Address(RVA = "0x13328BC", Offset = "0x13328BC", VA = "0x13328BC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6001317")]
			[Address(RVA = "0x1332B78", Offset = "0x1332B78", VA = "0x1332B78", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34460", Offset = "0x34460")]
		private struct _003CRunAwaitSecondsTestAsync_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x400122F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6001318")]
			[Address(RVA = "0x1333A1C", Offset = "0x1333A1C", VA = "0x1333A1C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6001319")]
			[Address(RVA = "0x1333CE4", Offset = "0x1333CE4", VA = "0x1333CE4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40011CE")]
		private const string AssetBundleSampleUrl = "http://www.stevevermeulen.com/wp-content/uploads/2017/09/teapot.unity3d";

		[Token(Token = "0x40011CF")]
		private const string AssetBundleSampleAssetName = "Teapot";

		[Token(Token = "0x40011D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TestButtonHandler.Settings _buttonSettings;

		[Token(Token = "0x40011D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TestButtonHandler _buttonHandler;

		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x12F1740", Offset = "0x12F1740", VA = "0x12F1740")]
		public void Awake()
		{
		}

		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x12F17AC", Offset = "0x12F17AC", VA = "0x12F17AC")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x12F2B84", Offset = "0x12F2B84", VA = "0x12F2B84")]
		private IEnumerator RunAsyncFromCoroutineTest()
		{
			return null;
		}

		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x12F2BF8", Offset = "0x12F2BF8", VA = "0x12F2BF8")]
		private Task RunMultipleThreadsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60012B4")]
		[Address(RVA = "0x12F2CD8", Offset = "0x12F2CD8", VA = "0x12F2CD8")]
		private Task RunMultipleThreadsTestAsyncWait()
		{
			return null;
		}

		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x12F2DB4", Offset = "0x12F2DB4", VA = "0x12F2DB4")]
		private void PrintCurrentThreadContext([Optional] string prefix)
		{
		}

		[Token(Token = "0x60012B6")]
		[Address(RVA = "0x12F2F38", Offset = "0x12F2F38", VA = "0x12F2F38")]
		private Task RunAsyncFromCoroutineTest2()
		{
			return null;
		}

		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x12F2AB8", Offset = "0x12F2AB8", VA = "0x12F2AB8")]
		private Task RunWwwAsync()
		{
			return null;
		}

		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x12F29EC", Offset = "0x12F29EC", VA = "0x12F29EC")]
		private Task RunOpenNotepadTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x12F23E8", Offset = "0x12F23E8", VA = "0x12F23E8")]
		private Task RunUnhandledExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60012BA")]
		[Address(RVA = "0x12F230C", Offset = "0x12F230C", VA = "0x12F230C")]
		private Task RunTryCatchExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60012BB")]
		[Address(RVA = "0x12F3004", Offset = "0x12F3004", VA = "0x12F3004")]
		private Task NestedRunAsync()
		{
			return null;
		}

		[Token(Token = "0x60012BC")]
		[Address(RVA = "0x12F30D0", Offset = "0x12F30D0", VA = "0x12F30D0")]
		private Task WaitThenThrowException()
		{
			return null;
		}

		[Token(Token = "0x60012BD")]
		[Address(RVA = "0x12F2910", Offset = "0x12F2910", VA = "0x12F2910")]
		private Task RunAsyncOperationAsync()
		{
			return null;
		}

		[Token(Token = "0x60012BE")]
		[Address(RVA = "0x12F319C", Offset = "0x12F319C", VA = "0x12F319C")]
		private Task InstantiateAssetBundleAsync(string abUrl, string assetName)
		{
			return null;
		}

		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x12F3290", Offset = "0x12F3290", VA = "0x12F3290")]
		private Task<byte[]> DownloadRawDataAsync(string url)
		{
			return null;
		}

		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x12F2834", Offset = "0x12F2834", VA = "0x12F2834")]
		private Task RunIEnumeratorTryCatchExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x12F2758", Offset = "0x12F2758", VA = "0x12F2758")]
		private Task RunIEnumeratorUnhandledExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x60012C2")]
		[Address(RVA = "0x12F33A0", Offset = "0x12F33A0", VA = "0x12F33A0")]
		private IEnumerator WaitThenThrow()
		{
			return null;
		}

		[Token(Token = "0x60012C3")]
		[Address(RVA = "0x12F3414", Offset = "0x12F3414", VA = "0x12F3414")]
		private IEnumerator WaitThenThrowNested()
		{
			return null;
		}

		[Token(Token = "0x60012C4")]
		[Address(RVA = "0x12F267C", Offset = "0x12F267C", VA = "0x12F267C")]
		private Task RunIEnumeratorStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60012C5")]
		[Address(RVA = "0x12F25A0", Offset = "0x12F25A0", VA = "0x12F25A0")]
		private Task RunIEnumeratorUntypedStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60012C6")]
		[Address(RVA = "0x12F24C4", Offset = "0x12F24C4", VA = "0x12F24C4")]
		private Task RunIEnumeratorTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60012C7")]
		[Address(RVA = "0x12F3470", Offset = "0x12F3470", VA = "0x12F3470")]
		private IEnumerator<string> WaitForString()
		{
			return null;
		}

		[Token(Token = "0x60012C8")]
		[Address(RVA = "0x12F34CC", Offset = "0x12F34CC", VA = "0x12F34CC")]
		private IEnumerator WaitForStringUntyped()
		{
			return null;
		}

		[Token(Token = "0x60012C9")]
		[Address(RVA = "0x12F3540", Offset = "0x12F3540", VA = "0x12F3540")]
		private IEnumerator WaitABit()
		{
			return null;
		}

		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x12F2230", Offset = "0x12F2230", VA = "0x12F2230")]
		private Task RunReturnValueTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x12F359C", Offset = "0x12F359C", VA = "0x12F359C")]
		private Task<string> GetValueExampleAsync()
		{
			return null;
		}

		[Token(Token = "0x60012CC")]
		[Address(RVA = "0x12F20CC", Offset = "0x12F20CC", VA = "0x12F20CC")]
		private Task RunAwaitSecondsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x12F3698", Offset = "0x12F3698", VA = "0x12F3698")]
		public AsyncUtilTests()
		{
		}
	}
}
