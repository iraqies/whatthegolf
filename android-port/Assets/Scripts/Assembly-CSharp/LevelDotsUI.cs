using UnityEngine;

public class LevelDotsUI : MonoBehaviour
{
	public int currentDotIndex;

	public Color inactiveColor = Color.gray;

	public Color activeColor = Color.white;

	public float blinkFrequency = 2f;

	public float width = 30f;

	public LevelDot levelDotTemplate;

	private LevelDot[] dots;

	public void Initialize(int dotCount)
	{
		if (dots != null)
		{
			for (int i = 0; i < dots.Length; i++)
				if (dots[i] != null && dots[i] != levelDotTemplate)
					Destroy(dots[i].gameObject);
		}
		if (dotCount <= 1 || levelDotTemplate == null)
		{
			if (levelDotTemplate != null)
				levelDotTemplate.gameObject.SetActive(false);
			dots = null;
			return;
		}
		levelDotTemplate.gameObject.SetActive(false);
		dots = new LevelDot[dotCount];
		float totalW = (dotCount - 1) * (width > 1f ? width : 30f);
		for (int i = 0; i < dotCount; i++)
		{
			var d = Instantiate(levelDotTemplate, transform, false);
			d.gameObject.SetActive(true);
			d.transform.localPosition = new Vector3(-totalW * 0.5f + i * (width > 1f ? width : 30f), 0f, 0f);
			dots[i] = d;
		}
	}

	private void Update()
	{
		if (dots == null) return;
		for (int i = 0; i < dots.Length; i++)
		{
			if (dots[i] == null || dots[i].InnerDotRenderer == null) continue;
			if (i < currentDotIndex)
				dots[i].InnerDotRenderer.color = activeColor;
			else if (i == currentDotIndex)
				dots[i].InnerDotRenderer.color = Color.Lerp(inactiveColor, activeColor, (Mathf.Sin(Time.unscaledTime * Mathf.Max(1f, blinkFrequency) * Mathf.PI) + 1f) * 0.5f);
			else
				dots[i].InnerDotRenderer.color = inactiveColor;
		}
	}
}
