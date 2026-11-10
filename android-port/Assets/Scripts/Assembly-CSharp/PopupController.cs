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

	public bool IsShowing => showing;

	private void OnEnable()
	{
		if (close != null)
		{
			close.onClick.AddListener(delegate
			{
				Close(confirmed: false, invokeCallbacks: true);
			});
		}
		if (play != null)
		{
			play.onClick.AddListener(Play);
		}
	}

	private void OnDisable()
	{
		if (close != null)
		{
			close.onClick.RemoveAllListeners();
		}
		if (play != null)
		{
			play.onClick.RemoveAllListeners();
		}
	}

	public void Show()
	{
		if (UIBackgroundFader.Instance != null)
		{
			UIBackgroundFader.Instance.Register();
		}
		Open();
	}

	public void Hide(bool confirmed, bool invokeCallbacks)
	{
		if (UIBackgroundFader.Instance != null)
		{
			UIBackgroundFader.Instance.Deregister();
		}
		Close(confirmed, invokeCallbacks);
	}

	private void Open()
	{
		showing = true;
		if (container != null)
		{
			container.SetShow(show: true, instant: false);
		}
		OnOpen();
	}

	private void Play()
	{
		if (UIBackgroundFader.Instance != null)
		{
			UIBackgroundFader.Instance.Deregister();
		}
		showing = false;
		OnClosing();
		StartCoroutine(OnCloseCR(confirmed: true, invokeCallbacks: true));
		OnPlay();
	}

	private void Close(bool confirmed, bool invokeCallbacks)
	{
		if (UIBackgroundFader.Instance != null)
		{
			UIBackgroundFader.Instance.Deregister();
		}
		showing = false;
		OnClosing();
		StartCoroutine(OnCloseCR(confirmed, invokeCallbacks));
	}

	private IEnumerator OnCloseCR(bool confirmed, bool invokeCallbacks)
	{
		float d = (container != null) ? container.Hide() : 0f;
		if (d > 0f)
		{
			yield return new WaitForSeconds(d);
		}
		OnClose(confirmed, invokeCallbacks);
	}

	protected virtual void Update()
	{
		if (!showing)
		{
			return;
		}
		if (Singleton<PlayerInput>.HasInstance && Singleton<PlayerInput>.Instance != null)
		{
			if (Singleton<PlayerInput>.Instance.GetButtonDown("Cancel"))
			{
				Close(confirmed: false, invokeCallbacks: true);
				return;
			}
			if (Singleton<PlayerInput>.Instance.GetButtonDown("Confirm") && play != null && play.gameObject.activeInHierarchy && play.interactable)
			{
				Play();
			}
		}
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
