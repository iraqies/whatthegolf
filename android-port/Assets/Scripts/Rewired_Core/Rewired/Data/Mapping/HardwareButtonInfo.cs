using System;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20002B0")]
	public class HardwareButtonInfo : IDeepCloneable
	{
		[Token(Token = "0x4000E61")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal bool _excludeFromPolling;

		[Token(Token = "0x4000E62")]
		[FieldOffset(Offset = "0x11")]
		[SerializeField]
		internal bool _isPressureSensitive;

		[Token(Token = "0x6001399")]
		[Address(RVA = "0x23CB058", Offset = "0x23CB058", VA = "0x23CB058")]
		public HardwareButtonInfo()
		{
		}

		[Token(Token = "0x600139A")]
		[Address(RVA = "0x23CB080", Offset = "0x23CB080", VA = "0x23CB080")]
		internal HardwareButtonInfo(bool P_0, bool P_1)
		{
		}

		[Token(Token = "0x600139B")]
		[Address(RVA = "0x23CB0BC", Offset = "0x23CB0BC", VA = "0x23CB0BC", Slot = "4")]
		public object DeepClone()
		{
			return null;
		}
	}
}
