using Il2CppDummyDll;

namespace Triband.Analytics
{
	[Token(Token = "0x200111C")]
	public enum ConditionType
	{
		[Token(Token = "0x4005A96")]
		Unknown = 0,
		[Token(Token = "0x4005A97")]
		FailedToReportScoreToLeaderboard = 1,
		[Token(Token = "0x4005A98")]
		ErrorRetrievingLeaderboard = 2,
		[Token(Token = "0x4005A99")]
		NullReferenceException = 3,
		[Token(Token = "0x4005A9A")]
		RemoteProviderExceptionInvalidPathInAssetBundleProvider = 4,
		[Token(Token = "0x4005A9B")]
		GameKitException = 5,
		[Token(Token = "0x4005A9C")]
		FailedToReadDataForTheAssetBundle = 6,
		[Token(Token = "0x4005A9D")]
		CouldNotDownloadAssetBundles = 7,
		[Token(Token = "0x4005A9E")]
		AddressableAssetsInvalidKeyException = 8,
		[Token(Token = "0x4005A9F")]
		ArgumentException = 9,
		[Token(Token = "0x4005AA0")]
		ErrorReadingBytesFromSave = 10,
		[Token(Token = "0x4005AA1")]
		HttpRequestException = 11,
		[Token(Token = "0x4005AA2")]
		ExceptionWhileTryingToSaveDiskFull = 12,
		[Token(Token = "0x4005AA3")]
		InvalidOperationException = 13,
		[Token(Token = "0x4005AA4")]
		AmazonKinesisException = 14,
		[Token(Token = "0x4005AA5")]
		FMODFailedToInitializeTheOutputDevice = 15,
		[Token(Token = "0x4005AA6")]
		AmazonCognitoException = 16,
		[Token(Token = "0x4005AA7")]
		AudioClipCouldNotBePlayedFMODError = 17
	}
}
