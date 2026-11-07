using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Token(Token = "0x20001D0")]
	[Preserve]
	public sealed class ControllerMapEnabler_RuleSet_Editor
	{
		[Token(Token = "0x4000A8D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Serialize]
		private int _id;

		[Token(Token = "0x4000A8E")]
		[FieldOffset(Offset = "0x18")]
		[Serialize]
		[SerializeField]
		private string _name;

		[Token(Token = "0x4000A8F")]
		[FieldOffset(Offset = "0x20")]
		[Serialize]
		[SerializeField]
		private string _tag;

		[Token(Token = "0x4000A90")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Serialize]
		private List<ControllerMapEnabler_Rule_Editor> _rules;

		[Token(Token = "0x170003C6")]
		public int id
		{
			[Token(Token = "0x6000DEC")]
			[Address(RVA = "0x2361C28", Offset = "0x2361C28", VA = "0x2361C28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x2361C30", Offset = "0x2361C30", VA = "0x2361C30")]
		public ControllerMapEnabler_RuleSet_Editor()
		{
		}

		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x2361CB4", Offset = "0x2361CB4", VA = "0x2361CB4")]
		internal ControllerMapEnabler.RuleSet ToRuntime()
		{
			return null;
		}
	}
}
