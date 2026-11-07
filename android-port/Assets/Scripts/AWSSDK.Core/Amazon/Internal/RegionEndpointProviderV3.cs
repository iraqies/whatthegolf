using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using ThirdParty.Json.LitJson;

namespace Amazon.Internal
{
	[Token(Token = "0x2000042")]
	public class RegionEndpointProviderV3 : IRegionEndpointProvider
	{
		[Token(Token = "0x400013B")]
		private const string ENDPOINT_JSON_RESOURCE = "Core.endpoints.json";

		[Token(Token = "0x400013C")]
		private const string ENDPOINT_JSON = "endpoints.json";

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x10")]
		private JsonData _root;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, IRegionEndpoint> _regionEndpointMap;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x20")]
		private object _regionEndpointMapLock;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x28")]
		private object _allRegionEndpointsLock;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x30")]
		private IEnumerable<IRegionEndpoint> _allRegionEndpoints;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x0")]
		private static JsonData _emptyDictionaryJsonData;

		[Token(Token = "0x1700008E")]
		public IEnumerable<IRegionEndpoint> AllRegionEndpoints
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x1259268", Offset = "0x1259268", VA = "0x1259268", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1257D90", Offset = "0x1257D90", VA = "0x1257D90")]
		public RegionEndpointProviderV3()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1259190", Offset = "0x1259190", VA = "0x1259190")]
		public RegionEndpointProviderV3(JsonData root)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1258F28", Offset = "0x1258F28", VA = "0x1258F28")]
		private static Stream GetEndpointJsonSourceStream()
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1259CC0", Offset = "0x1259CC0", VA = "0x1259CC0")]
		private static string GetUnknownRegionDescription(string regionName)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1259D80", Offset = "0x1259D80", VA = "0x1259D80")]
		private static bool IsRegionInPartition(string regionName, JsonData partition, out string description)
		{
			return default;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1259FC0", Offset = "0x1259FC0", VA = "0x1259FC0", Slot = "5")]
		public IRegionEndpoint GetRegionEndpoint(string regionName)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x125A6C4", Offset = "0x125A6C4", VA = "0x125A6C4")]
		private IRegionEndpoint GetNonstandardRegionEndpoint(string regionName)
		{
			return null;
		}
	}
}
