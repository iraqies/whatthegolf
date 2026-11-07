using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.Initialization
{
	[Serializable]
	[Token(Token = "0x200005E")]
	public class ResourceManagerRuntimeData
	{
		[Token(Token = "0x4000137")]
		public const string kCatalogAddress = "AddressablesMainContentCatalog";

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_buildTarget;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1918", Offset = "0x1B1918")]
		private string m_SettingsHash;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1964", Offset = "0x1B1964")]
		private List<ResourceLocationData> m_CatalogLocations;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B19B0", Offset = "0x1B19B0")]
		private bool m_ProfileEvents;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B19FC", Offset = "0x1B19FC")]
		private bool m_LogResourceManagerExceptions;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1A48", Offset = "0x1B1A48")]
		[SerializeField]
		private List<ObjectInitializationData> m_ExtraInitializationData;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_DisableCatalogUpdateOnStart;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool m_IsLocalCatalogInBundle;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SerializedType m_CertificateHandlerType;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string m_AddressablesVersion;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int m_maxConcurrentWebRequests;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int m_CatalogRequestsTimeout;

		[Token(Token = "0x17000064")]
		public string BuildTarget
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x2A38654", Offset = "0x2A38654", VA = "0x2A38654")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x2A3865C", Offset = "0x2A3865C", VA = "0x2A3865C")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public string SettingsHash
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x2A38664", Offset = "0x2A38664", VA = "0x2A38664")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x2A3866C", Offset = "0x2A3866C", VA = "0x2A3866C")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public List<ResourceLocationData> CatalogLocations
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x2A38674", Offset = "0x2A38674", VA = "0x2A38674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public bool ProfileEvents
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x2A3867C", Offset = "0x2A3867C", VA = "0x2A3867C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x2A38684", Offset = "0x2A38684", VA = "0x2A38684")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public bool LogResourceManagerExceptions
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x2A3868C", Offset = "0x2A3868C", VA = "0x2A3868C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x2A38694", Offset = "0x2A38694", VA = "0x2A38694")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public List<ObjectInitializationData> InitializationObjects
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x2A3869C", Offset = "0x2A3869C", VA = "0x2A3869C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public bool DisableCatalogUpdateOnStartup
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x2A386A4", Offset = "0x2A386A4", VA = "0x2A386A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x2A386AC", Offset = "0x2A386AC", VA = "0x2A386AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public bool IsLocalCatalogInBundle
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x2A386B4", Offset = "0x2A386B4", VA = "0x2A386B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x2A386BC", Offset = "0x2A386BC", VA = "0x2A386BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public Type CertificateHandlerType
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x2A316F8", Offset = "0x2A316F8", VA = "0x2A316F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x2A386C4", Offset = "0x2A386C4", VA = "0x2A386C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public string AddressablesVersion
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x2A386D0", Offset = "0x2A386D0", VA = "0x2A386D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x2A386D8", Offset = "0x2A386D8", VA = "0x2A386D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public int MaxConcurrentWebRequests
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x2A386E0", Offset = "0x2A386E0", VA = "0x2A386E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x2A386E8", Offset = "0x2A386E8", VA = "0x2A386E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public int CatalogRequestsTimeout
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x2A3871C", Offset = "0x2A3871C", VA = "0x2A3871C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x2A38724", Offset = "0x2A38724", VA = "0x2A38724")]
			set
			{
			}
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2A38740", Offset = "0x2A38740", VA = "0x2A38740")]
		public ResourceManagerRuntimeData()
		{
		}
	}
}
