using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Token(Token = "0x20001C0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1913D4", Offset = "0x1913D4")]
	[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x1913D4", Offset = "0x1913D4")]
	public sealed class Player_Editor
	{
		[Serializable]
		[Token(Token = "0x20001C1")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191414", Offset = "0x191414")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x191414", Offset = "0x191414")]
		public sealed class Mapping
		{
			[Token(Token = "0x4000A26")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _enabled;

			[Token(Token = "0x4000A27")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int _categoryId;

			[Token(Token = "0x4000A28")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _layoutId;

			[Token(Token = "0x6000D21")]
			[Address(RVA = "0x238F0C8", Offset = "0x238F0C8", VA = "0x238F0C8")]
			public Mapping()
			{
			}

			[Token(Token = "0x6000D22")]
			[Address(RVA = "0x238F0F8", Offset = "0x238F0F8", VA = "0x238F0F8")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000D23")]
			[Address(RVA = "0x238F108", Offset = "0x238F108", VA = "0x238F108")]
			internal skUrVfnSYVIqLSMOQKrWFMoXjfWy leCRxbzLXHstujZFfxpfxRAhcfRo()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20001C2")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191454", Offset = "0x191454")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x191454", Offset = "0x191454")]
		public sealed class ControllerMapLayoutManagerSettings : IDeepCloneable
		{
			[Token(Token = "0x4000A29")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _enabled;

			[Token(Token = "0x4000A2A")]
			[FieldOffset(Offset = "0x11")]
			[SerializeField]
			private bool _loadFromUserDataStore;

			[Token(Token = "0x4000A2B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private List<RuleSetMapping> _ruleSets;

			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x238EC14", Offset = "0x238EC14", VA = "0x238EC14")]
			public ControllerMapLayoutManagerSettings()
			{
			}

			[Token(Token = "0x6000D25")]
			[Address(RVA = "0x238ECA4", Offset = "0x238ECA4", VA = "0x238ECA4")]
			public ControllerMapLayoutManagerSettings(ControllerMapLayoutManagerSettings P_0)
			{
			}

			[Token(Token = "0x6000D26")]
			[Address(RVA = "0x238EE00", Offset = "0x238EE00", VA = "0x238EE00")]
			internal ControllerMapLayoutManager.iZBHTLMJEscsCxujGlXwPdwYSOZv yMMoRTmlFkeyjRZhjJmIJpImkMHJ()
			{
				return null;
			}

			[Token(Token = "0x6000D27")]
			[Address(RVA = "0x238EE88", Offset = "0x238EE88", VA = "0x238EE88")]
			private vNnAsbNOxQRuVRxCcHhnyysOuoGy[] pBFUgMuZGVbXOxmTemAPDZAivczt()
			{
				return null;
			}

			[Token(Token = "0x6000D28")]
			[Address(RVA = "0x238F04C", Offset = "0x238F04C", VA = "0x238F04C", Slot = "4")]
			private object Rewired_002EUtils_002EInterfaces_002EIDeepCloneable_002EDeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20001C3")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191494", Offset = "0x191494")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x191494", Offset = "0x191494")]
		public sealed class ControllerMapEnablerSettings : IDeepCloneable
		{
			[Token(Token = "0x4000A2C")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _enabled;

			[Token(Token = "0x4000A2D")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private List<RuleSetMapping> _ruleSets;

			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x238E70C", Offset = "0x238E70C", VA = "0x238E70C")]
			public ControllerMapEnablerSettings()
			{
			}

			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0x238E79C", Offset = "0x238E79C", VA = "0x238E79C")]
			public ControllerMapEnablerSettings(ControllerMapEnablerSettings P_0)
			{
			}

			[Token(Token = "0x6000D2B")]
			[Address(RVA = "0x238E8F8", Offset = "0x238E8F8", VA = "0x238E8F8")]
			internal ControllerMapEnabler.oejthPnlmICeXCzkndFXvfozHuLjA yMMoRTmlFkeyjRZhjJmIJpImkMHJ()
			{
				return null;
			}

			[Token(Token = "0x6000D2C")]
			[Address(RVA = "0x238E978", Offset = "0x238E978", VA = "0x238E978")]
			private vNnAsbNOxQRuVRxCcHhnyysOuoGy[] pBFUgMuZGVbXOxmTemAPDZAivczt()
			{
				return null;
			}

			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0x238EBB0", Offset = "0x238EBB0", VA = "0x238EBB0", Slot = "4")]
			private object Rewired_002EUtils_002EInterfaces_002EIDeepCloneable_002EDeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20001C4")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x1914D4", Offset = "0x1914D4")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1914D4", Offset = "0x1914D4")]
		public sealed class RuleSetMapping : IDeepCloneable
		{
			[Token(Token = "0x4000A2E")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _enabled;

			[Token(Token = "0x4000A2F")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int _id;

			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0x238F180", Offset = "0x238F180", VA = "0x238F180")]
			public RuleSetMapping()
			{
			}

			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x238F1C0", Offset = "0x238F1C0", VA = "0x238F1C0")]
			public RuleSetMapping(RuleSetMapping P_0)
			{
			}

			[Token(Token = "0x6000D30")]
			[Address(RVA = "0x238F1B0", Offset = "0x238F1B0", VA = "0x238F1B0")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000D31")]
			[Address(RVA = "0x238EB3C", Offset = "0x238EB3C", VA = "0x238EB3C")]
			internal vNnAsbNOxQRuVRxCcHhnyysOuoGy OxIfdrHgBXrLvKJsKxayQFwmyaqG()
			{
				return null;
			}

			[Token(Token = "0x6000D32")]
			[Address(RVA = "0x238F250", Offset = "0x238F250", VA = "0x238F250", Slot = "4")]
			private object Rewired_002EUtils_002EInterfaces_002EIDeepCloneable_002EDeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20001C5")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191514", Offset = "0x191514")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x191514", Offset = "0x191514")]
		public sealed class CreateControllerInfo
		{
			[Token(Token = "0x4000A30")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private int _sourceId;

			[Token(Token = "0x4000A31")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _tag;

			[Token(Token = "0x170003A5")]
			public int sourceId
			{
				[Token(Token = "0x6000D33")]
				[Address(RVA = "0x238F0B0", Offset = "0x238F0B0", VA = "0x238F0B0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170003A6")]
			public string tag
			{
				[Token(Token = "0x6000D34")]
				[Address(RVA = "0x238F0B8", Offset = "0x238F0B8", VA = "0x238F0B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D35")]
			[Address(RVA = "0x238F0C0", Offset = "0x238F0C0", VA = "0x238F0C0")]
			public CreateControllerInfo()
			{
			}
		}

		[Token(Token = "0x4000A18")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _id;

		[Token(Token = "0x4000A19")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x4000A1A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _descriptiveName;

		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _startPlaying;

		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Mapping> _defaultJoystickMaps;

		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Mapping> _defaultMouseMaps;

		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<Mapping> _defaultKeyboardMaps;

		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Mapping> _defaultCustomControllerMaps;

		[Token(Token = "0x4000A20")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<CreateControllerInfo> _startingCustomControllers;

		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _assignMouseOnStart;

		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool _assignKeyboardOnStart;

		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x5A")]
		[SerializeField]
		private bool _excludeFromControllerAutoAssignment;

		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ControllerMapLayoutManagerSettings _controllerMapLayoutManagerSettings;

		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ControllerMapEnablerSettings _controllerMapEnablerSettings;

		[Token(Token = "0x1700039B")]
		internal int id
		{
			[Token(Token = "0x6000D0D")]
			[Address(RVA = "0x23FEB60", Offset = "0x23FEB60", VA = "0x23FEB60")]
			set
			{
				JPbZDUeCyFLRqbbbjNbTfHOyjoLk(num);
			}
		}

		[Token(Token = "0x1700039C")]
		public string name
		{
			[Token(Token = "0x6000D0E")]
			[Address(RVA = "0x23FEB68", Offset = "0x23FEB68", VA = "0x23FEB68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D0F")]
			[Address(RVA = "0x23FEB70", Offset = "0x23FEB70", VA = "0x23FEB70")]
			internal set
			{
				CsQOAWYijZfmerTlmIiSxDfjlXTN(text);
			}
		}

		[Token(Token = "0x1700039D")]
		public string descriptiveName
		{
			[Token(Token = "0x6000D10")]
			[Address(RVA = "0x23FEB78", Offset = "0x23FEB78", VA = "0x23FEB78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D11")]
			[Address(RVA = "0x23FEB80", Offset = "0x23FEB80", VA = "0x23FEB80")]
			internal set
			{
				sfIvBHTvDSWiArkDjaeZnAaDyaEo(text);
			}
		}

		[Token(Token = "0x1700039E")]
		public bool startPlaying
		{
			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x23FEB88", Offset = "0x23FEB88", VA = "0x23FEB88")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x23FEB90", Offset = "0x23FEB90", VA = "0x23FEB90")]
			internal set
			{
				wecLYLNkqzqKLmTQSOtXGzWXGKiD(flag);
			}
		}

		[Token(Token = "0x1700039F")]
		public List<CreateControllerInfo> startingCustomControllers
		{
			[Token(Token = "0x6000D14")]
			[Address(RVA = "0x23FEB98", Offset = "0x23FEB98", VA = "0x23FEB98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A0")]
		public bool assignMouseOnStart
		{
			[Token(Token = "0x6000D15")]
			[Address(RVA = "0x23FEBA0", Offset = "0x23FEBA0", VA = "0x23FEBA0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D16")]
			[Address(RVA = "0x23FEBA8", Offset = "0x23FEBA8", VA = "0x23FEBA8")]
			internal set
			{
				bqhYNtsiyJGFrujirYDTFIgZlCDs(flag);
			}
		}

		[Token(Token = "0x170003A1")]
		public bool assignKeyboardOnStart
		{
			[Token(Token = "0x6000D17")]
			[Address(RVA = "0x23FEBB0", Offset = "0x23FEBB0", VA = "0x23FEBB0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x23FEBB8", Offset = "0x23FEBB8", VA = "0x23FEBB8")]
			internal set
			{
				pzdttbBVBHLnMKxbYSvdLzhekRao(flag);
			}
		}

		[Token(Token = "0x170003A2")]
		public bool excludeFromControllerAutoAssignment
		{
			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x23FEBC0", Offset = "0x23FEBC0", VA = "0x23FEBC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0x23FEBC8", Offset = "0x23FEBC8", VA = "0x23FEBC8")]
			internal set
			{
				JaqkwxeAeAaAjzTwxtXYjgaJLDfJ(flag);
			}
		}

		[Token(Token = "0x170003A3")]
		public ControllerMapLayoutManagerSettings controllerMapLayoutManagerSettings
		{
			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x23FEBD0", Offset = "0x23FEBD0", VA = "0x23FEBD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x23FEBD8", Offset = "0x23FEBD8", VA = "0x23FEBD8")]
			set
			{
			}
		}

		[Token(Token = "0x170003A4")]
		public ControllerMapEnablerSettings controllerMapEnablerSettings
		{
			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0x23FEBE0", Offset = "0x23FEBE0", VA = "0x23FEBE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x23FEBE8", Offset = "0x23FEBE8", VA = "0x23FEBE8")]
			set
			{
			}
		}

		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x23FEB60", Offset = "0x23FEB60", VA = "0x23FEB60")]
		internal void JPbZDUeCyFLRqbbbjNbTfHOyjoLk(int P_0)
		{
		}

		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x23FEB70", Offset = "0x23FEB70", VA = "0x23FEB70")]
		internal void CsQOAWYijZfmerTlmIiSxDfjlXTN(string P_0)
		{
		}

		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x23FEB80", Offset = "0x23FEB80", VA = "0x23FEB80")]
		internal void sfIvBHTvDSWiArkDjaeZnAaDyaEo(string P_0)
		{
		}

		[Token(Token = "0x6000D13")]
		[Address(RVA = "0x23FEB90", Offset = "0x23FEB90", VA = "0x23FEB90")]
		internal void wecLYLNkqzqKLmTQSOtXGzWXGKiD(bool P_0)
		{
		}

		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x23FEBA8", Offset = "0x23FEBA8", VA = "0x23FEBA8")]
		internal void bqhYNtsiyJGFrujirYDTFIgZlCDs(bool P_0)
		{
		}

		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x23FEBB8", Offset = "0x23FEBB8", VA = "0x23FEBB8")]
		internal void pzdttbBVBHLnMKxbYSvdLzhekRao(bool P_0)
		{
		}

		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x23FEBC8", Offset = "0x23FEBC8", VA = "0x23FEBC8")]
		internal void JaqkwxeAeAaAjzTwxtXYjgaJLDfJ(bool P_0)
		{
		}

		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x23FEBF0", Offset = "0x23FEBF0", VA = "0x23FEBF0")]
		public Player_Editor()
		{
		}

		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x23FED70", Offset = "0x23FED70", VA = "0x23FED70")]
		internal ypwUncqYrrgWARbofZIocbdoyJzm bPCRfTsZBWAqvvaTkOFDsaqvDzII()
		{
			return null;
		}
	}
}
