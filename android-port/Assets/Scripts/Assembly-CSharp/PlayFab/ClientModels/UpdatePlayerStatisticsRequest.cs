using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011D3")]
	public class UpdatePlayerStatisticsRequest : PlayFabRequestCommon
	{
		[Token(Token = "0x4005F99")]
		[FieldOffset(Offset = "0x18")]
		public List<StatisticUpdate> Statistics;

		[Token(Token = "0x600514E")]
		[Address(RVA = "0x173D61C", Offset = "0x173D61C", VA = "0x173D61C")]
		public UpdatePlayerStatisticsRequest()
		{
		}
	}
}
