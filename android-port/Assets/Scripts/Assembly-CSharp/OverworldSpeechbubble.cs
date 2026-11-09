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
	public float WaitTimeBetweenLetters = 0.03f;
	public float TimeBeforeDisappear = 2.5f;
	public float HitBlockTime = 0.5f;
	public float WaitTimeBetweenSounds = 0.1f;
	public RandomAudioClips speechClips;

	private SpeechbubbleStateEnum state;
	private int counter;
	private int visibleCount;
	private int totalVisibleCharacters;
	private float lastHitTime;
	private Coroutine ShowBubbleRoutine;
	private Coroutine PlaySoundRoutine;
	private List<Interlocutor> interlocutors;
	private Dictionary<SpeechbubbleList, IConversation> conversations = new Dictionary<SpeechbubbleList, IConversation>();

	private IEnumerator ShowText(SpeechbubbleList textList)
	{
		if (textList == null || Text == null)
			yield break;
		state = SpeechbubbleStateEnum.DisplayingText;
		if (conversations == null)
			conversations = new Dictionary<SpeechbubbleList, IConversation>();
		if (!conversations.TryGetValue(textList, out var conv) || conv == null)
		{
			conv = textList.NewConversation();
			conversations[textList] = conv;
		}
		var info = conv != null ? conv.GetText() : null;
		if (info == null || string.IsNullOrEmpty(info.ID))
			yield break;

		string display = info.isLocalized
			? info.ID
			: (Localization.Instance != null ? Localization.Instance.GetString(info.ID) : info.ID);
		if (string.IsNullOrEmpty(display))
			display = info.ID;

		if (BubbleContainer != null)
			BubbleContainer.gameObject.SetActive(true);
		Text.text = display;
		Text.ForceMeshUpdate();
		totalVisibleCharacters = Text.textInfo != null ? Text.textInfo.characterCount : display.Length;
		Text.maxVisibleCharacters = 0;

		if (PlaySoundRoutine != null)
			StopCoroutine(PlaySoundRoutine);
		PlaySoundRoutine = StartCoroutine(PlaySounds());

		for (visibleCount = 0; visibleCount <= totalVisibleCharacters; visibleCount++)
		{
			Text.maxVisibleCharacters = visibleCount;
			yield return new WaitForSeconds(Mathf.Max(0.01f, WaitTimeBetweenLetters));
		}

		if (PlaySoundRoutine != null)
		{
			StopCoroutine(PlaySoundRoutine);
			PlaySoundRoutine = null;
		}

		state = SpeechbubbleStateEnum.Idle;
		yield return new WaitForSeconds(Mathf.Max(0.5f, TimeBeforeDisappear));
		state = SpeechbubbleStateEnum.Disabling;
		if (BubbleContainer != null)
			BubbleContainer.gameObject.SetActive(false);
		state = SpeechbubbleStateEnum.Inactive;
	}

	private IEnumerator PlaySounds()
	{
		while (state == SpeechbubbleStateEnum.DisplayingText)
		{
			if (speechClips != null)
				speechClips.PlayRandomClip(transform, 1f, 1f);
			yield return new WaitForSeconds(Mathf.Max(0.05f, WaitTimeBetweenSounds));
		}
	}

	public void ShowSpeechbubble(SpeechbubbleList list, List<Interlocutor> interlocutors)
	{
		if (Time.time < lastHitTime + HitBlockTime)
			return;
		lastHitTime = Time.time;
		this.interlocutors = interlocutors;
		if (ShowBubbleRoutine != null)
			StopCoroutine(ShowBubbleRoutine);
		ShowBubbleRoutine = StartCoroutine(ShowText(list));
	}

	private void OnDisable()
	{
		state = SpeechbubbleStateEnum.Inactive;
		if (BubbleContainer != null)
			BubbleContainer.gameObject.SetActive(false);
	}
}
