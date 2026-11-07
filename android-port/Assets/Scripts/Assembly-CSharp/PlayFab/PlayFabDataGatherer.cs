using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace PlayFab
{
	[Token(Token = "0x200118D")]
	public class PlayFabDataGatherer
	{
		[Token(Token = "0x4005ECA")]
		[FieldOffset(Offset = "0x10")]
		public string ProductName;

		[Token(Token = "0x4005ECB")]
		[FieldOffset(Offset = "0x18")]
		public string ProductBundle;

		[Token(Token = "0x4005ECC")]
		[FieldOffset(Offset = "0x20")]
		public string Version;

		[Token(Token = "0x4005ECD")]
		[FieldOffset(Offset = "0x28")]
		public string Company;

		[Token(Token = "0x4005ECE")]
		[FieldOffset(Offset = "0x30")]
		public RuntimePlatform Platform;

		[Token(Token = "0x4005ECF")]
		[FieldOffset(Offset = "0x34")]
		public bool GraphicsMultiThreaded;

		[Token(Token = "0x4005ED0")]
		[FieldOffset(Offset = "0x38")]
		public GraphicsDeviceType GraphicsType;

		[Token(Token = "0x4005ED1")]
		[FieldOffset(Offset = "0x40")]
		public string DataPath;

		[Token(Token = "0x4005ED2")]
		[FieldOffset(Offset = "0x48")]
		public string PersistentDataPath;

		[Token(Token = "0x4005ED3")]
		[FieldOffset(Offset = "0x50")]
		public string StreamingAssetsPath;

		[Token(Token = "0x4005ED4")]
		[FieldOffset(Offset = "0x58")]
		public int TargetFrameRate;

		[Token(Token = "0x4005ED5")]
		[FieldOffset(Offset = "0x60")]
		public string UnityVersion;

		[Token(Token = "0x4005ED6")]
		[FieldOffset(Offset = "0x68")]
		public bool RunInBackground;

		[Token(Token = "0x4005ED7")]
		[FieldOffset(Offset = "0x70")]
		public string DeviceModel;

		[Token(Token = "0x4005ED8")]
		[FieldOffset(Offset = "0x78")]
		public DeviceType DeviceType;

		[Token(Token = "0x4005ED9")]
		[FieldOffset(Offset = "0x80")]
		public string DeviceUniqueId;

		[Token(Token = "0x4005EDA")]
		[FieldOffset(Offset = "0x88")]
		public string OperatingSystem;

		[Token(Token = "0x4005EDB")]
		[FieldOffset(Offset = "0x90")]
		public int GraphicsDeviceId;

		[Token(Token = "0x4005EDC")]
		[FieldOffset(Offset = "0x98")]
		public string GraphicsDeviceName;

		[Token(Token = "0x4005EDD")]
		[FieldOffset(Offset = "0xA0")]
		public int GraphicsMemorySize;

		[Token(Token = "0x4005EDE")]
		[FieldOffset(Offset = "0xA4")]
		public int GraphicsShaderLevel;

		[Token(Token = "0x4005EDF")]
		[FieldOffset(Offset = "0xA8")]
		public int SystemMemorySize;

		[Token(Token = "0x4005EE0")]
		[FieldOffset(Offset = "0xAC")]
		public int ProcessorCount;

		[Token(Token = "0x4005EE1")]
		[FieldOffset(Offset = "0xB0")]
		public int ProcessorFrequency;

		[Token(Token = "0x4005EE2")]
		[FieldOffset(Offset = "0xB8")]
		public string ProcessorType;

		[Token(Token = "0x4005EE3")]
		[FieldOffset(Offset = "0xC0")]
		public bool SupportsAccelerometer;

		[Token(Token = "0x4005EE4")]
		[FieldOffset(Offset = "0xC1")]
		public bool SupportsGyroscope;

		[Token(Token = "0x4005EE5")]
		[FieldOffset(Offset = "0xC2")]
		public bool SupportsLocationService;

		[Token(Token = "0x6005036")]
		[Address(RVA = "0x15EABF4", Offset = "0x15EABF4", VA = "0x15EABF4")]
		public PlayFabDataGatherer()
		{
		}

		[Token(Token = "0x6005037")]
		[Address(RVA = "0x15EADB4", Offset = "0x15EADB4", VA = "0x15EADB4")]
		public string GenerateReport()
		{
			return null;
		}
	}
}
