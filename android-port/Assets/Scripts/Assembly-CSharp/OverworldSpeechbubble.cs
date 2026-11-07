using System.Collections;
using System.Collections.Generic;
using Audio;
using TMPro;
using UnityEngine;

public class OverworldSpeechbubble : MonoBehaviour
{
	public enum SpeechbubbleStateEnum
	{
		Inactive = 0,
		DisplayingText = 1,
		Idle = 2,
		Disabling = 3
	}

	public TextMeshPro Text;

	public Transform BubbleContainer;

	public Transform BubbleWithText;

	public float WaitTimeBetweenLetters;

	public float TimeBeforeDisappear;

	public float HitBlockTime;

	public float WaitTimeBetweenSounds;

	public RandomAudioClips speechClips;

	private SpeechbubbleStateEnum state;

	private int counter;

	private int visibleCount;

	private int totalVisibleCharacters;

	private float lastHitTime;

	private Coroutine ShowBubbleRoutine;

	private Coroutine PlaySoundRoutine;

	private List<Interlocutor> interlocutors;

	private Dictionary<SpeechbubbleList, IConversation> conversations;

	private IEnumerator ShowText(SpeechbubbleList textList)
	{
		return null;
	}

	private IEnumerator PlaySounds()
	{
		return null;
	}

	public void ShowSpeechbubble(SpeechbubbleList list, List<Interlocutor> interlocutors)
	{
	}

	private void OnDisable()
	{
	}
}
