using System;
using UnityEngine;

namespace Core
{
	[Serializable]
	public class MainMenuData : ScriptableObject
	{
		public bool canShowOfflineWarning;

		public bool showItemExit;

		public bool showItemSocial;

		public bool showMouse;

		public bool showTouch;

		public bool showSiriRemote;

		public bool showController;

		public bool useSettingLanguage;

		public bool useSettingMusic;

		public bool useSettingSFX;

		public bool useSettingResolution;

		public bool useSettingFullscreen;

		public bool userSettingAA;

		public bool useSettingSsaveSlot;

		public bool useSettingSwitchGyroOn;

		public bool useSettingsReconfigureControls;
	}
}
