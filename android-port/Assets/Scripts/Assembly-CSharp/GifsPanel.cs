using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GifsPanel : MonoBehaviour
{
	[SerializeField]
	private GifPreviewUI previewPrefab;

	[SerializeField]
	private RectTransform itemsContainer;

	[SerializeField]
	private GifDetailPanel detailPanel;

	[SerializeField]
	private RectTransform containerTransform;

	[SerializeField]
	private Button closeButton;

	private GifMomentManager manager;

	private float prevTimescale;

	private void Awake()
	{
	}

	private void DestroyItems()
	{
	}

	public IEnumerator Show()
	{
		return null;
	}

	private IEnumerator ShowGifMenu()
	{
		return null;
	}

	private IEnumerator HideGifMenu()
	{
		return null;
	}

	public void SetCloseButtonAction(Action closeAction)
	{
	}

	public void Show(List<GifMoment> moments)
	{
	}

	private void OnMomentSelected(GifMoment m)
	{
	}

	public IEnumerator Hide()
	{
		return null;
	}
}
