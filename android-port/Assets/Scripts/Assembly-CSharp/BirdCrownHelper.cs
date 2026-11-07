using UnityEngine;

public class BirdCrownHelper : MonoBehaviour
{
	public SpeechbubbleList speechOnMissing;

	public SpeechbubbleList speechOnDone;

	public SpeechbubbleList speechIsOpen;

	public OverworldButton2D crowndoor;

	public ShowSpeechbubbleOnHit speechbubble;

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private string ProcessSpeechText(string input)
	{
		return null;
	}
}
