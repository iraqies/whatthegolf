using System;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Preserve]
	public sealed class ControllerSetSelector : ISerializationCallbackReceiver, IDeepCloneable
	{
		public enum Type
		{
			All = 0,
			ControllerType = 1,
			HardwareType = 2,
			ControllerTemplateType = 3,
			PersistentControllerInstance = 4,
			SessionControllerInstance = 5
		}

		[SerializeField]
		[Serialize]
		private Type _type;

		[SerializeField]
		[Serialize]
		private ControllerType _controllerType;

		[SerializeField]
		[Serialize]
		private string _guid;

		[SerializeField]
		[Serialize]
		private string _hardwareIdentifier;

		[SerializeField]
		[Serialize]
		private int _controllerId;

		[NonSerialized]
		private Guid ogxUreeXNLqmoemRiQVPimdeNdIl;

		internal bool IRxuBlsWPAUhvrFlMvUAiDQPeqYAA => nYnNcmzdTwWekQAfGlEiLQqmSMVb();

		public Type type => Type.All;

		public ControllerType controllerType => ControllerType.Keyboard;

		public Guid hardwareTypeGuid => default;

		public string hardwareIdentifier => null;

		public Guid controllerTemplateTypeGuid => default;

		public Guid deviceInstanceGuid => default;

		public int controllerId => 0;

		internal ControllerSetSelector(Type P_0)
		{
		}

		public ControllerSetSelector()
		{
		}

		public ControllerSetSelector(ControllerSetSelector P_0)
		{
		}

		internal ControllerSetSelector(Type P_0, ControllerType P_1, string P_2, string P_3, int P_4)
		{
		}

		internal bool nYnNcmzdTwWekQAfGlEiLQqmSMVb()
		{
			return false;
		}

		public bool Matches(Controller controller)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		object IDeepCloneable.DeepClone()
		{
			return null;
		}
	}
}
