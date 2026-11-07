using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
	[SerializeField]
	private TextMeshProLocalized localization;

	[SerializeField]
	private string format;

	private TMP_Text _text;

	private TMP_Text Text => null;

	private void Update()
	{
	}
}
