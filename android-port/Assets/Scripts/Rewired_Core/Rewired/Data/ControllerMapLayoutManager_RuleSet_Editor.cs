using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Token(Token = "0x20001D2")]
	[Preserve]
	public sealed class ControllerMapLayoutManager_RuleSet_Editor
	{
		[Token(Token = "0x4000A96")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Serialize]
		private int _id;

		[Token(Token = "0x4000A97")]
		[FieldOffset(Offset = "0x18")]
		[Serialize]
		[SerializeField]
		private string _name;

		[Token(Token = "0x4000A98")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Serialize]
		private string _tag;

		[Token(Token = "0x4000A99")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Serialize]
		private List<ControllerMapLayoutManager_Rule_Editor> _rules;

		[Token(Token = "0x170003C7")]
		public int id
		{
			[Token(Token = "0x6000DF3")]
			[Address(RVA = "0x2363D84", Offset = "0x2363D84", VA = "0x2363D84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x2363D8C", Offset = "0x2363D8C", VA = "0x2363D8C")]
		public ControllerMapLayoutManager_RuleSet_Editor()
		{
		}

		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x2363E10", Offset = "0x2363E10", VA = "0x2363E10")]
		internal ControllerMapLayoutManager.RuleSet ToRuntime()
		{
			return null;
		}
	}
}
