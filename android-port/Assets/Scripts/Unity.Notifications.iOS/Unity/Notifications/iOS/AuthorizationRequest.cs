using System;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000004")]
	public class AuthorizationRequest : IDisposable
	{
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x10")]
		private bool m_IsFinished;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x11")]
		private bool m_Granted;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x18")]
		private string m_Error;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x20")]
		private string m_DeviceToken;

		[Token(Token = "0x17000001")]
		public bool IsFinished
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2A41890", Offset = "0x2A41890", VA = "0x2A41890")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2A41960", Offset = "0x2A41960", VA = "0x2A41960")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public bool Granted
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2A41968", Offset = "0x2A41968", VA = "0x2A41968")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2A41A38", Offset = "0x2A41A38", VA = "0x2A41A38")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public string Error
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2A41A40", Offset = "0x2A41A40", VA = "0x2A41A40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2A41B10", Offset = "0x2A41B10", VA = "0x2A41B10")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public string DeviceToken
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2A41B18", Offset = "0x2A41B18", VA = "0x2A41B18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2A41BE8", Offset = "0x2A41BE8", VA = "0x2A41BE8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2A41BF0", Offset = "0x2A41BF0", VA = "0x2A41BF0")]
		static AuthorizationRequest()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2A41C98", Offset = "0x2A41C98", VA = "0x2A41C98")]
		public AuthorizationRequest(AuthorizationOption authorizationOption, bool registerForRemoteNotifications)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2A41CF0", Offset = "0x2A41CF0", VA = "0x2A41CF0")]
		private void OnAuthorizationRequestCompleted(iOSAuthorizationRequestData requestData)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2A41DE0", Offset = "0x2A41DE0", VA = "0x2A41DE0")]
		internal static void OnAuthorizationRequestCompleted(IntPtr request, iOSAuthorizationRequestData requestData)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2A41F84", Offset = "0x2A41F84", VA = "0x2A41F84", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
