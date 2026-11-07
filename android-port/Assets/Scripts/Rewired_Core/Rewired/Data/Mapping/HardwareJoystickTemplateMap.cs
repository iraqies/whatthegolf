using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Token(Token = "0x20002A1")]
	public sealed class HardwareJoystickTemplateMap : HardwareControllerTemplateMap, IHardwareControllerMap, IHardwareControllerTemplateMap, IHardwareControllerMap_Internal, IHardwareControllerTemplateMap_Internal
	{
		[Serializable]
		[Token(Token = "0x20002A2")]
		public sealed class Entry
		{
			[Token(Token = "0x4000E24")]
			[FieldOffset(Offset = "0x10")]
			public int id;

			[Token(Token = "0x4000E25")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000E26")]
			[FieldOffset(Offset = "0x20")]
			public string joystickGuid;

			[Token(Token = "0x4000E27")]
			[FieldOffset(Offset = "0x28")]
			public string fileGuid;

			[Token(Token = "0x4000E28")]
			[FieldOffset(Offset = "0x30")]
			public List<ElementIdentifierMap> elementIdentifierMappings;

			[Token(Token = "0x1700054F")]
			public Guid JoystickGuid
			{
				[Token(Token = "0x600137E")]
				[Address(RVA = "0x24886B0", Offset = "0x24886B0", VA = "0x24886B0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600137F")]
			[Address(RVA = "0x24887E8", Offset = "0x24887E8", VA = "0x24887E8")]
			public int GetTemplateElementId(int joystickElementId)
			{
				return default;
			}

			[Token(Token = "0x6001380")]
			[Address(RVA = "0x24888C8", Offset = "0x24888C8", VA = "0x24888C8")]
			public void GetElementIdentifierMaps(int templateId, List<ElementIdentifierMap> results)
			{
			}

			[Token(Token = "0x6001381")]
			[Address(RVA = "0x24889D0", Offset = "0x24889D0", VA = "0x24889D0")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002A3")]
		public sealed class ElementIdentifierMap
		{
			[Token(Token = "0x4000E29")]
			[FieldOffset(Offset = "0x10")]
			public int templateId;

			[Token(Token = "0x4000E2A")]
			[FieldOffset(Offset = "0x14")]
			public int joystickId;

			[Token(Token = "0x4000E2B")]
			[FieldOffset(Offset = "0x18")]
			public int joystickId2;

			[Token(Token = "0x4000E2C")]
			[FieldOffset(Offset = "0x1C")]
			public bool splitAxis;

			[Token(Token = "0x6001382")]
			[Address(RVA = "0x24886A8", Offset = "0x24886A8", VA = "0x24886A8")]
			public ElementIdentifierMap()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002A4")]
		public sealed class SpecialElementEntry : IControllerTemplateMapSpecialElement_Internal
		{
			[Token(Token = "0x4000E2D")]
			[FieldOffset(Offset = "0x10")]
			public int elementIdentifierId;

			[Token(Token = "0x4000E2E")]
			[FieldOffset(Offset = "0x18")]
			public string data;

			[Token(Token = "0x6001383")]
			private T Rewired_002EData_002EMapping_002EIControllerTemplateMapSpecialElement_Internal_002EGetMapping<T>() where T : ControllerTemplateSpecialElementMapping
			{
				return null;
			}

			[Token(Token = "0x6001384")]
			[Address(RVA = "0x2488BE4", Offset = "0x2488BE4", VA = "0x2488BE4")]
			public SpecialElementEntry()
			{
			}
		}

		[Token(Token = "0x20002A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1919CC", Offset = "0x1919CC")]
		private sealed class WHRsxpxEybuaFhhfBXutkRQNiVQX : IDisposable, IEnumerable, IEnumerator, IEnumerable<IControllerElementIdentifierCommon_Internal>, IEnumerator<IControllerElementIdentifierCommon_Internal>
		{
			[Token(Token = "0x4000E2F")]
			[FieldOffset(Offset = "0x10")]
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			[Token(Token = "0x4000E30")]
			[FieldOffset(Offset = "0x18")]
			private IControllerElementIdentifierCommon_Internal VqEePGSMyrGKIqkWibsjeHcWPSIx;

			[Token(Token = "0x4000E31")]
			[FieldOffset(Offset = "0x20")]
			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			[Token(Token = "0x4000E32")]
			[FieldOffset(Offset = "0x28")]
			public HardwareJoystickTemplateMap TtytLoUfsgUyhsklaKccrnoMiiek;

			[Token(Token = "0x4000E33")]
			[FieldOffset(Offset = "0x30")]
			private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

			[Token(Token = "0x17000550")]
			private IControllerElementIdentifierCommon_Internal System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EInterfaces_002EIControllerElementIdentifierCommon_Internal_003E_002ECurrent
			{
				[Token(Token = "0x6001388")]
				[Address(RVA = "0x2488CEC", Offset = "0x2488CEC", VA = "0x2488CEC", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EInterfaces_002EIControllerElementIdentifierCommon_Internal_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000551")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600138A")]
				[Address(RVA = "0x2488D34", Offset = "0x2488D34", VA = "0x2488D34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001385")]
			[Address(RVA = "0x2488BF4", Offset = "0x2488BF4", VA = "0x2488BF4")]
			[DebuggerHidden]
			public WHRsxpxEybuaFhhfBXutkRQNiVQX(int P_0)
			{
			}

			[Token(Token = "0x6001386")]
			[Address(RVA = "0x2488C3C", Offset = "0x2488C3C", VA = "0x2488C3C", Slot = "4")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6001387")]
			[Address(RVA = "0x2488C40", Offset = "0x2488C40", VA = "0x2488C40", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001388")]
			[Address(RVA = "0x2488CEC", Offset = "0x2488CEC", VA = "0x2488CEC", Slot = "10")]
			[DebuggerHidden]
			private IControllerElementIdentifierCommon_Internal System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EInterfaces_002EIControllerElementIdentifierCommon_Internal_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001389")]
			[Address(RVA = "0x2488CF4", Offset = "0x2488CF4", VA = "0x2488CF4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600138A")]
			[Address(RVA = "0x2488D34", Offset = "0x2488D34", VA = "0x2488D34", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600138B")]
			[Address(RVA = "0x2488D3C", Offset = "0x2488D3C", VA = "0x2488D3C", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<IControllerElementIdentifierCommon_Internal> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EInterfaces_002EIControllerElementIdentifierCommon_Internal_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600138C")]
			[Address(RVA = "0x2488DFC", Offset = "0x2488DFC", VA = "0x2488DFC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20002A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1919DC", Offset = "0x1919DC")]
		private sealed class PdmLmOZATAAgJaEHqmEOUkrITuVtA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerTemplateElementIdentifier>, IEnumerator<ControllerTemplateElementIdentifier>
		{
			[Token(Token = "0x4000E34")]
			[FieldOffset(Offset = "0x10")]
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			[Token(Token = "0x4000E35")]
			[FieldOffset(Offset = "0x18")]
			private ControllerTemplateElementIdentifier VqEePGSMyrGKIqkWibsjeHcWPSIx;

			[Token(Token = "0x4000E36")]
			[FieldOffset(Offset = "0x20")]
			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			[Token(Token = "0x4000E37")]
			[FieldOffset(Offset = "0x28")]
			public HardwareJoystickTemplateMap TtytLoUfsgUyhsklaKccrnoMiiek;

			[Token(Token = "0x4000E38")]
			[FieldOffset(Offset = "0x30")]
			private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

			[Token(Token = "0x17000552")]
			private ControllerTemplateElementIdentifier System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EControllerTemplateElementIdentifier_003E_002ECurrent
			{
				[Token(Token = "0x6001390")]
				[Address(RVA = "0x2488AD0", Offset = "0x2488AD0", VA = "0x2488AD0", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EControllerTemplateElementIdentifier_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000553")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001392")]
				[Address(RVA = "0x2488B18", Offset = "0x2488B18", VA = "0x2488B18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600138D")]
			[Address(RVA = "0x24889D8", Offset = "0x24889D8", VA = "0x24889D8")]
			[DebuggerHidden]
			public PdmLmOZATAAgJaEHqmEOUkrITuVtA(int P_0)
			{
			}

			[Token(Token = "0x600138E")]
			[Address(RVA = "0x2488A20", Offset = "0x2488A20", VA = "0x2488A20", Slot = "4")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600138F")]
			[Address(RVA = "0x2488A24", Offset = "0x2488A24", VA = "0x2488A24", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001390")]
			[Address(RVA = "0x2488AD0", Offset = "0x2488AD0", VA = "0x2488AD0", Slot = "10")]
			[DebuggerHidden]
			private ControllerTemplateElementIdentifier System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EControllerTemplateElementIdentifier_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001391")]
			[Address(RVA = "0x2488AD8", Offset = "0x2488AD8", VA = "0x2488AD8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001392")]
			[Address(RVA = "0x2488B18", Offset = "0x2488B18", VA = "0x2488B18", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001393")]
			[Address(RVA = "0x2488B20", Offset = "0x2488B20", VA = "0x2488B20", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<ControllerTemplateElementIdentifier> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EControllerTemplateElementIdentifier_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6001394")]
			[Address(RVA = "0x2488BE0", Offset = "0x2488BE0", VA = "0x2488BE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000E1B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string controllerName;

		[Token(Token = "0x4000E1C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string description;

		[Token(Token = "0x4000E1D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string templateGuid;

		[Token(Token = "0x4000E1E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string className;

		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ControllerTemplateElementIdentifier_Editor[] elementIdentifiers;

		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<Entry> joysticks;

		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SpecialElementEntry[] specialElements;

		[Token(Token = "0x4000E22")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int elementIdentifierIdCounter;

		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private int joystickIdCounter;

		[Token(Token = "0x17000548")]
		public override Guid Guid
		{
			[Token(Token = "0x600135E")]
			[Address(RVA = "0x23CFB80", Offset = "0x23CFB80", VA = "0x23CFB80", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000549")]
		public string ControllerName
		{
			[Token(Token = "0x600135F")]
			[Address(RVA = "0x23CFBF8", Offset = "0x23CFBF8", VA = "0x23CFBF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054A")]
		public string ClassName
		{
			[Token(Token = "0x6001360")]
			[Address(RVA = "0x23CFC00", Offset = "0x23CFC00", VA = "0x23CFC00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054B")]
		public IEnumerable<ControllerTemplateElementIdentifier> ElementIdentifiers
		{
			[Token(Token = "0x6001361")]
			[Address(RVA = "0x23CFC08", Offset = "0x23CFC08", VA = "0x23CFC08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054C")]
		private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired_002EData_002EMapping_002EIHardwareControllerMap_Internal_002EElementIdentifiers
		{
			[Token(Token = "0x6001373")]
			[Address(RVA = "0x23D18F8", Offset = "0x23D18F8", VA = "0x23D18F8", Slot = "5")]
			get
			{
				return Rewired_002EData_002EMapping_002EIHardwareControllerMap_Internal_002Eget_ElementIdentifiers();
			}
		}

		[Token(Token = "0x1700054D")]
		private string Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002Ename
		{
			[Token(Token = "0x6001375")]
			[Address(RVA = "0x23D19FC", Offset = "0x23D19FC", VA = "0x23D19FC", Slot = "7")]
			get
			{
				return Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002Eget_name();
			}
		}

		[Token(Token = "0x1700054E")]
		private Guid Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002EtypeGuid
		{
			[Token(Token = "0x6001376")]
			[Address(RVA = "0x23D1A04", Offset = "0x23D1A04", VA = "0x23D1A04", Slot = "8")]
			get
			{
				return Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002Eget_typeGuid();
			}
		}

		[Token(Token = "0x6001362")]
		[Address(RVA = "0x23CFC7C", Offset = "0x23CFC7C", VA = "0x23CFC7C")]
		public ControllerTemplateElementIdentifier GetElementIdentifier(int id)
		{
			return null;
		}

		[Token(Token = "0x6001363")]
		[Address(RVA = "0x23CFD60", Offset = "0x23CFD60", VA = "0x23CFD60", Slot = "15")]
		public bool ContainsElementIdentifier(int id)
		{
			return default;
		}

		[Token(Token = "0x6001364")]
		[Address(RVA = "0x23CFDCC", Offset = "0x23CFDCC", VA = "0x23CFDCC", Slot = "16")]
		public string[] GetElementIdentifierNames()
		{
			return null;
		}

		[Token(Token = "0x6001365")]
		[Address(RVA = "0x23CFED4", Offset = "0x23CFED4", VA = "0x23CFED4", Slot = "17")]
		public int[] GetElementIdentifierIds()
		{
			return null;
		}

		[Token(Token = "0x6001366")]
		[Address(RVA = "0x23CFFA0", Offset = "0x23CFFA0", VA = "0x23CFFA0")]
		internal string[] GetElementIdentifierScriptingNames(bool useAlternate)
		{
			return null;
		}

		[Token(Token = "0x6001367")]
		[Address(RVA = "0x23D010C", Offset = "0x23D010C", VA = "0x23D010C", Slot = "18")]
		public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids)
		{
			return default;
		}

		[Token(Token = "0x6001368")]
		[Address(RVA = "0x23D03BC", Offset = "0x23D03BC", VA = "0x23D03BC")]
		public int GetNonMappableElementIdentifierInfo(out string[] names, out int[] ids)
		{
			return default;
		}

		[Token(Token = "0x6001369")]
		[Address(RVA = "0x23D0660", Offset = "0x23D0660", VA = "0x23D0660")]
		public string[] GetJoystickNames()
		{
			return null;
		}

		[Token(Token = "0x600136A")]
		[Address(RVA = "0x23D078C", Offset = "0x23D078C", VA = "0x23D078C")]
		public int[] GetJoystickIds()
		{
			return null;
		}

		[Token(Token = "0x600136B")]
		[Address(RVA = "0x23D0894", Offset = "0x23D0894", VA = "0x23D0894")]
		public Guid GetJoystickGuid(int joystickId)
		{
			return default;
		}

		[Token(Token = "0x600136C")]
		[Address(RVA = "0x23D09F0", Offset = "0x23D09F0", VA = "0x23D09F0")]
		public int GetJoystickId(Guid guid)
		{
			return default;
		}

		[Token(Token = "0x600136D")]
		[Address(RVA = "0x23D0B70", Offset = "0x23D0B70", VA = "0x23D0B70")]
		public string GetJoystickFileGuidString(int joystickId)
		{
			return null;
		}

		[Token(Token = "0x600136E")]
		[Address(RVA = "0x23D0C6C", Offset = "0x23D0C6C", VA = "0x23D0C6C")]
		internal bool FnsmXdiZXlVuhjyKGKBoTnaakMhL(ControllerMap_Editor P_0, HardwareJoystickMap P_1, Guid P_2, out string P_3)
		{
			return default;
		}

		[Token(Token = "0x600136F")]
		[Address(RVA = "0x23D1704", Offset = "0x23D1704", VA = "0x23D1704")]
		internal ControllerTemplateElementIdentifier TQKQOcjTcFmNzxDgybZxLvFfTrkC(Guid P_0, int P_1)
		{
			return null;
		}

		[Token(Token = "0x6001370")]
		[Address(RVA = "0x23D18F0", Offset = "0x23D18F0", VA = "0x23D18F0")]
		internal SpecialElementEntry[] GetSpecialElementsOrig()
		{
			return null;
		}

		[Token(Token = "0x6001371")]
		[Address(RVA = "0x23D15C8", Offset = "0x23D15C8", VA = "0x23D15C8")]
		private Entry FanGsmXappFogsAqPdlAABpkQqvtA(Guid P_0)
		{
			return null;
		}

		[Token(Token = "0x6001372")]
		[Address(RVA = "0x23CFD0C", Offset = "0x23CFD0C", VA = "0x23CFD0C")]
		private int kwBxRrTMOUcPoxanwKoMBibCqnok(int P_0)
		{
			return default;
		}

		[Token(Token = "0x6001373")]
		[Address(RVA = "0x23D18F8", Offset = "0x23D18F8", VA = "0x23D18F8", Slot = "5")]
		private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired_002EData_002EMapping_002EIHardwareControllerMap_Internal_002Eget_ElementIdentifiers()
		{
			return null;
		}

		[Token(Token = "0x6001374")]
		[Address(RVA = "0x23D196C", Offset = "0x23D196C", VA = "0x23D196C", Slot = "6")]
		private IControllerElementIdentifierCommon_Internal Rewired_002EData_002EMapping_002EIHardwareControllerMap_Internal_002EGetElementIdentifier(int id)
		{
			return null;
		}

		[Token(Token = "0x6001375")]
		[Address(RVA = "0x23D19FC", Offset = "0x23D19FC", VA = "0x23D19FC", Slot = "7")]
		private string Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002Eget_name()
		{
			return null;
		}

		[Token(Token = "0x6001376")]
		[Address(RVA = "0x23D1A04", Offset = "0x23D1A04", VA = "0x23D1A04", Slot = "8")]
		private Guid Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002Eget_typeGuid()
		{
			return default;
		}

		[Token(Token = "0x6001377")]
		[Address(RVA = "0x23D1A10", Offset = "0x23D1A10", VA = "0x23D1A10", Slot = "9")]
		private int Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002EGetElementIdentifierCount()
		{
			return default;
		}

		[Token(Token = "0x6001378")]
		[Address(RVA = "0x23D1A28", Offset = "0x23D1A28", VA = "0x23D1A28", Slot = "10")]
		private IControllerTemplateElementIdentifier Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002EGetTemplateElementIdentifier(int index)
		{
			return null;
		}

		[Token(Token = "0x6001379")]
		[Address(RVA = "0x23D1A64", Offset = "0x23D1A64", VA = "0x23D1A64", Slot = "11")]
		private IControllerTemplateElementIdentifier Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002EGetTemplateElementIdentifierById(int elementIdentifierId)
		{
			return null;
		}

		[Token(Token = "0x600137A")]
		[Address(RVA = "0x23D1AF4", Offset = "0x23D1AF4", VA = "0x23D1AF4", Slot = "12")]
		private IControllerTemplateMapSpecialElement_Internal Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002EGetSpecialTemplateElementByElementIdentifierId(int id)
		{
			return null;
		}

		[Token(Token = "0x600137B")]
		[Address(RVA = "0x23D1B3C", Offset = "0x23D1B3C", VA = "0x23D1B3C", Slot = "13")]
		private HxKJTjnYRTlXmgqyhXzejFNHdCai Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002EGetAxisTarget(Controller controller, int elementIdentifierId)
		{
			return null;
		}

		[Token(Token = "0x600137C")]
		[Address(RVA = "0x23D1EEC", Offset = "0x23D1EEC", VA = "0x23D1EEC", Slot = "14")]
		private HxKJTjnYRTlXmgqyhXzejFNHdCai Rewired_002EData_002EMapping_002EIHardwareControllerTemplateMap_Internal_002EGetButtonTarget(Controller controller, int elementIdentifierId)
		{
			return null;
		}

		[Token(Token = "0x600137D")]
		[Address(RVA = "0x23D210C", Offset = "0x23D210C", VA = "0x23D210C")]
		public HardwareJoystickTemplateMap()
		{
		}
	}
}
