using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class AssumeRoleWithSAMLResponse : AmazonWebServiceResponse
	{
		private AssumedRoleUser _assumedRoleUser;

		private string _audience;

		private Credentials _credentials;

		private string _issuer;

		private string _nameQualifier;

		private int? _packedPolicySize;

		private string _subject;

		private string _subjectType;

		public AssumedRoleUser AssumedRoleUser
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Audience
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Credentials Credentials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Issuer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NameQualifier
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
		public int PackedPolicySize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string Subject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SubjectType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAssumedRoleUser()
		{
			return false;
		}

		internal bool IsSetAudience()
		{
			return false;
		}

		internal bool IsSetCredentials()
		{
			return false;
		}

		internal bool IsSetIssuer()
		{
			return false;
		}

		internal bool IsSetNameQualifier()
		{
			return false;
		}

		internal bool IsSetPackedPolicySize()
		{
			return false;
		}

		internal bool IsSetSubject()
		{
			return false;
		}

		internal bool IsSetSubjectType()
		{
			return false;
		}
	}
}
