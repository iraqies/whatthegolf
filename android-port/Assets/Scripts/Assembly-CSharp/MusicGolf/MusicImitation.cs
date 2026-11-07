using System;
using System.Collections;
using Audio;
using UnityEngine;

namespace MusicGolf
{
	public class MusicImitation : MonoBehaviour
	{
		[Serializable]
		public class ImitationSequence
		{
			public ImitationBlock[] blocks;

			public GameObject door;

			public StingerData wwiseTrigger;

			public Animator animator;

			public string animatorTriggerName;
		}

		[SerializeField]
		private float interval;

		[SerializeField]
		private AudioClipSettings RewardSound;

		[SerializeField]
		private AudioClipSettings FailClip;

		[SerializeField]
		private ImitationBlock[] allBlocks;

		[SerializeField]
		private ImitationSequence[] sequences;

		[SerializeField]
		private StingerData lastAnswerStinger;

		private MusicManager music;

		private AudioSources voice;

		private int sequenceIndex;

		private int blockIndex;

		private IEnumerator Start()
		{
			return null;
		}
	}
}
