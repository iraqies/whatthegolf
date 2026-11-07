using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Exceptions
{
	[Token(Token = "0x2000016")]
	public class ProviderException : OperationException
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7D88", Offset = "0x1B7D88")]
		private readonly IResourceLocation Location__BackingField;

		[Token(Token = "0x1700001F")]
		public IResourceLocation Location
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2A6B388", Offset = "0x2A6B388", VA = "0x2A6B388")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8444", Offset = "0x1B8444")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2A6B2F0", Offset = "0x2A6B2F0", VA = "0x2A6B2F0")]
		public ProviderException(string message, [Optional] IResourceLocation location, [Optional] Exception innerException)
		{
		}
	}
}
