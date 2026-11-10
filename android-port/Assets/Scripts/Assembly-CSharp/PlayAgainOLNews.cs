using UnityEngine;

public class PlayAgainOLNews : MonoBehaviour
{
	[SerializeField]
	private RectTransform container;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private float scrollSpeed = 20f;

	public Vector3 originalPos;

	public float startX;

	public float endX;

	public float enabledTime;

	public float t;

	private bool initialized;

	public float randomOffset;

	private void Initialize()
	{
		if (content != null)
			originalPos = content.localPosition;
		CalculateScrollRange();
		initialized = true;
	}

	private void CalculateScrollRange()
	{
		if (container == null || content == null)
			return;
		float containerWidth = container.rect.width;
		float contentWidth = content.rect.width;
		startX = originalPos.x + containerWidth * 0.5f + contentWidth * 0.5f;
		endX = originalPos.x - (containerWidth * 0.5f + contentWidth * 0.5f);
	}

	private void OnEnable()
	{
		randomOffset = Random.Range(0f, 30f);
		if (!initialized)
			Initialize();
	}

	private void Update()
	{
		enabledTime += Time.unscaledDeltaTime;
		CalculateScrollPosition();
	}

	private void CalculateScrollPosition()
	{
		if (content == null)
			return;
		CalculateScrollRange();
		float range = Mathf.Abs(startX - endX);
		if (range > 0.001f)
		{
			t = ((enabledTime + randomOffset) * scrollSpeed / range) % 1f;
			Vector3 pos = content.localPosition;
			pos.x = Mathf.Lerp(startX, endX, t);
			content.localPosition = pos;
		}
	}
}
