using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace RedBlueGames.Tools.TextTyper
{
	public sealed class TextTyper : MonoBehaviour
	{
		[Serializable]
		public class CharacterPrintedEvent : UnityEvent<string>
		{
		}

		private const float PrintDelaySetting = 0.02f;

		private readonly List<char> punctutationCharacters = new List<char> { '.', ',', '!', '?' };

		[SerializeField]
		private UnityEvent printCompleted = new UnityEvent();

		[SerializeField]
		private CharacterPrintedEvent characterPrinted = new CharacterPrintedEvent();

		private Text textComponent;

		private string printingText;

		private string oldText;

		private float defaultPrintDelay;

		private Coroutine typeTextCoroutine;

		public UnityEvent PrintCompleted => printCompleted;

		public CharacterPrintedEvent CharacterPrinted => characterPrinted;

		private Text TextComponent
		{
			get
			{
				if (textComponent == null)
				{
					textComponent = GetComponent<Text>();
				}
				return textComponent;
			}
		}

		public void TypeText(string text, float printDelay = -1f)
		{
			Cleanup();
			defaultPrintDelay = ((printDelay > 0f) ? printDelay : 0.02f);
			if (TextComponent != null)
			{
				oldText = TextComponent.text;
			}
			typeTextCoroutine = StartCoroutine(TypeTextCharByChar(text));
		}

		public void Skip()
		{
			Cleanup();
			if (TextComponent != null)
			{
				TextComponent.text = oldText + printingText;
			}
			OnTypewritingComplete();
		}

		public bool IsSkippable()
		{
			return typeTextCoroutine != null;
		}

		private void Cleanup()
		{
			if (typeTextCoroutine != null)
			{
				StopCoroutine(typeTextCoroutine);
				typeTextCoroutine = null;
			}
		}

		private IEnumerator TypeTextCharByChar(string text)
		{
			printingText = text ?? string.Empty;
			for (int i = 0; i < printingText.Length; i++)
			{
				if (TextComponent != null)
				{
					TextComponent.text = oldText + printingText.Substring(0, i + 1);
				}
				char c = printingText[i];
				OnCharacterPrinted(c.ToString());
				float delay = GetPrintDelayForCharacter(c);
				if (delay > 0f)
				{
					yield return new WaitForSeconds(delay);
				}
			}
			typeTextCoroutine = null;
			OnTypewritingComplete();
		}

		private float GetPrintDelayForCharacter(char characterToPrint)
		{
			if (punctutationCharacters != null && punctutationCharacters.Contains(characterToPrint))
			{
				return defaultPrintDelay * 4f;
			}
			return defaultPrintDelay;
		}

		private void OnCharacterPrinted(string printedCharacter)
		{
			characterPrinted?.Invoke(printedCharacter);
		}

		private void OnTypewritingComplete()
		{
			printCompleted?.Invoke();
		}
	}
}
