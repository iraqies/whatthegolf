namespace Triband.Analytics
{
	public enum ConditionType
	{
		Unknown = 0,
		FailedToReportScoreToLeaderboard = 1,
		ErrorRetrievingLeaderboard = 2,
		NullReferenceException = 3,
		RemoteProviderExceptionInvalidPathInAssetBundleProvider = 4,
		GameKitException = 5,
		FailedToReadDataForTheAssetBundle = 6,
		CouldNotDownloadAssetBundles = 7,
		AddressableAssetsInvalidKeyException = 8,
		ArgumentException = 9,
		ErrorReadingBytesFromSave = 10,
		HttpRequestException = 11,
		ExceptionWhileTryingToSaveDiskFull = 12,
		InvalidOperationException = 13,
		AmazonKinesisException = 14,
		FMODFailedToInitializeTheOutputDevice = 15,
		AmazonCognitoException = 16,
		AudioClipCouldNotBePlayedFMODError = 17
	}
}
