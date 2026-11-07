using System.Threading.Tasks;

namespace Amazon.Runtime
{
	public abstract class AWSCredentials
	{
		public abstract ImmutableCredentials GetCredentials();

		protected virtual void Validate()
		{
		}

		public virtual Task<ImmutableCredentials> GetCredentialsAsync()
		{
			return null;
		}
	}
}
