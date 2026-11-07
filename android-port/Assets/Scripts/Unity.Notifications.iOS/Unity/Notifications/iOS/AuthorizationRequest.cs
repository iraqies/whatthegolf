using System;

namespace Unity.Notifications.iOS
{
	public class AuthorizationRequest : IDisposable
	{
		private bool m_IsFinished;

		private bool m_Granted;

		private string m_Error;

		private string m_DeviceToken;

		public bool IsFinished
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public bool Granted
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public string Error
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string DeviceToken
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		static AuthorizationRequest()
		{
		}

		public AuthorizationRequest(AuthorizationOption authorizationOption, bool registerForRemoteNotifications)
		{
		}

		private void OnAuthorizationRequestCompleted(iOSAuthorizationRequestData requestData)
		{
		}

		internal static void OnAuthorizationRequestCompleted(IntPtr request, iOSAuthorizationRequestData requestData)
		{
		}

		public void Dispose()
		{
		}
	}
}
