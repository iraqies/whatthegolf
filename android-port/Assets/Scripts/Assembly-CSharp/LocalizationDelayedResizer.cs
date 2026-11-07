using System.Collections;
using UnityEngine;

public class LocalizationDelayedResizer : MonoBehaviour
{
	[SerializeField]
	private TextMeshProLocalized _text;

	[SerializeField]
	private RectTransform _rebuildTransform;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Resize()
	{
	}

	private IEnumerator ResizeCR()
	{
		return null;
	}
}
