using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameInformationText : MonoBehaviour
{
	public List<TextMeshProLocalized> Texts;

	private Coroutine hideRoutine;

	public Camera UICamera;

	private void Awake()
	{
		ClearText();
	}

	public void ShowText(string textId, float duration, bool aboveTransition = false, params object[] arguments)
	{
		if (aboveTransition && UICamera != null)
			UICamera.depth = 21f;
		if (Texts != null)
		{
			foreach (TextMeshProLocalized t in Texts)
			{
				if (t != null)
					t.ChangeTextAfterTranslation(textId);
			}
		}
		if (hideRoutine != null)
			StopCoroutine(hideRoutine);
		if (gameObject.activeInHierarchy)
			hideRoutine = StartCoroutine(HideRoutine(duration));
	}

	private IEnumerator HideRoutine(float duration)
	{
		yield return new WaitForSecondsRealtime(duration);
		ClearText();
	}

	public void ClearText()
	{
		if (Texts != null)
		{
			foreach (TextMeshProLocalized t in Texts)
			{
				if (t != null)
					t.ClearText();
			}
		}
		if (UICamera != null && Mathf.Approximately(UICamera.depth, 21f))
			UICamera.depth = 10f;
	}
}
