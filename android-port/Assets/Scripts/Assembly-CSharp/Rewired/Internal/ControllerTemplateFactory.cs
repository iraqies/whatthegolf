using System;
using Il2CppDummyDll;

namespace Rewired.Internal
{
	[Token(Token = "0x2001147")]
	public static class ControllerTemplateFactory
	{
		[Token(Token = "0x4005B35")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] _defaultTemplateTypes;

		[Token(Token = "0x4005B36")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type[] _defaultTemplateInterfaceTypes;

		[Token(Token = "0x17000841")]
		public static Type[] templateTypes
		{
			[Token(Token = "0x6004E18")]
			[Address(RVA = "0x18B8E14", Offset = "0x18B8E14", VA = "0x18B8E14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000842")]
		public static Type[] templateInterfaceTypes
		{
			[Token(Token = "0x6004E19")]
			[Address(RVA = "0x18B8E78", Offset = "0x18B8E78", VA = "0x18B8E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004E1A")]
		[Address(RVA = "0x18B8EDC", Offset = "0x18B8EDC", VA = "0x18B8EDC")]
		public static IControllerTemplate Create(Guid typeGuid, object payload)
		{
			return null;
		}
	}
}
