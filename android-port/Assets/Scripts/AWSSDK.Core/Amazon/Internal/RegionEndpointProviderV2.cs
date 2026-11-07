using System.Collections.Generic;
using System.IO;
using System.Net;
using Il2CppDummyDll;
using ThirdParty.Json.LitJson;

namespace Amazon.Internal
{
	[Token(Token = "0x200003E")]
	public class RegionEndpointProviderV2 : IRegionEndpointProvider
	{
		[Token(Token = "0x200003F")]
		public class RegionEndpoint : IRegionEndpoint
		{
			[Token(Token = "0x4000129")]
			private const string REGIONS_FILE = "Core.endpoints.json";

			[Token(Token = "0x400012A")]
			private const string REGIONS_CUSTOMIZATIONS_FILE = "Core.endpoints.customizations.json";

			[Token(Token = "0x400012B")]
			private const string DEFAULT_RULE = "*/*";

			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x0")]
			private static Dictionary<string, JsonData> _documentEndpoints;

			[Token(Token = "0x400012D")]
			private const int MAX_DOWNLOAD_RETRIES = 3;

			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x8")]
			private static bool loaded;

			[Token(Token = "0x400012F")]
			[FieldOffset(Offset = "0x10")]
			private static readonly object LOCK_OBJECT;

			[Token(Token = "0x4000130")]
			[FieldOffset(Offset = "0x18")]
			private static Dictionary<string, RegionEndpoint> hashBySystemName;

			[Token(Token = "0x4000131")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x261C8", Offset = "0x261C8")]
			private string SystemName__BackingField;

			[Token(Token = "0x4000132")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x261D8", Offset = "0x261D8")]
			private string DisplayName__BackingField;

			[Token(Token = "0x17000086")]
			public static IEnumerable<RegionEndpoint> EnumerableAllRegions
			{
				[Token(Token = "0x600026D")]
				[Address(RVA = "0x1292948", Offset = "0x1292948", VA = "0x1292948")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			public string SystemName
			{
				[Token(Token = "0x6000278")]
				[Address(RVA = "0x1294658", Offset = "0x1294658", VA = "0x1294658")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27F30", Offset = "0x27F30")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000279")]
				[Address(RVA = "0x1294660", Offset = "0x1294660", VA = "0x1294660")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27F40", Offset = "0x27F40")]
				private set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public string DisplayName
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0x1294668", Offset = "0x1294668", VA = "0x1294668", Slot = "5")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27F50", Offset = "0x27F50")]
				get
				{
					return null;
				}
				[Token(Token = "0x600027B")]
				[Address(RVA = "0x1294670", Offset = "0x1294670", VA = "0x1294670")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27F60", Offset = "0x27F60")]
				private set
				{
				}
			}

			[Token(Token = "0x17000089")]
			public string RegionName
			{
				[Token(Token = "0x600027C")]
				[Address(RVA = "0x1294678", Offset = "0x1294678", VA = "0x1294678", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0x1291FC0", Offset = "0x1291FC0", VA = "0x1291FC0", Slot = "6")]
			public Amazon.RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack)
			{
				return null;
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x1292448", Offset = "0x1292448", VA = "0x1292448")]
			private JsonData GetEndpointRule(string serviceName)
			{
				return null;
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x12926CC", Offset = "0x12926CC", VA = "0x12926CC")]
			private static RegionEndpoint GetEndpoint(string systemName, string displayName)
			{
				return null;
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x1292B1C", Offset = "0x1292B1C", VA = "0x1292B1C")]
			public static RegionEndpoint GetBySystemName(string systemName)
			{
				return null;
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x12923B0", Offset = "0x12923B0", VA = "0x12923B0")]
			private static void LoadEndpointDefinitions()
			{
			}

			[Token(Token = "0x6000270")]
			[Address(RVA = "0x1292F14", Offset = "0x1292F14", VA = "0x1292F14")]
			public static void LoadEndpointDefinitions(string endpointsPath)
			{
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0x1293FF0", Offset = "0x1293FF0", VA = "0x1293FF0")]
			private static void ReadEndpointFile(Stream stream)
			{
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0x1293518", Offset = "0x1293518", VA = "0x1293518")]
			private static void LoadEndpointDefinitionsFromEmbeddedResource()
			{
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x12931F8", Offset = "0x12931F8", VA = "0x12931F8")]
			private static bool TryLoadEndpointDefinitionsFromAssemblyDir()
			{
				return default;
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x1293DD0", Offset = "0x1293DD0", VA = "0x1293DD0")]
			private static void LoadEndpointDefinitionFromFilePath(string path)
			{
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x12939B4", Offset = "0x12939B4", VA = "0x12939B4")]
			private static void LoadEndpointDefinitionFromWeb(string url)
			{
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0x12944E8", Offset = "0x12944E8", VA = "0x12944E8")]
			public static void UnloadEndpointDefinitions()
			{
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0x1292910", Offset = "0x1292910", VA = "0x1292910")]
			private RegionEndpoint(string systemName, string displayName)
			{
			}

			[Token(Token = "0x600027D")]
			[Address(RVA = "0x1294680", Offset = "0x1294680", VA = "0x1294680", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x261B8", Offset = "0x261B8")]
		private static IWebProxy Proxy__BackingField;

		[Token(Token = "0x17000084")]
		public static IWebProxy Proxy
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x1258DBC", Offset = "0x1258DBC", VA = "0x1258DBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27F10", Offset = "0x27F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x1258E08", Offset = "0x1258E08", VA = "0x1258E08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27F20", Offset = "0x27F20")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public IEnumerable<IRegionEndpoint> AllRegionEndpoints
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x1258E60", Offset = "0x1258E60", VA = "0x1258E60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1258EBC", Offset = "0x1258EBC", VA = "0x1258EBC", Slot = "5")]
		public IRegionEndpoint GetRegionEndpoint(string regionName)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1257D88", Offset = "0x1257D88", VA = "0x1257D88")]
		public RegionEndpointProviderV2()
		{
		}
	}
}
