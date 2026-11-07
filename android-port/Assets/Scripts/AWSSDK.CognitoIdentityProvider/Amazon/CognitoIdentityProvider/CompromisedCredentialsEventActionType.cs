using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class CompromisedCredentialsEventActionType : ConstantClass
	{
		public static readonly CompromisedCredentialsEventActionType BLOCK;

		public static readonly CompromisedCredentialsEventActionType NO_ACTION;

		public CompromisedCredentialsEventActionType(string value)
			: base(null)
		{
		}

		public static CompromisedCredentialsEventActionType FindValue(string value)
		{
			return null;
		}

		public static implicit operator CompromisedCredentialsEventActionType(string value)
		{
			return null;
		}
	}
}
