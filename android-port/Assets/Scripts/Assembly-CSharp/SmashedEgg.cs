using UnityEngine;

public class SmashedEgg : MonoBehaviour
{
	[SerializeField]
	private float minScale = 0.1f;

	[SerializeField]
	private float maxScale = 1f;

	[SerializeField]
	private float scaleUpDuration = 0.3f;

	private void Awake()
	{
		base.transform.localScale = Vector3.one * minScale;
	}

	private void Start()
	{
		StartCoroutine(pTween.To(scaleUpDuration, delegate(float t)
		{
			base.transform.localScale = Vector3.one * Mathf.Lerp(minScale, maxScale, t);
		}));
	}

	public void SetMaxScale(float value)
	{
		maxScale = value;
	}
}
