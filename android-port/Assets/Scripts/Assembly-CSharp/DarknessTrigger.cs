using UnityEngine;

public class DarknessTrigger : MonoBehaviour
{
	public SpriteRenderer[] DarknessRenderers;

	public Color DarknessDark;

	public Color DarknessLight;

	private float fadeSpeed = 0.5f;

	private float darkness;

	private float targetDarkness;

	private void Awake()
	{
		UpdateRenderers();
	}

	private void ToggleDarkness(bool on)
	{
		targetDarkness = on ? 1f : 0f;
	}

	private void Update()
	{
		if (darkness == targetDarkness)
			return;

		if (darkness == 0f && targetDarkness == 1f)
		{
			EnableRenderers(true);
		}

		darkness = Mathf.MoveTowards(darkness, targetDarkness, fadeSpeed * Time.deltaTime);
		UpdateRenderers();

		if (darkness == 0f && targetDarkness == 0f)
		{
			EnableRenderers(false);
		}
	}

	private Color DarknessToColor(float darkness)
	{
		float t = Mathf.Pow(Mathf.SmoothStep(0f, 1f, darkness), 1.2f);
		return Color.Lerp(DarknessLight, DarknessDark, t);
	}

	private void UpdateRenderers()
	{
		if (DarknessRenderers == null)
			return;
		Color c = DarknessToColor(darkness);
		for (int i = 0; i < DarknessRenderers.Length; i++)
		{
			if (DarknessRenderers[i] != null && DarknessRenderers[i].material != null)
			{
				DarknessRenderers[i].material.color = c;
			}
		}
	}

	private void EnableRenderers(bool enabled)
	{
		if (DarknessRenderers == null)
			return;
		for (int i = 0; i < DarknessRenderers.Length; i++)
		{
			if (DarknessRenderers[i] != null)
			{
				DarknessRenderers[i].enabled = enabled;
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision != null && collision.tag == "Player")
		{
			targetDarkness = 1f;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision != null && collision.tag == "Player")
		{
			targetDarkness = 0f;
		}
	}
}
