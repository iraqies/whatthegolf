using Il2CppDummyDll;

[Token(Token = "0x20005D3")]
public interface IGifRecorder
{
	[Token(Token = "0x6001A87")]
	void StartRecording(float gifDuration, GifMoment moment);

	[Token(Token = "0x6001A88")]
	void Stop(bool save);

	[Token(Token = "0x6001A89")]
	void Dispose();
}
