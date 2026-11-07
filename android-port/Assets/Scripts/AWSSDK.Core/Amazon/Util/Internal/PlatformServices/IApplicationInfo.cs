using Il2CppDummyDll;

namespace Amazon.Util.Internal.PlatformServices
{
	[Token(Token = "0x200008B")]
	public interface IApplicationInfo
	{
		[Token(Token = "0x17000143")]
		string AppTitle
		{
			[Token(Token = "0x600054B")]
			get;
		}

		[Token(Token = "0x17000144")]
		string AppVersionName
		{
			[Token(Token = "0x600054C")]
			get;
		}

		[Token(Token = "0x17000145")]
		string AppVersionCode
		{
			[Token(Token = "0x600054D")]
			get;
		}

		[Token(Token = "0x17000146")]
		string PackageName
		{
			[Token(Token = "0x600054E")]
			get;
		}
	}
}
