using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	[Token(Token = "0x2000054")]
	public class ResourceLocationMap : IResourceLocator
	{
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B177C", Offset = "0x1B177C")]
		private string LocatorId__BackingField;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<object, IList<IResourceLocation>> locations;

		[Token(Token = "0x17000059")]
		public string LocatorId
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x2A377F0", Offset = "0x2A377F0", VA = "0x2A377F0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1FAC", Offset = "0x1B1FAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x2A377F8", Offset = "0x2A377F8", VA = "0x2A377F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1FBC", Offset = "0x1B1FBC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public Dictionary<object, IList<IResourceLocation>> Locations
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x2A3797C", Offset = "0x2A3797C", VA = "0x2A3797C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IEnumerable<object> Keys
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x2A2D44C", Offset = "0x2A2D44C", VA = "0x2A2D44C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2A2C448", Offset = "0x2A2C448", VA = "0x2A2C448")]
		public ResourceLocationMap(string id, int capacity = 0)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2A31800", Offset = "0x2A31800", VA = "0x2A31800")]
		public ResourceLocationMap(string id, IList<ResourceLocationData> locations)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2A2D4A0", Offset = "0x2A2D4A0", VA = "0x2A2D4A0", Slot = "6")]
		public bool Locate(object key, Type type, out IList<IResourceLocation> locations)
		{
			return default;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2A37800", Offset = "0x2A37800", VA = "0x2A37800")]
		public void Add(object key, IResourceLocation location)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2A2C5CC", Offset = "0x2A2C5CC", VA = "0x2A2C5CC")]
		public void Add(object key, IList<IResourceLocation> locations)
		{
		}
	}
}
