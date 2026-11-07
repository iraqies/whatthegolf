using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PopupController : MonoBehaviour
{
	[SerializeField]
	protected AnimateRectTransform container;

	[SerializeField]
	protected AdventureButton play;

	[SerializeField]
	protected Button close;

	private bool showing;

	public bool IsShowing => false;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Show()
	{
	}

	public void Hide(bool confirmed, bool invokeCallbacks)
	{
	}

	private void Open()
	{
	}

	private void Play()
	{
	}

	private void Close(bool confirmed, bool invokeCallbacks)
	{
	}

	private IEnumerator OnCloseCR(bool confirmed, bool invokeCallbacks)
	{
		return null;
	}

	protected virtual void Update()
	{
	}

	protected virtual void OnOpen()
	{
	}

	protected virtual void OnClosing()
	{
	}

	protected virtual void OnClose(bool confirmed, bool invokeCallbacks)
	{
	}

	protected virtual void OnPlay()
	{
	}
}
