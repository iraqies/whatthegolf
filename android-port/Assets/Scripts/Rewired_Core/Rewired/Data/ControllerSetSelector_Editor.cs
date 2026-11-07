using System;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Token(Token = "0x20001D4")]
	[Preserve]
	public sealed class ControllerSetSelector_Editor : IDeepCloneable
	{
		[Token(Token = "0x4000A9E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Serialize]
		private ControllerSetSelector.Type _type;

		[Token(Token = "0x4000A9F")]
		[FieldOffset(Offset = "0x14")]
		[Serialize]
		[SerializeField]
		private ControllerType _controllerType;

		[Token(Token = "0x4000AA0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Serialize]
		private string _hardwareTypeGuidString;

		[Token(Token = "0x4000AA1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Serialize]
		private string _hardwareIdentifier;

		[Token(Token = "0x4000AA2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Serialize]
		private string _controllerTemplateTypeGuidString;

		[Token(Token = "0x4000AA3")]
		[FieldOffset(Offset = "0x30")]
		[Serialize]
		[SerializeField]
		private string _deviceInstanceGuidString;

		[Token(Token = "0x4000AA4")]
		[FieldOffset(Offset = "0x38")]
		[Serialize]
		[SerializeField]
		private int _customControllerSourceId;

		[Token(Token = "0x4000AA5")]
		[FieldOffset(Offset = "0x3C")]
		[Serialize]
		[SerializeField]
		private int _controllerId;

		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x2362094", Offset = "0x2362094", VA = "0x2362094")]
		internal ControllerSetSelector_Editor(ControllerSetSelector.Type P_0)
		{
		}

		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x2368558", Offset = "0x2368558", VA = "0x2368558")]
		public ControllerSetSelector_Editor()
		{
		}

		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x23685FC", Offset = "0x23685FC", VA = "0x23685FC")]
		public ControllerSetSelector_Editor(ControllerSetSelector_Editor P_0)
		{
		}

		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x236227C", Offset = "0x236227C", VA = "0x236227C")]
		internal ControllerSetSelector KxgloTzSnEIWSUdTJtyefCbgClOY()
		{
			return null;
		}

		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x2368690", Offset = "0x2368690", VA = "0x2368690", Slot = "4")]
		private object Rewired_002EUtils_002EInterfaces_002EIDeepCloneable_002EDeepClone()
		{
			return null;
		}
	}
}
