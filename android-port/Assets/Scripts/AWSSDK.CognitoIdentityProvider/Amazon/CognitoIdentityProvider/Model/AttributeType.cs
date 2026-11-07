using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AttributeType
	{
		private string _name;

		private string _value;

		[AWSProperty]
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetName()
		{
			return false;
		}

		internal bool IsSetValue()
		{
			return false;
		}
	}
}
