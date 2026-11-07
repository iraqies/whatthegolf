using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Prime31
{
	[Token(Token = "0x2000005")]
	public class MonoBehaviourGUI : MonoBehaviour
	{
		[Token(Token = "0x2000006")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1904F8", Offset = "0x1904F8")]
		private sealed class _003CfetchScreenshot_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x20")]
			public string filename;

			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x28")]
			public float delay;

			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x30")]
			private Texture2D _003CscreenImage_003E5__1;

			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x38")]
			private byte[] _003CimageBytes_003E5__2;

			[Token(Token = "0x17000005")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600002F")]
				[Address(RVA = "0x2348318", Offset = "0x2348318", VA = "0x2348318", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000006")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000031")]
				[Address(RVA = "0x2348360", Offset = "0x2348360", VA = "0x2348360", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600002C")]
			[Address(RVA = "0x233F824", Offset = "0x233F824", VA = "0x233F824")]
			[DebuggerHidden]
			public _003CfetchScreenshot_003Ed__56(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x23480E4", Offset = "0x23480E4", VA = "0x23480E4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x23480E8", Offset = "0x23480E8", VA = "0x23480E8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2348318", Offset = "0x2348318", VA = "0x2348318", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2348320", Offset = "0x2348320", VA = "0x2348320", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2348360", Offset = "0x2348360", VA = "0x2348360", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		protected float _width;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x1C")]
		protected float _buttonHeight;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, bool> _toggleButtons;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, bool> _toggleTriggers;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x30")]
		protected StringBuilder _logBuilder;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x38")]
		private bool _logRegistered;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 _logScrollPosition;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x44")]
		private bool _isShowingLogConsole;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x48")]
		private float _doubleClickDelay;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x4C")]
		private float _previousClickTime;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x50")]
		private bool _isIphoneX;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x58")]
		private Texture2D _normalBackground;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x60")]
		private Texture2D _bottomButtonBackground;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x68")]
		private Texture2D _activeBackground;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x70")]
		private Texture2D _toggleButtonBackground;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x78")]
		private bool _didRetinaIpadCheck;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x79")]
		private bool _isRetinaIpad;

		[Token(Token = "0x17000001")]
		private Texture2D normalBackground
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x233D59C", Offset = "0x233D59C", VA = "0x233D59C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private Texture2D bottomButtonBackground
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x233D688", Offset = "0x233D688", VA = "0x233D688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private Texture2D activeBackground
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x233D7D4", Offset = "0x233D7D4", VA = "0x233D7D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private Texture2D toggleButtonBackground
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x233D8C0", Offset = "0x233D8C0", VA = "0x233D8C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x233D9AC", Offset = "0x233D9AC", VA = "0x233D9AC")]
		private bool isRetinaOrLargeScreen()
		{
			return default;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x233D9E8", Offset = "0x233D9E8", VA = "0x233D9E8")]
		private bool isRetinaIpad()
		{
			return default;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x233DA40", Offset = "0x233DA40", VA = "0x233DA40")]
		private int buttonHeight()
		{
			return default;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x233DAD0", Offset = "0x233DAD0", VA = "0x233DAD0")]
		private int buttonFontSize()
		{
			return default;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x233DB60", Offset = "0x233DB60", VA = "0x233DB60")]
		private void checkForIphoneX()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x233DC44", Offset = "0x233DC44", VA = "0x233DC44")]
		private int getNotchOffset()
		{
			return default;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x233DC98", Offset = "0x233DC98", VA = "0x233DC98")]
		private void paintWindow(int id)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x233DE98", Offset = "0x233DE98", VA = "0x233DE98")]
		private void handleLog(string logString, string stackTrace, LogType type)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x233DF00", Offset = "0x233DF00", VA = "0x233DF00")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x233E008", Offset = "0x233E008", VA = "0x233E008")]
		private void Update()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x233E170", Offset = "0x233E170", VA = "0x233E170")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x233E0EC", Offset = "0x233E0EC", VA = "0x233E0EC")]
		private void addLogCallback()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x233DF84", Offset = "0x233DF84", VA = "0x233DF84")]
		private void removeLogCallback()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x233E480", Offset = "0x233E480", VA = "0x233E480")]
		protected void prepGuiSkin()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x233E8C0", Offset = "0x233E8C0", VA = "0x233E8C0")]
		protected void beginColumn()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x233EA10", Offset = "0x233EA10", VA = "0x233EA10")]
		protected void endColumn()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x233EA18", Offset = "0x233EA18", VA = "0x233EA18")]
		protected void endColumn(bool hasSecondColumn)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x233EBAC", Offset = "0x233EBAC", VA = "0x233EBAC")]
		private void beginRightColumn()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x233ED2C", Offset = "0x233ED2C", VA = "0x233ED2C")]
		protected bool button(string text)
		{
			return default;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x233ED90", Offset = "0x233ED90", VA = "0x233ED90")]
		protected bool bottomRightButton(string text, float width = 150f)
		{
			return default;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x233EF08", Offset = "0x233EF08", VA = "0x233EF08")]
		protected bool bottomLeftButton(string text, float width = 150f)
		{
			return default;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x233F06C", Offset = "0x233F06C", VA = "0x233F06C")]
		protected bool bottomCenterButton(string text, float width = 150f)
		{
			return default;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x233F1D4", Offset = "0x233F1D4", VA = "0x233F1D4")]
		protected bool toggleButton(string defaultText, string selectedText)
		{
			return default;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x233F4D0", Offset = "0x233F4D0", VA = "0x233F4D0")]
		protected bool toggleButtonState(string defaultText)
		{
			return default;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x233F58C", Offset = "0x233F58C", VA = "0x233F58C")]
		protected void setTrigger(string trigger, bool state = true)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x233F5F8", Offset = "0x233F5F8", VA = "0x233F5F8")]
		protected bool checkTrigger(string trigger)
		{
			return default;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x233F698", Offset = "0x233F698", VA = "0x233F698", Slot = "4")]
		protected virtual void onLeftColumnGUI()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x233F69C", Offset = "0x233F69C", VA = "0x233F69C", Slot = "5")]
		protected virtual void onRightColumnGUI()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x233F6A0", Offset = "0x233F6A0", VA = "0x233F6A0")]
		public static void loadLevel(int level)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x233F71C", Offset = "0x233F71C", VA = "0x233F71C")]
		public static void loadLevel(string level)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x233F798", Offset = "0x233F798", VA = "0x233F798")]
		public static void captureScreenshot(string filename)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x233F7A0", Offset = "0x233F7A0", VA = "0x233F7A0")]
		public static IEnumerator fetchScreenshot(string filename, float delay = 3f)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x233F850", Offset = "0x233F850", VA = "0x233F850")]
		public MonoBehaviourGUI()
		{
		}
	}
}
