using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	public sealed class FileSystem : BaseSystem
	{
		private static FileSystem s_Instance;

		public static SerializableLevelData[] s_LocalLevels;

		public static SerializableLevelData[] s_CloudLevels;

		public static SerializableLevelData s_TempLevel;

		private static Dictionary<Guid, SerializableLevelData> s_LocalLevelsMap;

		private static Dictionary<Guid, SerializableLevelData> s_CloudLevelsMap;

		public static SerializableLevelData[] LocalLevels => null;

		public static SerializableLevelData[] CloudLevels => null;

		[RuntimeInitializeOnLoadMethod]
		private static void InitOnLoad()
		{
		}

		public override void Init()
		{
		}

		public override void Update()
		{
		}

		public override void Dispose()
		{
		}

		public static SerializableLevelData GetLevel(Guid guid)
		{
			return null;
		}

		public static void SaveLevel(Guid levelId)
		{
		}

		public static SerializableLevelData GetLevelCopy(Guid levelId)
		{
			return null;
		}

		public static void LoadLevel(Guid levelId)
		{
		}

		public static void DeleteLevel(Guid levelId)
		{
		}

		public static IEnumerator PublishLevel(Guid levelId, Action<bool> result)
		{
			return null;
		}

		public static bool IsLevelSaved(Guid levelId)
		{
			return false;
		}

		public static void PopulateLocalLevels()
		{
		}

		public static void PopulateCloudLevels(string query, Action<bool> result)
		{
		}

		private static IEnumerator PopulateCloudLevelsProcess(string query, Action<bool> result)
		{
			return null;
		}
	}
}
