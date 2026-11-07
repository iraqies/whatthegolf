namespace Amazon.CognitoIdentityProvider.Model
{
	public class DeviceConfigurationType
	{
		private bool? _challengeRequiredOnNewDevice;

		private bool? _deviceOnlyRememberedOnUserPrompt;

		public bool ChallengeRequiredOnNewDevice
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DeviceOnlyRememberedOnUserPrompt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool IsSetChallengeRequiredOnNewDevice()
		{
			return false;
		}

		internal bool IsSetDeviceOnlyRememberedOnUserPrompt()
		{
			return false;
		}
	}
}
