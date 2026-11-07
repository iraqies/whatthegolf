using System.Collections.Generic;
using Amazon.Internal;
using Il2CppDummyDll;

namespace Amazon
{
	[Token(Token = "0x200003A")]
	public class RegionEndpoint
	{
		[Token(Token = "0x200003B")]
		public class Endpoint
		{
			[Token(Token = "0x4000125")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26188", Offset = "0x26188")]
			private string Hostname__BackingField;

			[Token(Token = "0x4000126")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26198", Offset = "0x26198")]
			private string AuthRegion__BackingField;

			[Token(Token = "0x4000127")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x261A8", Offset = "0x261A8")]
			private string SignatureVersionOverride__BackingField;

			[Token(Token = "0x1700007E")]
			public string Hostname
			{
				[Token(Token = "0x6000259")]
				[Address(RVA = "0x1291F88", Offset = "0x1291F88", VA = "0x1291F88")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27EB0", Offset = "0x27EB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600025A")]
				[Address(RVA = "0x1291F90", Offset = "0x1291F90", VA = "0x1291F90")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27EC0", Offset = "0x27EC0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public string AuthRegion
			{
				[Token(Token = "0x600025B")]
				[Address(RVA = "0x1291F98", Offset = "0x1291F98", VA = "0x1291F98")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27ED0", Offset = "0x27ED0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600025C")]
				[Address(RVA = "0x1291FA0", Offset = "0x1291FA0", VA = "0x1291FA0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27EE0", Offset = "0x27EE0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public string SignatureVersionOverride
			{
				[Token(Token = "0x600025E")]
				[Address(RVA = "0x1291FB0", Offset = "0x1291FB0", VA = "0x1291FB0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27EF0", Offset = "0x27EF0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600025F")]
				[Address(RVA = "0x1291FB8", Offset = "0x1291FB8", VA = "0x1291FB8")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27F00", Offset = "0x27F00")]
				private set
				{
				}
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x1291F48", Offset = "0x1291F48", VA = "0x1291F48")]
			internal Endpoint(string hostname, string authregion, string signatureVersionOverride)
			{
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x1291FA8", Offset = "0x1291FA8", VA = "0x1291FA8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, RegionEndpoint> _hashBySystemName;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x8")]
		public static readonly RegionEndpoint USEast1;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x10")]
		private static readonly RegionEndpoint USEast1Regional;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x18")]
		public static readonly RegionEndpoint USEast2;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x20")]
		public static readonly RegionEndpoint USWest1;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x28")]
		public static readonly RegionEndpoint USWest2;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x30")]
		public static readonly RegionEndpoint EUNorth1;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x38")]
		public static readonly RegionEndpoint EUWest1;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x40")]
		public static readonly RegionEndpoint EUWest2;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x48")]
		public static readonly RegionEndpoint EUWest3;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x50")]
		public static readonly RegionEndpoint EUCentral1;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x58")]
		public static readonly RegionEndpoint EUSouth1;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x60")]
		public static readonly RegionEndpoint APEast1;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x68")]
		public static readonly RegionEndpoint APNortheast1;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x70")]
		public static readonly RegionEndpoint APNortheast2;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x78")]
		public static readonly RegionEndpoint APNortheast3;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x80")]
		public static readonly RegionEndpoint APSouth1;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x88")]
		public static readonly RegionEndpoint APSoutheast1;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x90")]
		public static readonly RegionEndpoint APSoutheast2;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x98")]
		public static readonly RegionEndpoint SAEast1;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly RegionEndpoint USGovCloudEast1;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly RegionEndpoint USGovCloudWest1;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly RegionEndpoint CNNorth1;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly RegionEndpoint CNNorthWest1;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly RegionEndpoint CACentral1;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly RegionEndpoint MESouth1;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly RegionEndpoint AFSouth1;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0xD8")]
		private static Dictionary<RegionEndpoint, RegionEndpoint> _hashRegionEndpointOverride;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0xE0")]
		private static IRegionEndpointProvider _regionEndpointProvider;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26168", Offset = "0x26168")]
		private string SystemName__BackingField;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26178", Offset = "0x26178")]
		private string DisplayName__BackingField;

		[Token(Token = "0x17000077")]
		public static IEnumerable<RegionEndpoint> EnumerableAllRegions
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x125714C", Offset = "0x125714C", VA = "0x125714C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private static IRegionEndpointProvider RegionEndpointProvider
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x125768C", Offset = "0x125768C", VA = "0x125768C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public string SystemName
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x12580A4", Offset = "0x12580A4", VA = "0x12580A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27E70", Offset = "0x27E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x12580AC", Offset = "0x12580AC", VA = "0x12580AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27E80", Offset = "0x27E80")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public string DisplayName
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x12580B4", Offset = "0x12580B4", VA = "0x12580B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27E90", Offset = "0x27E90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x12580BC", Offset = "0x12580BC", VA = "0x12580BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27EA0", Offset = "0x27EA0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public string PartitionName
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x12580C4", Offset = "0x12580C4", VA = "0x12580C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public string PartitionDnsSuffix
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x12582F8", Offset = "0x12582F8", VA = "0x12582F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		private IRegionEndpoint InternedRegionEndpoint
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x12581A4", Offset = "0x12581A4", VA = "0x12581A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1241974", Offset = "0x1241974", VA = "0x1241974")]
		public static RegionEndpoint GetBySystemName(string systemName)
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1257C5C", Offset = "0x1257C5C", VA = "0x1257C5C")]
		public static RegionEndpoint GetRegionEndpointOverride(RegionEndpoint regionEndpoint)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x12577CC", Offset = "0x12577CC", VA = "0x12577CC")]
		private static RegionEndpoint GetEndpoint(string systemName, string displayName)
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1257D50", Offset = "0x1257D50", VA = "0x1257D50")]
		private RegionEndpoint(string systemName, string displayName)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1258438", Offset = "0x1258438", VA = "0x1258438")]
		public Endpoint GetEndpointForService(string serviceName)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1258440", Offset = "0x1258440", VA = "0x1258440")]
		public Endpoint GetEndpointForService(string serviceName, bool dualStack)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1258518", Offset = "0x1258518", VA = "0x1258518", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
