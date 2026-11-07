using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Data.Mapping;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Token(Token = "0x20001B8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1912D4", Offset = "0x1912D4")]
	[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x1912D4", Offset = "0x1912D4")]
	public sealed class CustomController_Editor
	{
		[Serializable]
		[Token(Token = "0x20001B9")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x191314", Offset = "0x191314")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191314", Offset = "0x191314")]
		public abstract class Element
		{
			[Token(Token = "0x40009FB")]
			[FieldOffset(Offset = "0x10")]
			public int elementIdentifierId;

			[Token(Token = "0x40009FC")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x246379C", Offset = "0x246379C", VA = "0x246379C")]
			public Element()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BA")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x191354", Offset = "0x191354")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191354", Offset = "0x191354")]
		public sealed class Button : Element
		{
			[Token(Token = "0x6000D04")]
			[Address(RVA = "0x24637A4", Offset = "0x24637A4", VA = "0x24637A4")]
			public Button()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BB")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x191394", Offset = "0x191394")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191394", Offset = "0x191394")]
		public sealed class Axis : Element
		{
			[Token(Token = "0x40009FD")]
			[FieldOffset(Offset = "0x20")]
			public AxisRange range;

			[Token(Token = "0x40009FE")]
			[FieldOffset(Offset = "0x24")]
			public bool invert;

			[Token(Token = "0x40009FF")]
			[FieldOffset(Offset = "0x28")]
			public float deadZone;

			[Token(Token = "0x4000A00")]
			[FieldOffset(Offset = "0x2C")]
			public float zero;

			[Token(Token = "0x4000A01")]
			[FieldOffset(Offset = "0x30")]
			public float min;

			[Token(Token = "0x4000A02")]
			[FieldOffset(Offset = "0x34")]
			public float max;

			[Token(Token = "0x4000A03")]
			[FieldOffset(Offset = "0x38")]
			public bool doNotCalibrateRange;

			[Token(Token = "0x4000A04")]
			[FieldOffset(Offset = "0x3C")]
			public AxisSensitivityType sensitivityType;

			[Token(Token = "0x4000A05")]
			[FieldOffset(Offset = "0x40")]
			public float sensitivity;

			[Token(Token = "0x4000A06")]
			[FieldOffset(Offset = "0x48")]
			public AnimationCurve sensitivityCurve;

			[Token(Token = "0x4000A07")]
			[FieldOffset(Offset = "0x50")]
			public HardwareAxisInfo axisInfo;

			[Token(Token = "0x6000D05")]
			[Address(RVA = "0x2463764", Offset = "0x2463764", VA = "0x2463764")]
			public Axis()
			{
			}
		}

		[Token(Token = "0x40009F3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x40009F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _descriptiveName;

		[Token(Token = "0x40009F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _id;

		[Token(Token = "0x40009F6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _typeGuidString;

		[Token(Token = "0x40009F7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<ControllerElementIdentifier> _elementIdentifiers;

		[Token(Token = "0x40009F8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Axis> _axes;

		[Token(Token = "0x40009F9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<Button> _buttons;

		[Token(Token = "0x40009FA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int _elementIdentifierIdCounter;

		[Token(Token = "0x17000392")]
		public string name
		{
			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x23752D4", Offset = "0x23752D4", VA = "0x23752D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000393")]
		public string descriptiveName
		{
			[Token(Token = "0x6000CF2")]
			[Address(RVA = "0x23752DC", Offset = "0x23752DC", VA = "0x23752DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000394")]
		public int id
		{
			[Token(Token = "0x6000CF3")]
			[Address(RVA = "0x23752E4", Offset = "0x23752E4", VA = "0x23752E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000395")]
		public Guid typeGuid
		{
			[Token(Token = "0x6000CF4")]
			[Address(RVA = "0x23752EC", Offset = "0x23752EC", VA = "0x23752EC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000396")]
		internal string typeGuidString
		{
			[Token(Token = "0x6000CF5")]
			[Address(RVA = "0x2375364", Offset = "0x2375364", VA = "0x2375364")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000397")]
		public List<Axis> axes
		{
			[Token(Token = "0x6000CF6")]
			[Address(RVA = "0x237536C", Offset = "0x237536C", VA = "0x237536C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000398")]
		public List<Button> buttons
		{
			[Token(Token = "0x6000CF7")]
			[Address(RVA = "0x2375374", Offset = "0x2375374", VA = "0x2375374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000399")]
		public int buttonCount
		{
			[Token(Token = "0x6000CF8")]
			[Address(RVA = "0x2373168", Offset = "0x2373168", VA = "0x2373168")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700039A")]
		public int axisCount
		{
			[Token(Token = "0x6000CF9")]
			[Address(RVA = "0x2373118", Offset = "0x2373118", VA = "0x2373118")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x237537C", Offset = "0x237537C", VA = "0x237537C")]
		public CustomController_Editor()
		{
		}

		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x23731B8", Offset = "0x23731B8", VA = "0x23731B8")]
		public string[] GetElementIdentifierNames()
		{
			return null;
		}

		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x2375490", Offset = "0x2375490", VA = "0x2375490")]
		public ControllerElementIdentifier[] GetElementIdentifiersTypeSorted()
		{
			return null;
		}

		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x2373054", Offset = "0x2373054", VA = "0x2373054")]
		public bool ContainsElementIdentifier(int id)
		{
			return default;
		}

		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x237573C", Offset = "0x237573C", VA = "0x237573C")]
		public int IndexOfElementIdentifier(int id)
		{
			return default;
		}

		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x2367958", Offset = "0x2367958", VA = "0x2367958")]
		public ControllerElementIdentifier GetElementIdentifier(int id)
		{
			return null;
		}

		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x23679EC", Offset = "0x23679EC", VA = "0x23679EC")]
		internal ControllerElementType GetEffectiveElementIdentifierType(int elementIdentifierId)
		{
			return default;
		}

		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x2367BE8", Offset = "0x2367BE8", VA = "0x2367BE8")]
		internal bool GetEffectiveAxisRange(int elementIdentifierId, out AxisRange axisRange)
		{
			return default;
		}

		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x2375804", Offset = "0x2375804", VA = "0x2375804")]
		internal HardwareControllerMap_Game CreateGameHardwareMap()
		{
			return null;
		}
	}
}
