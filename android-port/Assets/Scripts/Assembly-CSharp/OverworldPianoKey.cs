using Audio;
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
		this.volume = volume;
		this.clip = clip;
		this.note = midiNote;
		sprite = GetComponentInChildren<SpriteRenderer>();
		if (sprite != null)
		{
			upColor = sprite.color;
			downColor = sprite.color * 0.8f + Color.white * 0.2f;
		}
	}

	private void Update()
	{
		if (sprite != null && Time.time > upTime && sprite.color == downColor)
		{
			sprite.color = upColor;
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision != null && collision.CompareTag("Player"))
		{
			float pitch = MusicMathUtils.MidiNoteToPitch(note + 60, 60);
			if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && clip != null)
			{
				AudioManager.Instance.sfx.Play(clip, src =>
				{
					if (src != null)
					{
						src.pitch = pitch;
						src.volume = volume;
					}
				}, 0f, false);
			}
			if (sprite != null)
			{
				sprite.color = downColor;
			}
			upTime = Time.time + 0.1f;
		}
	}
}
