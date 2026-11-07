using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	public sealed class HardwareJoystickTemplateMap : HardwareControllerTemplateMap, IHardwareControllerMap, IHardwareControllerTemplateMap, IHardwareControllerMap_Internal, IHardwareControllerTemplateMap_Internal
	{
		[Serializable]
		public sealed class Entry
		{
			public int id;

			public string name;

			public string joystickGuid;

			public string fileGuid;

			public List<ElementIdentifierMap> elementIdentifierMappings;

			public Guid JoystickGuid => default;

			public int GetTemplateElementId(int joystickElementId)
			{
				return 0;
			}

			public void GetElementIdentifierMaps(int templateId, List<ElementIdentifierMap> results)
			{
			}
		}

		[Serializable]
		public sealed class ElementIdentifierMap
		{
			public int templateId;

			public int joystickId;

			public int joystickId2;

			public bool splitAxis;
		}

		[Serializable]
		public sealed class SpecialElementEntry : IControllerTemplateMapSpecialElement_Internal
		{
			public int elementIdentifierId;

			public string data;

			T IControllerTemplateMapSpecialElement_Internal.GetMapping<T>()
			{
				return null;
			}
		}

		private sealed class WHRsxpxEybuaFhhfBXutkRQNiVQX : IDisposable, IEnumerable, IEnumerator, IEnumerable<IControllerElementIdentifierCommon_Internal>, IEnumerator<IControllerElementIdentifierCommon_Internal>
		{
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			private IControllerElementIdentifierCommon_Internal VqEePGSMyrGKIqkWibsjeHcWPSIx;

			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			public HardwareJoystickTemplateMap TtytLoUfsgUyhsklaKccrnoMiiek;

			private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

			IControllerElementIdentifierCommon_Internal IEnumerator<IControllerElementIdentifierCommon_Internal>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public WHRsxpxEybuaFhhfBXutkRQNiVQX(int P_0)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<IControllerElementIdentifierCommon_Internal> IEnumerable<IControllerElementIdentifierCommon_Internal>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private sealed class PdmLmOZATAAgJaEHqmEOUkrITuVtA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerTemplateElementIdentifier>, IEnumerator<ControllerTemplateElementIdentifier>
		{
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			private ControllerTemplateElementIdentifier VqEePGSMyrGKIqkWibsjeHcWPSIx;

			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			public HardwareJoystickTemplateMap TtytLoUfsgUyhsklaKccrnoMiiek;

			private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

			ControllerTemplateElementIdentifier IEnumerator<ControllerTemplateElementIdentifier>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public PdmLmOZATAAgJaEHqmEOUkrITuVtA(int P_0)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<ControllerTemplateElementIdentifier> IEnumerable<ControllerTemplateElementIdentifier>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[SerializeField]
		private string controllerName;

		[SerializeField]
		private string description;

		[SerializeField]
		private string templateGuid;

		[SerializeField]
		private string className;

		[SerializeField]
		private ControllerTemplateElementIdentifier_Editor[] elementIdentifiers;

		[SerializeField]
		private List<Entry> joysticks;

		[SerializeField]
		private SpecialElementEntry[] specialElements;

		[SerializeField]
		private int elementIdentifierIdCounter;

		[SerializeField]
		private int joystickIdCounter;

		public override Guid Guid => default;

		public string ControllerName => null;

		public string ClassName => null;

		public IEnumerable<ControllerTemplateElementIdentifier> ElementIdentifiers => null;

		IEnumerable<IControllerElementIdentifierCommon_Internal> IHardwareControllerMap_Internal.ElementIdentifiers => null;

		string IHardwareControllerTemplateMap_Internal.name => null;

		Guid IHardwareControllerTemplateMap_Internal.typeGuid => default;

		public ControllerTemplateElementIdentifier GetElementIdentifier(int id)
		{
			return null;
		}

		public bool ContainsElementIdentifier(int id)
		{
			return false;
		}

		public string[] GetElementIdentifierNames()
		{
			return null;
		}

		public int[] GetElementIdentifierIds()
		{
			return null;
		}

		internal string[] GetElementIdentifierScriptingNames(bool useAlternate)
		{
			return null;
		}

		public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids)
		{
			names = null;
			ids = null;
			return 0;
		}

		public int GetNonMappableElementIdentifierInfo(out string[] names, out int[] ids)
		{
			names = null;
			ids = null;
			return 0;
		}

		public string[] GetJoystickNames()
		{
			return null;
		}

		public int[] GetJoystickIds()
		{
			return null;
		}

		public Guid GetJoystickGuid(int joystickId)
		{
			return default;
		}

		public int GetJoystickId(Guid guid)
		{
			return 0;
		}

		public string GetJoystickFileGuidString(int joystickId)
		{
			return null;
		}

		internal bool FnsmXdiZXlVuhjyKGKBoTnaakMhL(ControllerMap_Editor P_0, HardwareJoystickMap P_1, Guid P_2, out string P_3)
		{
			P_3 = null;
			return false;
		}

		internal ControllerTemplateElementIdentifier TQKQOcjTcFmNzxDgybZxLvFfTrkC(Guid P_0, int P_1)
		{
			return null;
		}

		internal SpecialElementEntry[] GetSpecialElementsOrig()
		{
			return null;
		}

		private Entry FanGsmXappFogsAqPdlAABpkQqvtA(Guid P_0)
		{
			return null;
		}

		private int kwBxRrTMOUcPoxanwKoMBibCqnok(int P_0)
		{
			return 0;
		}

		IControllerElementIdentifierCommon_Internal IHardwareControllerMap_Internal.GetElementIdentifier(int id)
		{
			return null;
		}

		int IHardwareControllerTemplateMap_Internal.GetElementIdentifierCount()
		{
			return 0;
		}

		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifier(int index)
		{
			return null;
		}

		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifierById(int elementIdentifierId)
		{
			return null;
		}

		IControllerTemplateMapSpecialElement_Internal IHardwareControllerTemplateMap_Internal.GetSpecialTemplateElementByElementIdentifierId(int id)
		{
			return null;
		}

		HxKJTjnYRTlXmgqyhXzejFNHdCai IHardwareControllerTemplateMap_Internal.GetAxisTarget(Controller controller, int elementIdentifierId)
		{
			return null;
		}

		HxKJTjnYRTlXmgqyhXzejFNHdCai IHardwareControllerTemplateMap_Internal.GetButtonTarget(Controller controller, int elementIdentifierId)
		{
			return null;
		}
	}
}
