using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GifDetailPanel : MonoBehaviour
{
	[SerializeField]
	private Button shareButton;

	[SerializeField]
	private TextMeshProUGUI shareButtonText;

	[SerializeField]
	private GifPreviewUI preview;

	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private TMP_Text exportText;

	private GifMoment moment;

	private StandaloneGifExporter standaloneGifExporter;

	[SerializeField]
	private GameObject progressPanel;

	[SerializeField]
	private Image progressFill;

	private void Awake()
	{
	}

	private void Share()
	{
	}

	private void OnPercentSavedChanged(float percent)
	{
	}

	private void OnSaveCompleted(bool success, string path)
	{
	}

	public void Show(GifMoment moment)
	{
	}

	public void Hide()
	{
	}
}
