using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class PreventUserExistenceErrorTypes : ConstantClass
	{
		public static readonly PreventUserExistenceErrorTypes ENABLED;

		public static readonly PreventUserExistenceErrorTypes LEGACY;

		public PreventUserExistenceErrorTypes(string value)
			: base(null)
		{
		}

		public static PreventUserExistenceErrorTypes FindValue(string value)
		{
			return null;
		}

		public static implicit operator PreventUserExistenceErrorTypes(string value)
		{
			return null;
		}
	}
}
