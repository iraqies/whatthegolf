using System;
using System.Collections.Generic;
using System.Net;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.Internal
{
	[Token(Token = "0x20011BC")]
	public class CallRequestContainer
	{
		[Token(Token = "0x4005F51")]
		[FieldOffset(Offset = "0x10")]
		public HttpRequestState HttpState;

		[Token(Token = "0x4005F52")]
		[FieldOffset(Offset = "0x18")]
		public HttpWebRequest HttpRequest;

		[Token(Token = "0x4005F53")]
		[FieldOffset(Offset = "0x20")]
		public string ApiEndpoint;

		[Token(Token = "0x4005F54")]
		[FieldOffset(Offset = "0x28")]
		public string FullUrl;

		[Token(Token = "0x4005F55")]
		[FieldOffset(Offset = "0x30")]
		public byte[] Payload;

		[Token(Token = "0x4005F56")]
		[FieldOffset(Offset = "0x38")]
		public string JsonResponse;

		[Token(Token = "0x4005F57")]
		[FieldOffset(Offset = "0x40")]
		public PlayFabRequestCommon ApiRequest;

		[Token(Token = "0x4005F58")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, string> RequestHeaders;

		[Token(Token = "0x4005F59")]
		[FieldOffset(Offset = "0x50")]
		public PlayFabResultCommon ApiResult;

		[Token(Token = "0x4005F5A")]
		[FieldOffset(Offset = "0x58")]
		public PlayFabError Error;

		[Token(Token = "0x4005F5B")]
		[FieldOffset(Offset = "0x60")]
		public Action DeserializeResultJson;

		[Token(Token = "0x4005F5C")]
		[FieldOffset(Offset = "0x68")]
		public Action InvokeSuccessCallback;

		[Token(Token = "0x4005F5D")]
		[FieldOffset(Offset = "0x70")]
		public Action<PlayFabError> ErrorCallback;

		[Token(Token = "0x4005F5E")]
		[FieldOffset(Offset = "0x78")]
		public object CustomData;

		[Token(Token = "0x4005F5F")]
		[FieldOffset(Offset = "0x80")]
		public PlayFabApiSettings settings;

		[Token(Token = "0x4005F60")]
		[FieldOffset(Offset = "0x88")]
		public PlayFabAuthenticationContext context;

		[Token(Token = "0x4005F61")]
		[FieldOffset(Offset = "0x90")]
		public IPlayFabInstanceApi instanceApi;

		[Token(Token = "0x600510A")]
		[Address(RVA = "0x17E42B0", Offset = "0x17E42B0", VA = "0x17E42B0")]
		public CallRequestContainer()
		{
		}
	}
}
