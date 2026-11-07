using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GifPreviewUI : MonoBehaviour
{
	[SerializeField]
	private RawImage image;

	[SerializeField]
	private Button button;

	[SerializeField]
	private TMP_Text text;

	[SerializeField]
	private bool aspectFill;

	private GifMoment moment;

	private Coroutine playCR;

	private bool firstUse;

	private Vector2 originalSize;

	public GameObject LockedObject;

	public GameObject ImageThumbnailObject;

	public Button.ButtonClickedEvent onClick => null;

	public void SetMoment(GifMoment data, bool playGif)
	{
	}

	public IEnumerator PlayImagesCR(float fps)
	{
		return null;
	}
}
