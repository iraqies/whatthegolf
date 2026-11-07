using Il2CppDummyDll;
using Moments;

[Token(Token = "0x20005D7")]
public class StandaloneGifRecorder : IGifRecorder
{
	[Token(Token = "0x4001DB8")]
	[FieldOffset(Offset = "0x10")]
	private Moments.Recorder recorder;

	[Token(Token = "0x4001DB9")]
	[FieldOffset(Offset = "0x18")]
	private GifMoment moment;

	[Token(Token = "0x6001A9C")]
	[Address(RVA = "0x16DAD98", Offset = "0x16DAD98", VA = "0x16DAD98", Slot = "4")]
	public void StartRecording(float gifDuration, GifMoment moment)
	{
	}

	[Token(Token = "0x6001A9D")]
	[Address(RVA = "0x16DB020", Offset = "0x16DB020", VA = "0x16DB020")]
	private void OnProcessingDone()
	{
	}

	[Token(Token = "0x6001A9E")]
	[Address(RVA = "0x16DB024", Offset = "0x16DB024", VA = "0x16DB024")]
	private void OnFileSaveProgress(int id, float percent)
	{
	}

	[Token(Token = "0x6001A9F")]
	[Address(RVA = "0x16DB040", Offset = "0x16DB040", VA = "0x16DB040")]
	private void OnFileSaved(int id, string filepath)
	{
	}

	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0x16DB0B4", Offset = "0x16DB0B4", VA = "0x16DB0B4", Slot = "5")]
	public void Stop(bool save)
	{
	}

	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0x16DB124", Offset = "0x16DB124", VA = "0x16DB124", Slot = "6")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6001AA2")]
	[Address(RVA = "0x16DB1F8", Offset = "0x16DB1F8", VA = "0x16DB1F8")]
	public StandaloneGifRecorder()
	{
	}
}
