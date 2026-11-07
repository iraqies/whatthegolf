using System;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UserPoolDescriptionType
	{
		private DateTime? _creationDate;

		private string _id;

		private LambdaConfigType _lambdaConfig;

		private DateTime? _lastModifiedDate;

		private string _name;

		private StatusType _status;

		public DateTime CreationDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string Id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LambdaConfigType LambdaConfig
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime LastModifiedDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

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

		public StatusType Status
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetCreationDate()
		{
			return false;
		}

		internal bool IsSetId()
		{
			return false;
		}

		internal bool IsSetLambdaConfig()
		{
			return false;
		}

		internal bool IsSetLastModifiedDate()
		{
			return false;
		}

		internal bool IsSetName()
		{
			return false;
		}

		internal bool IsSetStatus()
		{
			return false;
		}
	}
}
