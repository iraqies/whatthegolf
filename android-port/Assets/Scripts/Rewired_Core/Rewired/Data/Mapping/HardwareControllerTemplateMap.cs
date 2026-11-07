using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Token(Token = "0x20002A0")]
	public abstract class HardwareControllerTemplateMap : ScriptableObject
	{
		[Token(Token = "0x17000547")]
		public abstract Guid Guid
		{
			[Token(Token = "0x600135C")]
			get;
		}

		[Token(Token = "0x600135D")]
		[Address(RVA = "0x23CC178", Offset = "0x23CC178", VA = "0x23CC178")]
		protected HardwareControllerTemplateMap()
		{
		}
	}
}
