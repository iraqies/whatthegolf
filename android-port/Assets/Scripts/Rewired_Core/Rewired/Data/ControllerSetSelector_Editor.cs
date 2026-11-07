using System;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Preserve]
	public sealed class ControllerSetSelector_Editor : IDeepCloneable
	{
		[SerializeField]
		[Serialize]
		private ControllerSetSelector.Type _type;

		[Serialize]
		[SerializeField]
		private ControllerType _controllerType;

		[SerializeField]
		[Serialize]
		private string _hardwareTypeGuidString;

		[SerializeField]
		[Serialize]
		private string _hardwareIdentifier;

		[SerializeField]
		[Serialize]
		private string _controllerTemplateTypeGuidString;

		[Serialize]
		[SerializeField]
		private string _deviceInstanceGuidString;

		[Serialize]
		[SerializeField]
		private int _customControllerSourceId;

		[Serialize]
		[SerializeField]
		private int _controllerId;

		internal ControllerSetSelector_Editor(ControllerSetSelector.Type P_0)
		{
		}

		public ControllerSetSelector_Editor()
		{
		}

		public ControllerSetSelector_Editor(ControllerSetSelector_Editor P_0)
		{
		}

		internal ControllerSetSelector KxgloTzSnEIWSUdTJtyefCbgClOY()
		{
			return null;
		}

		object IDeepCloneable.DeepClone()
		{
			return null;
		}
	}
}
