using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

namespace MusicGolf
{
	public class BeatObjectSequencer : MonoBehaviour
	{
		private class BeatEvent
		{
			public BeatEventType Type;

			public BeatObject BeatObject;
		}

		[SerializeField]
		private int totalBeats;

		[SerializeField]
		private double timePerBeat;

		[SerializeField]
		private uint musicState;

		[SerializeField]
		private uint musicStateOnLevelFail;

		private List<BeatEvent>[] eventsOnBeat;

		private HashSet<BeatObject> activeObjects;

		private void Level_OnFail(GolfBallController arg1, string arg2, Level.State arg3)
		{
		}

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}
	}
}
