using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Prime31
{
	public class MonoBehaviourGUI : MonoBehaviour
	{
		protected float _width;

		protected float _buttonHeight;

		protected Dictionary<string, bool> _toggleButtons;

		protected Dictionary<string, bool> _toggleTriggers;

		protected StringBuilder _logBuilder;

		private bool _logRegistered;

		private Vector2 _logScrollPosition;

		private bool _isShowingLogConsole;

		private float _doubleClickDelay;

		private float _previousClickTime;

		private bool _isIphoneX;

		private Texture2D _normalBackground;

		private Texture2D _bottomButtonBackground;

		private Texture2D _activeBackground;

		private Texture2D _toggleButtonBackground;

		private bool _didRetinaIpadCheck;

		private bool _isRetinaIpad;

		private Texture2D normalBackground => null;

		private Texture2D bottomButtonBackground => null;

		private Texture2D activeBackground => null;

		private Texture2D toggleButtonBackground => null;

		private bool isRetinaOrLargeScreen()
		{
			return false;
		}

		private bool isRetinaIpad()
		{
			return false;
		}

		private int buttonHeight()
		{
			return 0;
		}

		private int buttonFontSize()
		{
			return 0;
		}

		private void checkForIphoneX()
		{
		}

		private int getNotchOffset()
		{
			return 0;
		}

		private void paintWindow(int id)
		{
		}

		private void handleLog(string logString, string stackTrace, LogType type)
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		private void addLogCallback()
		{
		}

		private void removeLogCallback()
		{
		}

		protected void prepGuiSkin()
		{
		}

		protected void beginColumn()
		{
		}

		protected void endColumn()
		{
		}

		protected void endColumn(bool hasSecondColumn)
		{
		}

		private void beginRightColumn()
		{
		}

		protected bool button(string text)
		{
			return false;
		}

		protected bool bottomRightButton(string text, float width = 150f)
		{
			return false;
		}

		protected bool bottomLeftButton(string text, float width = 150f)
		{
			return false;
		}

		protected bool bottomCenterButton(string text, float width = 150f)
		{
			return false;
		}

		protected bool toggleButton(string defaultText, string selectedText)
		{
			return false;
		}

		protected bool toggleButtonState(string defaultText)
		{
			return false;
		}

		protected void setTrigger(string trigger, bool state = true)
		{
		}

		protected bool checkTrigger(string trigger)
		{
			return false;
		}

		protected virtual void onLeftColumnGUI()
		{
		}

		protected virtual void onRightColumnGUI()
		{
		}

		public static void loadLevel(int level)
		{
		}

		public static void loadLevel(string level)
		{
		}

		public static void captureScreenshot(string filename)
		{
		}

		public static IEnumerator fetchScreenshot(string filename, float delay = 3f)
		{
			return null;
		}
	}
}
