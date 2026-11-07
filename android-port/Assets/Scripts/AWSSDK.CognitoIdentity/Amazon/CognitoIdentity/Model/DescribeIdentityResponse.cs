using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class DescribeIdentityResponse : AmazonWebServiceResponse
	{
		private DateTime? _creationDate;

		private string _identityId;

		private DateTime? _lastModifiedDate;

		private List<string> _logins;

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
		public string IdentityId
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

		public List<string> Logins
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

		internal bool IsSetIdentityId()
		{
			return false;
		}

		internal bool IsSetLastModifiedDate()
		{
			return false;
		}

		internal bool IsSetLogins()
		{
			return false;
		}
	}
}
