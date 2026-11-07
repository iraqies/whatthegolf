using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.ResourceLocations
{
	[Token(Token = "0x2000064")]
	public interface IResourceLocation
	{
		[Token(Token = "0x1700005F")]
		string InternalId
		{
			[Token(Token = "0x6000244")]
			get;
		}

		[Token(Token = "0x17000060")]
		string ProviderId
		{
			[Token(Token = "0x6000245")]
			get;
		}

		[Token(Token = "0x17000061")]
		IList<IResourceLocation> Dependencies
		{
			[Token(Token = "0x6000246")]
			get;
		}

		[Token(Token = "0x17000062")]
		int DependencyHashCode
		{
			[Token(Token = "0x6000248")]
			get;
		}

		[Token(Token = "0x17000063")]
		bool HasDependencies
		{
			[Token(Token = "0x6000249")]
			get;
		}

		[Token(Token = "0x17000064")]
		object Data
		{
			[Token(Token = "0x600024A")]
			get;
		}

		[Token(Token = "0x17000065")]
		string PrimaryKey
		{
			[Token(Token = "0x600024B")]
			get;
		}

		[Token(Token = "0x17000066")]
		Type ResourceType
		{
			[Token(Token = "0x600024C")]
			get;
		}

		[Token(Token = "0x6000247")]
		int Hash(Type resultType);
	}
}
