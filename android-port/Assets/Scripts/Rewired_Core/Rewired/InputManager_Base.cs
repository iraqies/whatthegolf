using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Rewired.Config;
using Rewired.Data;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired
{
	[EditorBrowsable]
	[ExecuteInEditMode]
	public abstract class InputManager_Base : MonoBehaviour
	{
		private enum wLUoCFKlqWfvuGYLfIRDzsOxLbwc
		{
			Initialization = 0,
			Update = 1,
			Destroy = 2
		}

		[SerializeField]
		private bool _dontDestroyOnLoad;

		[SerializeField]
		private UserData _userData;

		[SerializeField]
		private ControllerDataFiles _controllerDataFiles;

		protected bool isCompiling;

		[NonSerialized]
		private bool jYTNgflwwEgvgbZuuTHYnPAnuRao;

		[NonSerialized]
		private bool jZTIrVOMCCBVfvfCHRSUuSLsfZOv;

		[NonSerialized]
		protected EditorPlatform editorPlatform;

		[NonSerialized]
		protected Platform platform;

		[NonSerialized]
		protected WebplayerPlatform webplayerPlatform;

		[NonSerialized]
		protected bool isEditor;

		[NonSerialized]
		protected bool _detectedPlatformInEditor;

		[NonSerialized]
		protected ScriptingBackend scriptingBackend;

		[NonSerialized]
		protected ScriptingAPILevel scriptingAPILevel;

		[NonSerialized]
		private bool gbrXtPXBecghwnDbfiegSQixifkc;

		private bool HixilYgnPTbdgcJPGouUELeLijtEb;

		public UserData userData
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public ControllerDataFiles dataFiles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool runInEditMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool isRunningInEditMode => false;

		internal void DontDestroyOnLoad()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationFocus(bool isFocused)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		internal void OnGUIUpdate()
		{
		}

		internal void DoUpdate(UpdateLoopType updateLoopType, UpdateLoopSetting updateLoopSettingBit)
		{
		}

		internal void TryStartRunInEditMode()
		{
		}

		internal void TryStopRunInEditMode()
		{
		}

		private bool LtkEsZTFSFJoixMshdtiDXKYDcds()
		{
			return false;
		}

		private void zQQfvDZMmpVqPPLYlLuSJXXpwJcI()
		{
		}

		private object FkukJkUXfLyOaOSdbijqYylsACHh(ConfigVars P_0)
		{
			return null;
		}

		private List<Assembly> FsrIzLggzQMIqapFPIIjWrjcfWRG()
		{
			return null;
		}

		private List<Assembly> kONypgklnsoRVJkAdjjNDvHUUFdr()
		{
			return null;
		}

		private byte[] ZYazwninVCoqUAmnylbAjhkhihEU()
		{
			return null;
		}

		private void ySxZymhJridYyTFswYqcTxJLEvhA(List<TextAsset> P_0, List<string> P_1)
		{
		}

		private string UUfbDIIprGNfWbGLHDWoNmhGRrhtA()
		{
			return null;
		}

		private bool nmXHNbmHygAhLOJKLJnkPakEgxAI()
		{
			return false;
		}

		private string NgYbhRQsRrGlTGkdNZmUGtwnTqBTA()
		{
			return null;
		}

		private bool qfucMoxItzABNVgftsaYcKIMmqKr()
		{
			return false;
		}

		protected void RecompileStart()
		{
		}

		protected void RecompileEnd()
		{
		}

		protected void OnSceneLoaded()
		{
		}

		private void yLvdWLXoeOUisLcdGZdTHlLChJky(wLUoCFKlqWfvuGYLfIRDzsOxLbwc P_0, string P_1, Exception P_2)
		{
		}

		internal void ResetAll()
		{
		}

		internal EditorPlatform GetEditorPlatform()
		{
			return EditorPlatform.None;
		}

		internal void GetSupportedEditModeControllerTypes(out bool keyboardSupported, out bool mouseSupported, out bool joystickSupported)
		{
			keyboardSupported = default;
			mouseSupported = default;
			joystickSupported = default;
		}

		internal bool IsEditModeSupported()
		{
			return false;
		}

		protected abstract void OnInitialized();

		protected abstract void OnDeinitialized();

		protected abstract void DetectPlatform();

		protected abstract void CheckRecompile();

		protected abstract IExternalTools GetExternalTools();

		[CompilerGenerated]
		private bool ghVeosbvKHzPEjyrjugYGYpkSjGG(Assembly P_0)
		{
			return false;
		}
	}
}
