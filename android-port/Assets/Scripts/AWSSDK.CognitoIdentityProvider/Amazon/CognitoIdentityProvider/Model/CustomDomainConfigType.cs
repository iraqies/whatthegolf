using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CustomDomainConfigType
	{
		private string _certificateArn;

		[AWSProperty]
		public string CertificateArn
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetCertificateArn()
		{
			return false;
		}
	}
}
