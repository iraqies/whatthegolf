using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x2000033")]
	public interface IObjectInitializationDataProvider
	{
		[Token(Token = "0x1700002A")]
		string Name
		{
			[Token(Token = "0x600013A")]
			get;
		}

		[Token(Token = "0x600013B")]
		ObjectInitializationData CreateObjectInitializationData();
	}
}
