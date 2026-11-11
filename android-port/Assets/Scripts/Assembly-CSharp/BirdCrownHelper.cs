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
		speechbubble.isAbleToTalk = false;
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if ((other.rigidbody != null && other.rigidbody.GetComponent<Confetti>() != null) || other.collider.attachedRigidbody.gameObject != OverworldBallManager.Instance.Ball.gameObject)
		{
			return;
		}
		other.rigidbody.velocity *= 0.6f;
		if (crowndoor.openOrOpening)
		{
			speechbubble.TextList = speechIsOpen;
		}
		else if (crowndoor.GetFlagsLeft() >= 1)
		{
			speechbubble.TextList = speechOnMissing;
		}
		else if (crowndoor.GetFlagsLeft() <= 0)
		{
			speechbubble.TextList = speechOnDone;
		}
		StartCoroutine(speechbubble.HandleHit(null, null, ProcessSpeechText));
	}

	private string ProcessSpeechText(string input)
	{
		if (input.Contains("{0}"))
		{
			input = input.Replace("{0}", crowndoor.GetFlagsLeft().ToString());
		}
		return input;
	}
}
