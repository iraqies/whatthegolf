using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using PlayFab.Public;
using PlayFab.SharedModels;
using UnityEngine;

namespace PlayFab.Internal
{
	[Token(Token = "0x20011BD")]
	public class PlayFabHttp : SingletonMonoBehaviour<PlayFabHttp>
	{
		[Token(Token = "0x20011BE")]
		public delegate void ApiProcessingEvent<in TEventArgs>(TEventArgs e);

		[Token(Token = "0x20011BF")]
		public delegate void ApiProcessErrorEvent(PlayFabRequestCommon request, PlayFabError error);

		[Token(Token = "0x20011C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4826C", Offset = "0x4826C")]
		private sealed class _003CSendScreenTimeEvents_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005F6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005F6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005F6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float secondsBetweenBatches;

			[Token(Token = "0x4005F6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private WaitForSeconds _003Cdelay_003E5__2;

			[Token(Token = "0x170008BA")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005134")]
				[Address(RVA = "0x1827B9C", Offset = "0x1827B9C", VA = "0x1827B9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170008BB")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005136")]
				[Address(RVA = "0x1827BE4", Offset = "0x1827BE4", VA = "0x1827BE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005131")]
			[Address(RVA = "0x18279CC", Offset = "0x18279CC", VA = "0x18279CC")]
			[DebuggerHidden]
			public _003CSendScreenTimeEvents_003Ed__17(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005132")]
			[Address(RVA = "0x18279F8", Offset = "0x18279F8", VA = "0x18279F8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005133")]
			[Address(RVA = "0x18279FC", Offset = "0x18279FC", VA = "0x18279FC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005134")]
			[Address(RVA = "0x1827B9C", Offset = "0x1827B9C", VA = "0x1827B9C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005135")]
			[Address(RVA = "0x1827BA4", Offset = "0x1827BA4", VA = "0x1827BA4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005136")]
			[Address(RVA = "0x1827BE4", Offset = "0x1827BE4", VA = "0x1827BE4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20011C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4827C", Offset = "0x4827C")]
		private sealed class _003C_003Ec__DisplayClass23_0<TResult> where TResult : PlayFabResultCommon
		{
			[Token(Token = "0x4005F6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallRequestContainer reqContainer;

			[Token(Token = "0x4005F70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ISerializerPlugin serializer;

			[Token(Token = "0x4005F71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<TResult> resultCallback;

			[Token(Token = "0x6005137")]
			public _003C_003Ec__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6005138")]
			internal void _003C_MakeApiCall_003Eb__0()
			{
			}

			[Token(Token = "0x6005139")]
			internal void _003C_MakeApiCall_003Eb__1()
			{
			}
		}

		[Token(Token = "0x4005F62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<CallRequestContainer> _apiCallQueue;

		[Token(Token = "0x4005F63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x574DC", Offset = "0x574DC")]
		private static ApiProcessingEvent<ApiProcessingEventArgs> m_ApiProcessingEventHandler;

		[Token(Token = "0x4005F64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x574EC", Offset = "0x574EC")]
		private static ApiProcessErrorEvent m_ApiProcessingErrorEventHandler;

		[Token(Token = "0x4005F65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Dictionary<string, string> GlobalHeaderInjection;

		[Token(Token = "0x4005F66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static IPlayFabLogger _logger;

		[Token(Token = "0x4005F67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static IScreenTimeTracker screenTimeTracker;

		[Token(Token = "0x4005F68")]
		private const float delayBetweenBatches = 5f;

		[Token(Token = "0x4005F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Queue<IEnumerator> _injectedCoroutines;

		[Token(Token = "0x4005F6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Queue<Action> _injectedAction;

		[Token(Token = "0x14000085")]
		public static event ApiProcessingEvent<ApiProcessingEventArgs> ApiProcessingEventHandler
		{
			[Token(Token = "0x600510B")]
			[Address(RVA = "0x15EBAE0", Offset = "0x15EBAE0", VA = "0x15EBAE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x701F8", Offset = "0x701F8")]
			add
			{
			}
			[Token(Token = "0x600510C")]
			[Address(RVA = "0x15EBBEC", Offset = "0x15EBBEC", VA = "0x15EBBEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70208", Offset = "0x70208")]
			remove
			{
			}
		}

		[Token(Token = "0x14000086")]
		public static event ApiProcessErrorEvent ApiProcessingErrorEventHandler
		{
			[Token(Token = "0x600510D")]
			[Address(RVA = "0x15EBCF8", Offset = "0x15EBCF8", VA = "0x15EBCF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70218", Offset = "0x70218")]
			add
			{
			}
			[Token(Token = "0x600510E")]
			[Address(RVA = "0x15EBE04", Offset = "0x15EBE04", VA = "0x15EBE04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70228", Offset = "0x70228")]
			remove
			{
			}
		}

		[Token(Token = "0x600510F")]
		[Address(RVA = "0x15EBF10", Offset = "0x15EBF10", VA = "0x15EBF10")]
		public static int GetPendingMessages()
		{
			return default;
		}

		[Token(Token = "0x6005110")]
		[Address(RVA = "0x15EC0AC", Offset = "0x15EC0AC", VA = "0x15EC0AC")]
		public static void InitializeHttp()
		{
		}

		[Token(Token = "0x6005111")]
		[Address(RVA = "0x15EC3AC", Offset = "0x15EC3AC", VA = "0x15EC3AC")]
		public static void InitializeLogger([Optional] IPlayFabLogger setLogger)
		{
		}

		[Token(Token = "0x6005112")]
		[Address(RVA = "0x15EC570", Offset = "0x15EC570", VA = "0x15EC570")]
		public static void InitializeScreenTimeTracker(string entityId, string entityType, string playFabUserId)
		{
		}

		[Token(Token = "0x6005113")]
		[Address(RVA = "0x15EC6FC", Offset = "0x15EC6FC", VA = "0x15EC6FC")]
		private static IEnumerator SendScreenTimeEvents(float secondsBetweenBatches)
		{
			return null;
		}

		[Token(Token = "0x6005114")]
		[Address(RVA = "0x15EC770", Offset = "0x15EC770", VA = "0x15EC770")]
		public static void SimpleGetCall(string fullUrl, Action<byte[]> successCallback, Action<string> errorCallback)
		{
		}

		[Token(Token = "0x6005115")]
		[Address(RVA = "0x15EC8DC", Offset = "0x15EC8DC", VA = "0x15EC8DC")]
		public static void SimplePutCall(string fullUrl, byte[] payload, Action<byte[]> successCallback, Action<string> errorCallback)
		{
		}

		[Token(Token = "0x6005116")]
		[Address(RVA = "0x15ECA58", Offset = "0x15ECA58", VA = "0x15ECA58")]
		public static void SimplePostCall(string fullUrl, byte[] payload, Action<byte[]> successCallback, Action<string> errorCallback)
		{
		}

		[Token(Token = "0x6005117")]
		protected internal static void MakeApiCall<TResult>(string apiEndpoint, PlayFabRequestCommon request, AuthType authType, Action<TResult> resultCallback, Action<PlayFabError> errorCallback, [Optional] object customData, [Optional] Dictionary<string, string> extraHeaders, [Optional] PlayFabAuthenticationContext authenticationContext, [Optional] PlayFabApiSettings apiSettings, [Optional] IPlayFabInstanceApi instanceApi) where TResult : PlayFabResultCommon
		{
		}

		[Token(Token = "0x6005118")]
		protected internal static void MakeApiCallWithFullUri<TResult>(string fullUri, PlayFabRequestCommon request, AuthType authType, Action<TResult> resultCallback, Action<PlayFabError> errorCallback, [Optional] object customData, [Optional] Dictionary<string, string> extraHeaders, [Optional] PlayFabAuthenticationContext authenticationContext, [Optional] PlayFabApiSettings apiSettings, [Optional] IPlayFabInstanceApi instanceApi) where TResult : PlayFabResultCommon
		{
		}

		[Token(Token = "0x6005119")]
		private static void _MakeApiCall<TResult>(string apiEndpoint, string fullUrl, PlayFabRequestCommon request, AuthType authType, Action<TResult> resultCallback, Action<PlayFabError> errorCallback, object customData, Dictionary<string, string> extraHeaders, bool allowQueueing, PlayFabAuthenticationContext authenticationContext, PlayFabApiSettings apiSettings, IPlayFabInstanceApi instanceApi) where TResult : PlayFabResultCommon
		{
		}

		[Token(Token = "0x600511A")]
		[Address(RVA = "0x15ECBD4", Offset = "0x15ECBD4", VA = "0x15ECBD4")]
		internal void OnPlayFabApiResult(CallRequestContainer reqContainer)
		{
		}

		[Token(Token = "0x600511B")]
		[Address(RVA = "0x15ECE58", Offset = "0x15ECE58", VA = "0x15ECE58")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600511C")]
		[Address(RVA = "0x15ED13C", Offset = "0x15ED13C", VA = "0x15ED13C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600511D")]
		[Address(RVA = "0x15ED3B4", Offset = "0x15ED3B4", VA = "0x15ED3B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600511E")]
		[Address(RVA = "0x15ED784", Offset = "0x15ED784", VA = "0x15ED784")]
		public void OnApplicationFocus(bool isFocused)
		{
		}

		[Token(Token = "0x600511F")]
		[Address(RVA = "0x15ED938", Offset = "0x15ED938", VA = "0x15ED938")]
		public void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6005120")]
		[Address(RVA = "0x15EDAE4", Offset = "0x15EDAE4", VA = "0x15EDAE4")]
		private void Update()
		{
		}

		[Token(Token = "0x6005121")]
		[Address(RVA = "0x15EDF34", Offset = "0x15EDF34", VA = "0x15EDF34")]
		protected internal static PlayFabError GeneratePlayFabError(string apiEndpoint, string json, object customData)
		{
			return null;
		}

		[Token(Token = "0x6005122")]
		[Address(RVA = "0x15EE5A0", Offset = "0x15EE5A0", VA = "0x15EE5A0")]
		protected internal static void SendErrorEvent(PlayFabRequestCommon request, PlayFabError error)
		{
		}

		[Token(Token = "0x6005123")]
		[Address(RVA = "0x15EE71C", Offset = "0x15EE71C", VA = "0x15EE71C")]
		protected internal static void SendEvent(string apiEndpoint, PlayFabRequestCommon request, PlayFabResultCommon result, ApiProcessingEventType eventType)
		{
		}

		[Token(Token = "0x6005124")]
		[Address(RVA = "0x15EE908", Offset = "0x15EE908", VA = "0x15EE908")]
		protected internal static void ClearAllEvents()
		{
		}

		[Token(Token = "0x6005125")]
		[Address(RVA = "0x15EE96C", Offset = "0x15EE96C", VA = "0x15EE96C")]
		public void InjectInUnityThread(IEnumerator x)
		{
		}

		[Token(Token = "0x6005126")]
		[Address(RVA = "0x15EE9D0", Offset = "0x15EE9D0", VA = "0x15EE9D0")]
		public void InjectInUnityThread(Action action)
		{
		}

		[Token(Token = "0x6005127")]
		[Address(RVA = "0x15EEA34", Offset = "0x15EEA34", VA = "0x15EEA34")]
		public PlayFabHttp()
		{
		}
	}
}
