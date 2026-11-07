using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TurtleDialogHelper : MonoBehaviour
{
	public SpeechbubbleList ReplaceOnEnd;

	public UnityEvent AfterEndSpeech;

	public float EndDelay;

	private bool isEnd;

	public void SwapSpeechBubble()
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private IEnumerator DoEvent()
	{
		return null;
	}
}
