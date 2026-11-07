using System.Collections.Generic;
using Il2CppDummyDll;
using ThirdParty.Json.LitJson;

namespace Amazon.Internal
{
	[Token(Token = "0x2000040")]
	public class RegionEndpointV3 : IRegionEndpoint
	{
		[Token(Token = "0x2000041")]
		private class ServiceMap
		{
			[Token(Token = "0x4000139")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, RegionEndpoint.Endpoint> _serviceMap;

			[Token(Token = "0x400013A")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<string, RegionEndpoint.Endpoint> _dualServiceMap;

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x1294858", Offset = "0x1294858", VA = "0x1294858")]
			private Dictionary<string, RegionEndpoint.Endpoint> GetMap(bool dualStack)
			{
				return null;
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1294870", Offset = "0x1294870", VA = "0x1294870")]
			public bool ContainsKey(string servicName)
			{
				return default;
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x12948D4", Offset = "0x12948D4", VA = "0x12948D4")]
			public void Add(string serviceName, bool dualStack, RegionEndpoint.Endpoint endpoint)
			{
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0x129495C", Offset = "0x129495C", VA = "0x129495C")]
			public bool TryGetEndpoint(string serviceName, bool dualStack, out RegionEndpoint.Endpoint endpoint)
			{
				return default;
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x12949E4", Offset = "0x12949E4", VA = "0x12949E4")]
			public ServiceMap()
			{
			}
		}

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x10")]
		private ServiceMap _serviceMap;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x261E8", Offset = "0x261E8")]
		private string RegionName__BackingField;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x261F8", Offset = "0x261F8")]
		private string DisplayName__BackingField;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x28")]
		private JsonData _partitionJsonData;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x30")]
		private JsonData _servicesJsonData;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x38")]
		private bool _servicesLoaded;

		[Token(Token = "0x1700008A")]
		public string RegionName
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x125AF6C", Offset = "0x125AF6C", VA = "0x125AF6C", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27F70", Offset = "0x27F70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x125AF74", Offset = "0x125AF74", VA = "0x125AF74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27F80", Offset = "0x27F80")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public string DisplayName
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x125AF7C", Offset = "0x125AF7C", VA = "0x125AF7C", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27F90", Offset = "0x27F90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x125AF84", Offset = "0x125AF84", VA = "0x125AF84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27FA0", Offset = "0x27FA0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public string PartitionName
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1258298", Offset = "0x1258298", VA = "0x1258298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public string PartitionDnsSuffix
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x12583D8", Offset = "0x12583D8", VA = "0x12583D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1259C28", Offset = "0x1259C28", VA = "0x1259C28")]
		public RegionEndpointV3(string regionName, string displayName, JsonData partition, JsonData services)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x125AF8C", Offset = "0x125AF8C", VA = "0x125AF8C", Slot = "6")]
		public RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack)
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x125B45C", Offset = "0x125B45C", VA = "0x125B45C")]
		private RegionEndpoint.Endpoint CreateUnknownEndpoint(string serviceName, bool dualStack)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x125B0C4", Offset = "0x125B0C4", VA = "0x125B0C4")]
		private void ParseAllServices()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x125B60C", Offset = "0x125B60C", VA = "0x125B60C")]
		private void AddServiceToMap(JsonData service, string serviceName)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x125B828", Offset = "0x125B828", VA = "0x125B828")]
		private static void MergeJsonData(JsonData target, JsonData source)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x125BB68", Offset = "0x125BB68", VA = "0x125BB68")]
		private void CreateEndpointAndAddToServiceMap(JsonData result, string regionName, string serviceName)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x125BBB4", Offset = "0x125BBB4", VA = "0x125BBB4")]
		private void CreateEndpointAndAddToServiceMap(JsonData result, string regionName, string serviceName, bool dualStack)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x125C20C", Offset = "0x125C20C", VA = "0x125C20C")]
		private static string DetermineSignatureOverride(JsonData defaults, string serviceName)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x125C18C", Offset = "0x125C18C", VA = "0x125C18C")]
		private static string DetermineAuthRegion(JsonData credentialScope)
		{
			return null;
		}
	}
}
