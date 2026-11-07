using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000B0")]
	public abstract class AWSCredentials
	{
		[Token(Token = "0x60006A2")]
		public abstract ImmutableCredentials GetCredentials();

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x11BE124", Offset = "0x11BE124", VA = "0x11BE124", Slot = "5")]
		protected virtual void Validate()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x11BE128", Offset = "0x11BE128", VA = "0x11BE128", Slot = "6")]
		public virtual Task<ImmutableCredentials> GetCredentialsAsync()
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x11BE1C4", Offset = "0x11BE1C4", VA = "0x11BE1C4")]
		protected AWSCredentials()
		{
		}
	}
}
