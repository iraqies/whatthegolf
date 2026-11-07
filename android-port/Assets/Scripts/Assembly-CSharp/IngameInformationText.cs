using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameInformationText : MonoBehaviour
{
	public List<TextMeshProLocalized> Texts;

	private Coroutine hideRoutine;

	public Camera UICamera;

	public void ShowText(string textId, float duration, bool aboveTransition = false, params object[] arguments)
	{
	}

	private IEnumerator HideRoutine(float duration)
	{
		return null;
	}

	public void ClearText()
	{
	}
}
