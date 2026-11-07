using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x200000F")]
	internal interface ICurvesOwner
	{
		[Token(Token = "0x1700002C")]
		string defaultCurvesName
		{
			[Token(Token = "0x600008F")]
			get;
		}

		[Token(Token = "0x1700002D")]
		Object asset
		{
			[Token(Token = "0x6000090")]
			get;
		}

		[Token(Token = "0x1700002E")]
		Object assetOwner
		{
			[Token(Token = "0x6000091")]
			get;
		}

		[Token(Token = "0x1700002F")]
		TrackAsset targetTrack
		{
			[Token(Token = "0x6000092")]
			get;
		}
	}
}
