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

		private readonly List<char> punctutationCharacters;

		[SerializeField]
		private UnityEvent printCompleted;

		[SerializeField]
		private CharacterPrintedEvent characterPrinted;

		private Text textComponent;

		private string printingText;

		private string oldText;

		private float defaultPrintDelay;

		private Coroutine typeTextCoroutine;

		public UnityEvent PrintCompleted => null;

		public CharacterPrintedEvent CharacterPrinted => null;

		private Text TextComponent => null;

		public void TypeText(string text, float printDelay = -1f)
		{
		}

		public void Skip()
		{
		}

		public bool IsSkippable()
		{
			return false;
		}

		private void Cleanup()
		{
		}

		private IEnumerator TypeTextCharByChar(string text)
		{
			return null;
		}

		private float GetPrintDelayForCharacter(char characterToPrint)
		{
			return 0f;
		}

		private void OnCharacterPrinted(string printedCharacter)
		{
		}

		private void OnTypewritingComplete()
		{
		}
	}
}
