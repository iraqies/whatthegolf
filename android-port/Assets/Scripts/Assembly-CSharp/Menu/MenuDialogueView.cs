using System.Threading.Tasks;
using UnityEngine;

namespace Menu
{
	public class MenuDialogueView : ShowSpeechBubble
	{
		[SerializeField]
		private MenuDialogueConfig config;

		[SerializeField]
		private Transform bubblePosition;

		[SerializeField]
		private ShowSpeechbubbleOnHit showSpeechbubbleOnHit;

		[SerializeField]
		private GameObject exclamation;

		[SerializeField]
		private GameObject bonusArrowHighlight;

		[SerializeField]
		private GameObject episodesArrowHighlight;

		[SerializeField]
		private Transform turtleTransform;

		private bool shouldAutoShowSpeechBubble;

		private MenuDialogueConfig.Entry welcomeEntry;

		private void OnEnable()
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void OnTriggerExit2D(Collider2D other)
		{
		}

		private void RemoveAutoSpeechBubble()
		{
		}

		private Task AutoShowSpeechBubble()
		{
			return null;
		}

		private void WaitForHit(MenuDialogueConfig.Entry entry)
		{
		}

		private void ShowEffects(MenuDialogueConfig.EffectType effectType)
		{
		}
	}
}
