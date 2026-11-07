using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rewired.Data.Mapping;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[EditorBrowsable]
	public sealed class CustomController_Editor
	{
		[Serializable]
		[EditorBrowsable]
		public abstract class Element
		{
			public int elementIdentifierId;

			public string name;

			public Element()
			{
			}
		}

		[Serializable]
		[EditorBrowsable]
		public sealed class Button : Element
		{
		}

		[Serializable]
		[EditorBrowsable]
		public sealed class Axis : Element
		{
			public AxisRange range;

			public bool invert;

			public float deadZone;

			public float zero;

			public float min;

			public float max;

			public bool doNotCalibrateRange;

			public AxisSensitivityType sensitivityType;

			public float sensitivity;

			public AnimationCurve sensitivityCurve;

			public HardwareAxisInfo axisInfo;
		}

		[SerializeField]
		private string _name;

		[SerializeField]
		private string _descriptiveName;

		[SerializeField]
		private int _id;

		[SerializeField]
		private string _typeGuidString;

		[SerializeField]
		private List<ControllerElementIdentifier> _elementIdentifiers;

		[SerializeField]
		private List<Axis> _axes;

		[SerializeField]
		private List<Button> _buttons;

		[SerializeField]
		private int _elementIdentifierIdCounter;

		public string name => null;

		public string descriptiveName => null;

		public int id => 0;

		public Guid typeGuid => default;

		internal string typeGuidString => null;

		public List<Axis> axes => null;

		public List<Button> buttons => null;

		public int buttonCount => 0;

		public int axisCount => 0;

		public string[] GetElementIdentifierNames()
		{
			return null;
		}

		public ControllerElementIdentifier[] GetElementIdentifiersTypeSorted()
		{
			return null;
		}

		public bool ContainsElementIdentifier(int id)
		{
			return false;
		}

		public int IndexOfElementIdentifier(int id)
		{
			return 0;
		}

		public ControllerElementIdentifier GetElementIdentifier(int id)
		{
			return null;
		}

		internal ControllerElementType GetEffectiveElementIdentifierType(int elementIdentifierId)
		{
			return ControllerElementType.Axis;
		}

		internal bool GetEffectiveAxisRange(int elementIdentifierId, out AxisRange axisRange)
		{
			axisRange = default;
			return false;
		}

		internal HardwareControllerMap_Game CreateGameHardwareMap()
		{
			return null;
		}
	}
}
