using System;
using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x2001189")]
	public interface ITransportPlugin : IPlayFabPlugin
	{
		[Token(Token = "0x1700089C")]
		bool IsInitialized
		{
			[Token(Token = "0x600501D")]
			get;
		}

		[Token(Token = "0x600501E")]
		void Initialize();

		[Token(Token = "0x600501F")]
		void Update();

		[Token(Token = "0x6005020")]
		void OnDestroy();

		[Token(Token = "0x6005021")]
		void SimpleGetCall(string fullUrl, Action<byte[]> successCallback, Action<string> errorCallback);

		[Token(Token = "0x6005022")]
		void SimplePutCall(string fullUrl, byte[] payload, Action<byte[]> successCallback, Action<string> errorCallback);

		[Token(Token = "0x6005023")]
		void SimplePostCall(string fullUrl, byte[] payload, Action<byte[]> successCallback, Action<string> errorCallback);

		[Token(Token = "0x6005024")]
		void MakeApiCall(object reqContainer);

		[Token(Token = "0x6005025")]
		int GetPendingMessages();
	}
}
