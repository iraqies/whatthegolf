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
		}

		public SpeechbubbleTextInfo GetText()
		{
			return null;
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

	public bool HasRandomSelection()
	{
		return false;
	}

	public bool IsLooping()
	{
		return false;
	}

	public IConversation NewConversation()
	{
		return null;
	}
}
