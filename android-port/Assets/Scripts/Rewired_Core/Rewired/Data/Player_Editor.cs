using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[EditorBrowsable]
	public sealed class Player_Editor
	{
		[Serializable]
		[EditorBrowsable]
		public sealed class Mapping
		{
			[SerializeField]
			private bool _enabled;

			[SerializeField]
			private int _categoryId;

			[SerializeField]
			private int _layoutId;

			public void Clear()
			{
			}

			internal skUrVfnSYVIqLSMOQKrWFMoXjfWy leCRxbzLXHstujZFfxpfxRAhcfRo()
			{
				return null;
			}
		}

		[Serializable]
		[EditorBrowsable]
		public sealed class ControllerMapLayoutManagerSettings : IDeepCloneable
		{
			[SerializeField]
			private bool _enabled;

			[SerializeField]
			private bool _loadFromUserDataStore;

			[SerializeField]
			private List<RuleSetMapping> _ruleSets;

			public ControllerMapLayoutManagerSettings()
			{
			}

			public ControllerMapLayoutManagerSettings(ControllerMapLayoutManagerSettings P_0)
			{
			}

			internal ControllerMapLayoutManager.iZBHTLMJEscsCxujGlXwPdwYSOZv yMMoRTmlFkeyjRZhjJmIJpImkMHJ()
			{
				return null;
			}

			private vNnAsbNOxQRuVRxCcHhnyysOuoGy[] pBFUgMuZGVbXOxmTemAPDZAivczt()
			{
				return null;
			}

			object IDeepCloneable.DeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[EditorBrowsable]
		public sealed class ControllerMapEnablerSettings : IDeepCloneable
		{
			[SerializeField]
			private bool _enabled;

			[SerializeField]
			private List<RuleSetMapping> _ruleSets;

			public ControllerMapEnablerSettings()
			{
			}

			public ControllerMapEnablerSettings(ControllerMapEnablerSettings P_0)
			{
			}

			internal ControllerMapEnabler.oejthPnlmICeXCzkndFXvfozHuLjA yMMoRTmlFkeyjRZhjJmIJpImkMHJ()
			{
				return null;
			}

			private vNnAsbNOxQRuVRxCcHhnyysOuoGy[] pBFUgMuZGVbXOxmTemAPDZAivczt()
			{
				return null;
			}

			object IDeepCloneable.DeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[EditorBrowsable]
		public sealed class RuleSetMapping : IDeepCloneable
		{
			[SerializeField]
			private bool _enabled;

			[SerializeField]
			private int _id;

			public RuleSetMapping()
			{
			}

			public RuleSetMapping(RuleSetMapping P_0)
			{
			}

			public void Clear()
			{
			}

			internal vNnAsbNOxQRuVRxCcHhnyysOuoGy OxIfdrHgBXrLvKJsKxayQFwmyaqG()
			{
				return null;
			}

			object IDeepCloneable.DeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[EditorBrowsable]
		public sealed class CreateControllerInfo
		{
			[SerializeField]
			private int _sourceId;

			[SerializeField]
			private string _tag;

			public int sourceId => 0;

			public string tag => null;
		}

		[SerializeField]
		private int _id;

		[SerializeField]
		private string _name;

		[SerializeField]
		private string _descriptiveName;

		[SerializeField]
		private bool _startPlaying;

		[SerializeField]
		private List<Mapping> _defaultJoystickMaps;

		[SerializeField]
		private List<Mapping> _defaultMouseMaps;

		[SerializeField]
		private List<Mapping> _defaultKeyboardMaps;

		[SerializeField]
		private List<Mapping> _defaultCustomControllerMaps;

		[SerializeField]
		private List<CreateControllerInfo> _startingCustomControllers;

		[SerializeField]
		private bool _assignMouseOnStart;

		[SerializeField]
		private bool _assignKeyboardOnStart;

		[SerializeField]
		private bool _excludeFromControllerAutoAssignment;

		[SerializeField]
		private ControllerMapLayoutManagerSettings _controllerMapLayoutManagerSettings;

		[SerializeField]
		private ControllerMapEnablerSettings _controllerMapEnablerSettings;

		internal int id
		{
			set
			{
				JPbZDUeCyFLRqbbbjNbTfHOyjoLk(num);
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			internal set
			{
				CsQOAWYijZfmerTlmIiSxDfjlXTN(text);
			}
		}

		public string descriptiveName
		{
			get
			{
				return null;
			}
			internal set
			{
				sfIvBHTvDSWiArkDjaeZnAaDyaEo(text);
			}
		}

		public bool startPlaying
		{
			get
			{
				return false;
			}
			internal set
			{
				wecLYLNkqzqKLmTQSOtXGzWXGKiD(flag);
			}
		}

		public List<CreateControllerInfo> startingCustomControllers => null;

		public bool assignMouseOnStart
		{
			get
			{
				return false;
			}
			internal set
			{
				bqhYNtsiyJGFrujirYDTFIgZlCDs(flag);
			}
		}

		public bool assignKeyboardOnStart
		{
			get
			{
				return false;
			}
			internal set
			{
				pzdttbBVBHLnMKxbYSvdLzhekRao(flag);
			}
		}

		public bool excludeFromControllerAutoAssignment
		{
			get
			{
				return false;
			}
			internal set
			{
				JaqkwxeAeAaAjzTwxtXYjgaJLDfJ(flag);
			}
		}

		public ControllerMapLayoutManagerSettings controllerMapLayoutManagerSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ControllerMapEnablerSettings controllerMapEnablerSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal void JPbZDUeCyFLRqbbbjNbTfHOyjoLk(int P_0)
		{
		}

		internal void CsQOAWYijZfmerTlmIiSxDfjlXTN(string P_0)
		{
		}

		internal void sfIvBHTvDSWiArkDjaeZnAaDyaEo(string P_0)
		{
		}

		internal void wecLYLNkqzqKLmTQSOtXGzWXGKiD(bool P_0)
		{
		}

		internal void bqhYNtsiyJGFrujirYDTFIgZlCDs(bool P_0)
		{
		}

		internal void pzdttbBVBHLnMKxbYSvdLzhekRao(bool P_0)
		{
		}

		internal void JaqkwxeAeAaAjzTwxtXYjgaJLDfJ(bool P_0)
		{
		}

		internal ypwUncqYrrgWARbofZIocbdoyJzm bPCRfTsZBWAqvvaTkOFDsaqvDzII()
		{
			return null;
		}
	}
}
