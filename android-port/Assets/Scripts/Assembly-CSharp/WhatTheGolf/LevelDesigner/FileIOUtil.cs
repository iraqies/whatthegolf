namespace WhatTheGolf.LevelDesigner
{
	public static class FileIOUtil
	{
		private static readonly string s_LocalDirectory;

		public static SerializableLevelData[] GetAllLocalLevels()
		{
			return null;
		}

		public static void SaveLevelLocal(SerializableLevelData serializableLevelData, bool isClone)
		{
		}

		public static void DeleteLevelLocal(SerializableLevelData serializableLevelData)
		{
		}

		public static LevelData Deserialize(this SerializableLevelData serializableLevelData, ElementDatabase elementDatabase)
		{
			return null;
		}

		public static string Serialize(this LevelContentData levelContentData)
		{
			return null;
		}

		public static LevelContentData DeserializeLevelContentData(string json, ElementDatabase elementDatabase)
		{
			return null;
		}
	}
}
