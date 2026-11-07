using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Token(Token = "0x20001D1")]
	[Preserve]
	public sealed class ControllerMapEnabler_Rule_Editor : IDeepCloneable
	{
		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0x10")]
		[Serialize]
		[SerializeField]
		private string _tag;

		[Token(Token = "0x4000A92")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Serialize]
		private bool _enable;

		[Token(Token = "0x4000A93")]
		[FieldOffset(Offset = "0x20")]
		[Serialize]
		[SerializeField]
		private List<int> _categoryIds;

		[Token(Token = "0x4000A94")]
		[FieldOffset(Offset = "0x28")]
		[Serialize]
		[SerializeField]
		private List<int> _layoutIds;

		[Token(Token = "0x4000A95")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Serialize]
		private ControllerSetSelector_Editor _controllerSetSelector;

		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x2361F40", Offset = "0x2361F40", VA = "0x2361F40")]
		public ControllerMapEnabler_Rule_Editor()
		{
		}

		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x2362140", Offset = "0x2362140", VA = "0x2362140")]
		public ControllerMapEnabler_Rule_Editor(ControllerMapEnabler_Rule_Editor P_0)
		{
		}

		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x2361E2C", Offset = "0x2361E2C", VA = "0x2361E2C")]
		internal ControllerMapEnabler.Rule ToRuntime()
		{
			return null;
		}

		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x23624CC", Offset = "0x23624CC", VA = "0x23624CC", Slot = "4")]
		private object Rewired_002EUtils_002EInterfaces_002EIDeepCloneable_002EDeepClone()
		{
			return null;
		}
	}
}
