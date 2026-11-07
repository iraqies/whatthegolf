using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.Exceptions
{
	[Token(Token = "0x2000017")]
	public class RemoteProviderException : ProviderException
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7D98", Offset = "0x1B7D98")]
		private readonly UnityWebRequestResult WebRequestResult__BackingField;

		[Token(Token = "0x17000020")]
		public override string Message
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2A6B458", Offset = "0x2A6B458", VA = "0x2A6B458", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public UnityWebRequestResult WebRequestResult
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x2A6B464", Offset = "0x2A6B464", VA = "0x2A6B464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8454", Offset = "0x1B8454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2A5FBF0", Offset = "0x2A5FBF0", VA = "0x2A5FBF0")]
		public RemoteProviderException(string message, [Optional] IResourceLocation location, [Optional] UnityWebRequestResult uwrResult, [Optional] Exception innerException)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2A6B46C", Offset = "0x2A6B46C", VA = "0x2A6B46C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
