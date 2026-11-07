using System;
using System.Collections;

namespace PersistentData
{
	public static class PersistentStoryDataStorage
	{
		public static bool LoadStory(int storyID, out PersistentStoryData data)
		{
			data = null;
			return false;
		}

		public static IEnumerator SaveStory(PersistentStoryData data, Action doneSavingCallBack = null)
		{
			return null;
		}
	}
}
