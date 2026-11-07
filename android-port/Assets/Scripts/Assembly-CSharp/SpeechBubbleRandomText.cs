using System.Collections;
using UnityEngine;

public class SpeechBubbleRandomText : MonoBehaviour
{
	[SerializeField]
	private TextMeshProLocalized LocalizedText;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private string IdIndexOnSheet;

	public int numberOfQuotes;

	private int index;

	public void ShowNewRandomText()
	{
	}

	private IEnumerator HideAfter()
	{
		return null;
	}
}
