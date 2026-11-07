using System.Collections;
using Il2CppDummyDll;

[Token(Token = "0x2000083")]
public interface IVideoPathProvider
{
	[Token(Token = "0x1700005A")]
	bool InitComplete
	{
		[Token(Token = "0x6000227")]
		get;
	}

	[Token(Token = "0x6000226")]
	IEnumerator Init();

	[Token(Token = "0x6000228")]
	string GetVideoPath(string path);

	[Token(Token = "0x6000229")]
	bool FileExists(string path);

	[Token(Token = "0x600022A")]
	IEnumerator GetVideoClipForPath(string path, VideoClipResult result);

	[Token(Token = "0x600022B")]
	void Cleanup();
}
