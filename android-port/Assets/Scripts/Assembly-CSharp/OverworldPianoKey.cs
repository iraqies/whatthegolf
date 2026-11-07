using UnityEngine;

public class OverworldPianoKey : MonoBehaviour
{
	public AudioClip clip;

	public int note;

	private SpriteRenderer sprite;

	private Color downColor;

	private Color upColor;

	private float upTime;

	private float volume;

	public void Init(AudioClip clip, int midiNote, float volume)
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}
}
