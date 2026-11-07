using System;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UserImportJobType
	{
		private string _cloudWatchLogsRoleArn;

		private DateTime? _completionDate;

		private string _completionMessage;

		private DateTime? _creationDate;

		private long? _failedUsers;

		private long? _importedUsers;

		private string _jobId;

		private string _jobName;

		private string _preSignedUrl;

		private long? _skippedUsers;

		private DateTime? _startDate;

		private UserImportJobStatusType _status;

		private string _userPoolId;

		[AWSProperty]
		public string CloudWatchLogsRoleArn
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime CompletionDate
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
		public string CompletionMessage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public long FailedUsers
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long ImportedUsers
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string JobId
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
		public string JobName
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
		public string PreSignedUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long SkippedUsers
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public DateTime StartDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public UserImportJobStatusType Status
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
		public string UserPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetCloudWatchLogsRoleArn()
		{
			return false;
		}

		internal bool IsSetCompletionDate()
		{
			return false;
		}

		internal bool IsSetCompletionMessage()
		{
			return false;
		}

		internal bool IsSetCreationDate()
		{
			return false;
		}

		internal bool IsSetFailedUsers()
		{
			return false;
		}

		internal bool IsSetImportedUsers()
		{
			return false;
		}

		internal bool IsSetJobId()
		{
			return false;
		}

		internal bool IsSetJobName()
		{
			return false;
		}

		internal bool IsSetPreSignedUrl()
		{
			return false;
		}

		internal bool IsSetSkippedUsers()
		{
			return false;
		}

		internal bool IsSetStartDate()
		{
			return false;
		}

		internal bool IsSetStatus()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
