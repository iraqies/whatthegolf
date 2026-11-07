using Ghost;
using UnityEngine;

namespace PersistentData
{
	public class PersistentDataManager : MonoBehaviour
	{
		private PersistentStoryData _currentData;

		private GhostManager ghostManager;

		public PersistentStoryData CurrentData
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnStoryStart()
		{
		}

		private void OnStoryOver(int strokes)
		{
		}

		private void SaveDone()
		{
		}
	}
}
