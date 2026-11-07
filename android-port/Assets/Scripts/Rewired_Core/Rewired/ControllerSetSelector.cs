using System;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Token(Token = "0x200000C")]
	[Preserve]
	public sealed class ControllerSetSelector : ISerializationCallbackReceiver, IDeepCloneable
	{
		[Token(Token = "0x200000D")]
		public enum Type
		{
			[Token(Token = "0x4000054")]
			All = 0,
			[Token(Token = "0x4000055")]
			ControllerType = 1,
			[Token(Token = "0x4000056")]
			HardwareType = 2,
			[Token(Token = "0x4000057")]
			ControllerTemplateType = 3,
			[Token(Token = "0x4000058")]
			PersistentControllerInstance = 4,
			[Token(Token = "0x4000059")]
			SessionControllerInstance = 5
		}

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Serialize]
		private Type _type;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Serialize]
		private ControllerType _controllerType;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Serialize]
		private string _guid;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Serialize]
		private string _hardwareIdentifier;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Serialize]
		private int _controllerId;

		[NonSerialized]
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x2C")]
		private Guid ogxUreeXNLqmoemRiQVPimdeNdIl;

		[Token(Token = "0x1700002A")]
		internal bool IRxuBlsWPAUhvrFlMvUAiDQPeqYAA
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2368068", Offset = "0x2368068", VA = "0x2368068")]
			get
			{
				return nYnNcmzdTwWekQAfGlEiLQqmSMVb();
			}
		}

		[Token(Token = "0x1700002B")]
		public Type type
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2368078", Offset = "0x2368078", VA = "0x2368078")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002C")]
		public ControllerType controllerType
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2368080", Offset = "0x2368080", VA = "0x2368080")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002D")]
		public Guid hardwareTypeGuid
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2368088", Offset = "0x2368088", VA = "0x2368088")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002E")]
		public string hardwareIdentifier
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2368110", Offset = "0x2368110", VA = "0x2368110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public Guid controllerTemplateTypeGuid
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2368118", Offset = "0x2368118", VA = "0x2368118")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000030")]
		public Guid deviceInstanceGuid
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x23681A0", Offset = "0x23681A0", VA = "0x23681A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000031")]
		public int controllerId
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2368228", Offset = "0x2368228", VA = "0x2368228")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2367EB4", Offset = "0x2367EB4", VA = "0x2367EB4")]
		internal ControllerSetSelector(Type P_0)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2367EE8", Offset = "0x2367EE8", VA = "0x2367EE8")]
		public ControllerSetSelector()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2367F14", Offset = "0x2367F14", VA = "0x2367F14")]
		public ControllerSetSelector(ControllerSetSelector P_0)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2367FB0", Offset = "0x2367FB0", VA = "0x2367FB0")]
		internal ControllerSetSelector(Type P_0, ControllerType P_1, string P_2, string P_3, int P_4)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2368068", Offset = "0x2368068", VA = "0x2368068")]
		internal bool nYnNcmzdTwWekQAfGlEiLQqmSMVb()
		{
			return default;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x23638C0", Offset = "0x23638C0", VA = "0x23638C0")]
		public bool Matches(Controller controller)
		{
			return default;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2368230", Offset = "0x2368230", VA = "0x2368230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x236846C", Offset = "0x236846C", VA = "0x236846C", Slot = "5")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x23684F0", Offset = "0x23684F0", VA = "0x23684F0", Slot = "4")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x23684F4", Offset = "0x23684F4", VA = "0x23684F4", Slot = "6")]
		private object Rewired_002EUtils_002EInterfaces_002EIDeepCloneable_002EDeepClone()
		{
			return null;
		}
	}
}
