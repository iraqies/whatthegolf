using System;
using UnityEngine;
using UnityEngine.UI;

public class ODRDownloadView : MonoBehaviour
{
	[SerializeField]
	private Button cancelButton;

	[SerializeField]
	private Image progressBar;

	[SerializeField]
	private AnimateRectTransform animator;

	private Action onCancel;

	public void Show(Action onCancel)
	{
	}

	public void Hide()
	{
	}

	public void UpdateProgress(float progress)
	{
	}

	public void OnCancelClicked()
	{
	}
}
