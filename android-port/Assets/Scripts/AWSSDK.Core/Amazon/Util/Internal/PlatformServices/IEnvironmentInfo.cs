using Il2CppDummyDll;

namespace Amazon.Util.Internal.PlatformServices
{
	[Token(Token = "0x200008E")]
	public interface IEnvironmentInfo
	{
		[Token(Token = "0x17000147")]
		string Platform
		{
			[Token(Token = "0x6000552")]
			get;
		}

		[Token(Token = "0x17000148")]
		string PlatformVersion
		{
			[Token(Token = "0x6000553")]
			get;
		}

		[Token(Token = "0x17000149")]
		string PclPlatform
		{
			[Token(Token = "0x6000554")]
			get;
		}

		[Token(Token = "0x1700014A")]
		string PlatformUserAgent
		{
			[Token(Token = "0x6000555")]
			get;
		}

		[Token(Token = "0x1700014B")]
		string FrameworkUserAgent
		{
			[Token(Token = "0x6000556")]
			get;
		}

		[Token(Token = "0x1700014C")]
		string Model
		{
			[Token(Token = "0x6000557")]
			get;
		}

		[Token(Token = "0x1700014D")]
		string Make
		{
			[Token(Token = "0x6000558")]
			get;
		}

		[Token(Token = "0x1700014E")]
		string Locale
		{
			[Token(Token = "0x6000559")]
			get;
		}
	}
}
