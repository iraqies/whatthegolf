using UnityEngine;

public class Brick : MonoBehaviour
{
	public AudioClip sfxBreak;

	private Collider2D col;

	private bool isSolid = true;

	private void Start()
	{
		col = GetComponent<Collider2D>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (!isSolid)
			return;
		isSolid = false;
		if (col != null)
			col.isTrigger = true;
		Vector3 startScale = transform.localScale;
		StartCoroutine(pTween.To(0.2f, t =>
		{
			transform.localScale = Vector3.Lerp(startScale, Vector3.zero, Mathf.Clamp01(t));
		}));
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && sfxBreak != null)
		{
			AudioManager.Instance.sfx.Play(sfxBreak, s =>
			{
				if (s != null)
				{
					s.pitch = Random.Range(1.25f, 1.3f);
					s.volume = 0.7f;
				}
			}, 0f, false);
		}
	}
}
