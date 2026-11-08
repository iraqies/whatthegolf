using System;
using System.Collections.Generic;
using Malee;
using UnityEngine;

[Serializable]
public class SpeechbubbleList : ScriptableObject
{
	[Serializable]
	public class SpeechbubbleTextInfo
	{
		public string ID;

		public int SpeakerIndex;

		public bool isLocalized;

		public bool DontPlayTalkAnimation;
	}

	[Serializable]
	public class TextIdReorderableList : ReorderableArray<SpeechbubbleTextInfo>
	{
	}

	private class Conversation : IConversation
	{
		private int nextTextIndex;

		private List<SpeechbubbleTextInfo> textsLeft;

		private bool initialized;

		private SpeechbubbleList list;

		public Conversation(SpeechbubbleList list)
		{
			this.list = list;
		}

		public SpeechbubbleTextInfo GetText()
		{
			if (list == null || list.textIds == null || list.textIds.Count == 0)
				return null;

			if (!initialized)
			{
				initialized = true;
				textsLeft = new List<SpeechbubbleTextInfo>(list.textIds);
			}

			if (textsLeft == null || textsLeft.Count == 0)
			{
				if (list.loopList)
				{
					textsLeft = new List<SpeechbubbleTextInfo>(list.textIds);
					nextTextIndex = 0;
				}
				else
				{
					return null;
				}
			}

			if (textsLeft.Count == 0)
				return null;

			int index = 0;
			if (list.randomSelection)
			{
				index = UnityEngine.Random.Range(0, textsLeft.Count);
			}
			else
			{
				index = Mathf.Clamp(nextTextIndex, 0, textsLeft.Count - 1);
				if (!list.discardSelectedIds)
					nextTextIndex = list.loopList ? ((nextTextIndex + 1) % textsLeft.Count) : (nextTextIndex + 1);
			}

			if (index >= textsLeft.Count)
				return null;

			var item = textsLeft[index];
			if (list.discardSelectedIds || !list.loopList)
				textsLeft.RemoveAt(index);

			return item;
		}
	}

	public TextIdReorderableList textIds;

	[SerializeField]
	private bool randomSelection;

	[SerializeField]
	private bool discardSelectedIds;

	[SerializeField]
	private bool loopList;

	[SerializeField]
	public string translation;

	public bool HasRandomSelection() => randomSelection;

	public bool IsLooping() => loopList;

	public IConversation NewConversation() => new Conversation(this);
}
