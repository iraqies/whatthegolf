using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.AddressableAssets
{
	[Token(Token = "0x2000043")]
	public class PlatformMappingService
	{
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Dictionary<RuntimePlatform, AddressablesPlatform> s_RuntimeTargetMapping;

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2A367A4", Offset = "0x2A367A4", VA = "0x2A367A4")]
		internal static AddressablesPlatform GetAddressablesPlatformInternal(RuntimePlatform platform)
		{
			return default;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2A36894", Offset = "0x2A36894", VA = "0x2A36894")]
		internal static string GetAddressablesPlatformPathInternal(RuntimePlatform platform)
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2A369FC", Offset = "0x2A369FC", VA = "0x2A369FC")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x1B1E64", Offset = "0x1B1E64")]
		public static AddressablesPlatform GetPlatform()
		{
			return default;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2A1F5C4", Offset = "0x2A1F5C4", VA = "0x2A1F5C4")]
		public static string GetPlatformPathSubFolder()
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2A36A68", Offset = "0x2A36A68", VA = "0x2A36A68")]
		public PlatformMappingService()
		{
		}
	}
}
