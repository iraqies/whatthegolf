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

	public int numberOfQuotes = 1;

	private int index;

	public void ShowNewRandomText()
	{
		if (LocalizedText != null)
		{
			LocalizedText.ChangeText((IdIndexOnSheet ?? string.Empty) + index);
		}
		if (numberOfQuotes > 0)
			index = (index + 1) % numberOfQuotes;
		StopAllCoroutines();
		if (animator != null)
			animator.SetTrigger("Show");
		StartCoroutine(HideAfter());
	}

	private IEnumerator HideAfter()
	{
		yield return new WaitForSeconds(3f);
		if (animator != null)
			animator.SetTrigger("Hide");
	}
}
