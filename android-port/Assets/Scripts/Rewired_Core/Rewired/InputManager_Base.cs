using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Rewired.Config;
using Rewired.Data;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x190A90", Offset = "0x190A90")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x190A90", Offset = "0x190A90")]
	public abstract class InputManager_Base : MonoBehaviour
	{
		[Token(Token = "0x20000B8")]
		private enum wLUoCFKlqWfvuGYLfIRDzsOxLbwc
		{
			[Token(Token = "0x4000419")]
			Initialization = 0,
			[Token(Token = "0x400041A")]
			Update = 1,
			[Token(Token = "0x400041B")]
			Destroy = 2
		}

		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _dontDestroyOnLoad;

		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UserData _userData;

		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ControllerDataFiles _controllerDataFiles;

		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x30")]
		protected bool isCompiling;

		[NonSerialized]
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x31")]
		private bool jYTNgflwwEgvgbZuuTHYnPAnuRao;

		[NonSerialized]
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x32")]
		private bool jZTIrVOMCCBVfvfCHRSUuSLsfZOv;

		[NonSerialized]
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x34")]
		protected EditorPlatform editorPlatform;

		[NonSerialized]
		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x38")]
		protected Platform platform;

		[NonSerialized]
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x3C")]
		protected WebplayerPlatform webplayerPlatform;

		[NonSerialized]
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x40")]
		protected bool isEditor;

		[NonSerialized]
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x41")]
		protected bool _detectedPlatformInEditor;

		[NonSerialized]
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x44")]
		protected ScriptingBackend scriptingBackend;

		[NonSerialized]
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x48")]
		protected ScriptingAPILevel scriptingAPILevel;

		[NonSerialized]
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x4C")]
		private bool gbrXtPXBecghwnDbfiegSQixifkc;

		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x4D")]
		private bool HixilYgnPTbdgcJPGouUELeLijtEb;

		[Token(Token = "0x17000192")]
		public UserData userData
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x23D4040", Offset = "0x23D4040", VA = "0x23D4040")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x23D4048", Offset = "0x23D4048", VA = "0x23D4048")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000193")]
		public ControllerDataFiles dataFiles
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x23D4050", Offset = "0x23D4050", VA = "0x23D4050")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x23D4058", Offset = "0x23D4058", VA = "0x23D4058")]
			set
			{
			}
		}

		[Token(Token = "0x17000194")]
		public bool runInEditMode
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x23D413C", Offset = "0x23D413C", VA = "0x23D413C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x23D4164", Offset = "0x23D4164", VA = "0x23D4164")]
			set
			{
			}
		}

		[Token(Token = "0x17000195")]
		internal bool isRunningInEditMode
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x23D4640", Offset = "0x23D4640", VA = "0x23D4640")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x23D27E8", Offset = "0x23D27E8", VA = "0x23D27E8")]
		internal void DontDestroyOnLoad()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x23D479C", Offset = "0x23D479C", VA = "0x23D479C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x23D4CC0", Offset = "0x23D4CC0", VA = "0x23D4CC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x23D4E2C", Offset = "0x23D4E2C", VA = "0x23D4E2C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x23D4E84", Offset = "0x23D4E84", VA = "0x23D4E84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x23D5178", Offset = "0x23D5178", VA = "0x23D5178")]
		private void OnApplicationFocus(bool isFocused)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x23D5200", Offset = "0x23D5200", VA = "0x23D5200")]
		private void Start()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x23D52D0", Offset = "0x23D52D0", VA = "0x23D52D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x23D5578", Offset = "0x23D5578", VA = "0x23D5578")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x23D5618", Offset = "0x23D5618", VA = "0x23D5618")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x23D5770", Offset = "0x23D5770", VA = "0x23D5770")]
		internal void OnGUIUpdate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x23D5370", Offset = "0x23D5370", VA = "0x23D5370")]
		internal void DoUpdate(UpdateLoopType updateLoopType, UpdateLoopSetting updateLoopSettingBit)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x23D4264", Offset = "0x23D4264", VA = "0x23D4264")]
		internal void TryStartRunInEditMode()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x23D4564", Offset = "0x23D4564", VA = "0x23D4564")]
		internal void TryStopRunInEditMode()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x23D4D9C", Offset = "0x23D4D9C", VA = "0x23D4D9C")]
		private bool LtkEsZTFSFJoixMshdtiDXKYDcds()
		{
			return default;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x23D480C", Offset = "0x23D480C", VA = "0x23D480C")]
		private void zQQfvDZMmpVqPPLYlLuSJXXpwJcI()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x23D5CB0", Offset = "0x23D5CB0", VA = "0x23D5CB0")]
		private object FkukJkUXfLyOaOSdbijqYylsACHh(ConfigVars P_0)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x23D5D80", Offset = "0x23D5D80", VA = "0x23D5D80")]
		private List<Assembly> FsrIzLggzQMIqapFPIIjWrjcfWRG()
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x23D6334", Offset = "0x23D6334", VA = "0x23D6334")]
		private List<Assembly> kONypgklnsoRVJkAdjjNDvHUUFdr()
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x23D66A0", Offset = "0x23D66A0", VA = "0x23D66A0")]
		private byte[] ZYazwninVCoqUAmnylbAjhkhihEU()
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x23D614C", Offset = "0x23D614C", VA = "0x23D614C")]
		private void ySxZymhJridYyTFswYqcTxJLEvhA(List<TextAsset> P_0, List<string> P_1)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x23D5AE0", Offset = "0x23D5AE0", VA = "0x23D5AE0")]
		private string UUfbDIIprGNfWbGLHDWoNmhGRrhtA()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x23D6840", Offset = "0x23D6840", VA = "0x23D6840")]
		private bool nmXHNbmHygAhLOJKLJnkPakEgxAI()
		{
			return default;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x23D5FAC", Offset = "0x23D5FAC", VA = "0x23D5FAC")]
		private string NgYbhRQsRrGlTGkdNZmUGtwnTqBTA()
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x23D5978", Offset = "0x23D5978", VA = "0x23D5978")]
		private bool qfucMoxItzABNVgftsaYcKIMmqKr()
		{
			return default;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x23D68BC", Offset = "0x23D68BC", VA = "0x23D68BC")]
		protected void RecompileStart()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x23D6920", Offset = "0x23D6920", VA = "0x23D6920")]
		protected void RecompileEnd()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x23D695C", Offset = "0x23D695C", VA = "0x23D695C")]
		protected void OnSceneLoaded()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x23D5040", Offset = "0x23D5040", VA = "0x23D5040")]
		private void yLvdWLXoeOUisLcdGZdTHlLChJky(wLUoCFKlqWfvuGYLfIRDzsOxLbwc P_0, string P_1, Exception P_2)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x23D6A24", Offset = "0x23D6A24", VA = "0x23D6A24")]
		internal void ResetAll()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x23D6AB0", Offset = "0x23D6AB0", VA = "0x23D6AB0")]
		internal EditorPlatform GetEditorPlatform()
		{
			return default;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x23D58D8", Offset = "0x23D58D8", VA = "0x23D58D8")]
		internal void GetSupportedEditModeControllerTypes(out bool keyboardSupported, out bool mouseSupported, out bool joystickSupported)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x23D5810", Offset = "0x23D5810", VA = "0x23D5810")]
		internal bool IsEditModeSupported()
		{
			return default;
		}

		[Token(Token = "0x600041B")]
		protected abstract void OnInitialized();

		[Token(Token = "0x600041C")]
		protected abstract void OnDeinitialized();

		[Token(Token = "0x600041D")]
		protected abstract void DetectPlatform();

		[Token(Token = "0x600041E")]
		protected abstract void CheckRecompile();

		[Token(Token = "0x600041F")]
		protected abstract IExternalTools GetExternalTools();

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x23D6AF8", Offset = "0x23D6AF8", VA = "0x23D6AF8")]
		protected InputManager_Base()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x23D6B70", Offset = "0x23D6B70", VA = "0x23D6B70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19522C", Offset = "0x19522C")]
		private bool ghVeosbvKHzPEjyrjugYGYpkSjGG(Assembly P_0)
		{
			return default;
		}
	}
}
