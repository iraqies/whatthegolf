using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000027")]
	public interface IMarker
	{
		[Token(Token = "0x17000089")]
		double time
		{
			[Token(Token = "0x60001C1")]
			get;
			[Token(Token = "0x60001C2")]
			set;
		}

		[Token(Token = "0x1700008A")]
		TrackAsset parent
		{
			[Token(Token = "0x60001C3")]
			get;
		}

		[Token(Token = "0x60001C4")]
		void Initialize(TrackAsset parent);
	}
}
