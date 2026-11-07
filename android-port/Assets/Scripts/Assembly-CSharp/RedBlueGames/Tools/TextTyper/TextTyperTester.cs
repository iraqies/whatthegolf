using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedBlueGames.Tools.TextTyper
{
	public class TextTyperTester : MonoBehaviour
	{
		[SerializeField]
		private AudioClip printSoundEffect;

		[SerializeField]
		private Button printNextButton;

		[SerializeField]
		private Button printNoSkipButton;

		private Queue<string> dialogueLines;

		[SerializeField]
		private TextTyper testTextTyper;

		public void Start()
		{
		}

		public void Update()
		{
		}

		private void HandlePrintNextClicked()
		{
		}

		private void HandlePrintNoSkipClicked()
		{
		}

		private void ShowScript()
		{
		}

		private void LogTag(RichTextTag tag)
		{
		}

		private void HandleCharacterPrinted(string printedCharacter)
		{
		}

		private void HandlePrintCompleted()
		{
		}
	}
}
