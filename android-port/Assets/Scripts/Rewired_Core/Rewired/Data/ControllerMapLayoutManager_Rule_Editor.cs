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
	[Token(Token = "0x20001D3")]
	[Preserve]
	public sealed class ControllerMapLayoutManager_Rule_Editor : IDeepCloneable
	{
		[Token(Token = "0x4000A9A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Serialize]
		private string _tag;

		[Token(Token = "0x4000A9B")]
		[FieldOffset(Offset = "0x18")]
		[Serialize]
		[SerializeField]
		private List<int> _categoryIds;

		[Token(Token = "0x4000A9C")]
		[FieldOffset(Offset = "0x20")]
		[Serialize]
		[SerializeField]
		private int _layoutId;

		[Token(Token = "0x4000A9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Serialize]
		private ControllerSetSelector_Editor _controllerSetSelector;

		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x2364068", Offset = "0x2364068", VA = "0x2364068")]
		public ControllerMapLayoutManager_Rule_Editor()
		{
		}

		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x23641A8", Offset = "0x23641A8", VA = "0x23641A8")]
		public ControllerMapLayoutManager_Rule_Editor(ControllerMapLayoutManager_Rule_Editor P_0)
		{
		}

		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x2363F88", Offset = "0x2363F88", VA = "0x2363F88")]
		internal ControllerMapLayoutManager.Rule ToRuntime()
		{
			return null;
		}

		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x23642C8", Offset = "0x23642C8", VA = "0x23642C8", Slot = "4")]
		private object Rewired_002EUtils_002EInterfaces_002EIDeepCloneable_002EDeepClone()
		{
			return null;
		}
	}
}
