using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	[CreateAssetMenu(fileName = "WTGPortCatalog", menuName = "WhatTheGolf/PortCatalog")]
	public class WTGPortCatalog : ScriptableObject
	{
		[Serializable]
		public class EpisodeEntry
		{
			public string packId;
			public string title;
			public string overworldScene;
			public ContentPack pack;
			public List<LevelData> levels = new List<LevelData>();
		}

		public RuntimeStoreData storeData;
		public PlatformSettings platformSettings;
		public ShootArrow defaultShootArrow;
		public List<EpisodeEntry> episodes = new List<EpisodeEntry>();
		public List<LevelData> allLevels = new List<LevelData>();
		public List<string> allSceneNames = new List<string>();

		private static WTGPortCatalog _instance;
		public static WTGPortCatalog Instance
		{
			get
			{
				if (_instance == null)
					_instance = Resources.Load<WTGPortCatalog>("WTGPortCatalog");
				return _instance;
			}
		}
	}
}
