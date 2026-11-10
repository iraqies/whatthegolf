using System;
using System.Collections.Generic;
using Audio;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BasicMenu : MonoBehaviour
{
	[Serializable]
	public class MenuButton
	{
		public GameObject ButtonTransform;

		public UnityEvent OnClick;

		public Image image;

		public Animator animator;
	}

	public enum MenuDirectionEnum
	{
		Horizontal = 0,
		Vertical = 1
	}

	[SerializeField]
	private List<MenuButton> Buttons;

	public Color TextClickedColor;

	public Color TextBaseColor;

	public MenuDirectionEnum MenuDirection;

	public GameObject HeaderContainer;

	[SerializeField]
	private TextMeshProUGUI TextHeader;

	[SerializeField]
	private TextMeshProUGUI TextDescrption;

	[SerializeField]
	private TextMeshProUGUI ConfirmText;

	[SerializeField]
	private TextMeshProUGUI CancelText;

	[SerializeField]
	private Button BackgroundCloser;

	[SerializeField]
	private bool handleExitInput;

	[SerializeField]
	private int cancelButtonIndex;

	[SerializeField]
	private bool shouldAnimate;

	public ClipSettingsCollection hoverButtonSFX;

	public ClipSettingsCollection selectButtonSFX;

	public List<AudioClip> HoverOnButtonClips;

	public List<AudioClip> ButtonSelectedClips;

	public Transform selectionHand;

	private Vector3 handposition;

	private int currentActiveButton;

	private float buttonSwitchDelay;

	private const string idMenuUiOk = "ID_MENU_UI_OK";

	public const string idMenuUiCancel = "ID_MENU_UI_CANCEL";

	public void SetupMenu(bool rotatedToFakeLandscape, bool handleExitInputFlag, string header, string description, Action closeAction, string confirmString = "ID_MENU_UI_OK", string cancelString = "ID_MENU_UI_CANCEL", Action confirmAction = null, Action cancelAction = null, int selectedButtonIndex = 0)
	{
		string confStr = confirmString ?? idMenuUiOk;
		string cancStr = cancelString ?? idMenuUiCancel;
		Action firstBtnAction;
		Action secondBtnAction;
		if (confirmAction != null && cancelAction != null)
		{
			firstBtnAction = cancelAction;
			secondBtnAction = confirmAction;
		}
		else if (confirmAction != null)
		{
			firstBtnAction = null;
			secondBtnAction = confirmAction;
		}
		else
		{
			firstBtnAction = null;
			secondBtnAction = closeAction;
			if (string.IsNullOrEmpty(cancStr))
				cancStr = idMenuUiOk;
		}

		var rt = GetComponent<RectTransform>();
		if (rt != null)
		{
			rt.localRotation = Quaternion.Euler(0f, 0f, rotatedToFakeLandscape ? -90f : 0f);
		}
		handleExitInput = handleExitInputFlag;

		if (Buttons != null && Buttons.Count > 0)
		{
			SetupButton(Buttons[0], firstBtnAction != null, firstBtnAction);
		}
		if (Buttons != null && Buttons.Count > 1)
		{
			SetupButton(Buttons[1], secondBtnAction != null, secondBtnAction);
		}

		if (HeaderContainer != null)
			HeaderContainer.SetActive(!string.IsNullOrEmpty(header));
		if (TextHeader != null)
			TextHeader.SetLocalizedText(header);
		if (TextDescrption != null)
			TextDescrption.SetLocalizedText(description);
		if (ConfirmText != null)
			ConfirmText.SetLocalizedText(confStr);
		if (CancelText != null)
			CancelText.SetLocalizedText(cancStr);

		if (BackgroundCloser != null && BackgroundCloser.onClick != null)
		{
			BackgroundCloser.onClick.RemoveAllListeners();
			if (closeAction != null)
				BackgroundCloser.onClick.AddListener(() => closeAction());
		}

		Reset(selectedButtonIndex);
	}

	private void Reset(int preselectedButtonIndex = 0)
	{
		if (Buttons == null)
			return;
		int activeIdx = 0;
		for (int i = 0; i < Buttons.Count; i++)
		{
			var btn = Buttons[i];
			if (btn == null) continue;
			if (btn.ButtonTransform != null && btn.image != null)
				btn.image.color = TextBaseColor;
			if (btn.ButtonTransform != null && btn.ButtonTransform.activeSelf)
			{
				if (activeIdx == preselectedButtonIndex)
					currentActiveButton = i;
				activeIdx++;
			}
		}
		buttonSwitchDelay = 0.2f;
		UpdateSelectionHand(-1f);
	}

	private void SetupButton(MenuButton button, bool active, Action clicked)
	{
		if (button == null)
			return;
		if (button.OnClick != null)
			button.OnClick.RemoveAllListeners();
		if (button.ButtonTransform != null)
			button.ButtonTransform.SetActive(active);
		if (button.ButtonTransform != null)
		{
			var uiBtn = button.ButtonTransform.GetComponent<Button>() ?? button.ButtonTransform.GetComponentInChildren<Button>();
			if (uiBtn != null && uiBtn.onClick != null)
			{
				uiBtn.onClick.RemoveAllListeners();
				if (clicked != null)
					uiBtn.onClick.AddListener(() => clicked());
			}
		}
		if (clicked != null && button.OnClick != null)
		{
			button.OnClick.AddListener(() => clicked());
		}
	}

	public void HideWindow(bool didSayYes)
	{
		if (Buttons != null)
		{
			foreach (var b in Buttons)
			{
				if (b != null && b.OnClick != null)
					b.OnClick.RemoveAllListeners();
			}
		}
		if (BackgroundCloser != null && BackgroundCloser.onClick != null)
			BackgroundCloser.onClick.RemoveAllListeners();

		int idx = didSayYes ? 1 : 0;
		if (Buttons != null && idx >= 0 && idx < Buttons.Count && Buttons[idx] != null && Buttons[idx].image != null)
		{
			Buttons[idx].image.color = TextClickedColor;
		}
		if (selectButtonSFX != null && AudioManager.Instance != null)
		{
			selectButtonSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);
		}
	}

	private void Awake()
	{
		UpdateSelectionHand(-1f);
		if (Buttons == null)
			return;
		foreach (var btn in Buttons)
		{
			if (btn == null || btn.ButtonTransform == null)
				continue;
			var handler = btn.ButtonTransform.GetComponent<NotifyOnMouseOverImage>() ?? btn.ButtonTransform.AddComponent<NotifyOnMouseOverImage>();
			if (handler != null)
			{
				handler.OnMouseOverEvent -= OnMouseOverEvent;
				handler.OnMouseOverEvent += OnMouseOverEvent;
				handler.OnMouseExitEvent -= OnMouseExitEvent;
				handler.OnMouseExitEvent += OnMouseExitEvent;
				handler.OnMouseUpEvent -= OnMouseUpEvent;
				handler.OnMouseUpEvent += OnMouseUpEvent;
			}
		}
	}

	private void OnMouseExitEvent(GameObject icon)
	{
		if (Buttons == null || icon == null) return;
		for (int i = 0; i < Buttons.Count; i++)
		{
			var b = Buttons[i];
			if (b != null && b.ButtonTransform == icon && b.animator != null)
				b.animator.SetBool("Hover", false);
		}
	}

	private void OnMouseUpEvent(GameObject icon)
	{
		if (Buttons == null || icon == null) return;
		for (int i = 0; i < Buttons.Count; i++)
		{
			var b = Buttons[i];
			if (b != null && b.ButtonTransform == icon)
			{
				b.OnClick?.Invoke();
				break;
			}
		}
	}

	private void OnMouseOverEvent(GameObject icon)
	{
		if (Buttons == null || icon == null) return;
		for (int i = 0; i < Buttons.Count; i++)
		{
			var b = Buttons[i];
			if (b != null && b.ButtonTransform == icon)
			{
				currentActiveButton = i;
				if (b.animator != null)
					b.animator.SetBool("Hover", true);
				if (hoverButtonSFX != null && AudioManager.Instance != null)
					hoverButtonSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);
			}
		}
	}

	private void Update()
	{
		if (handleExitInput && InputHelper.GetAllPlayerButtonCancel())
		{
			if (Buttons != null && cancelButtonIndex >= 0 && cancelButtonIndex < Buttons.Count && Buttons[cancelButtonIndex] != null && Buttons[cancelButtonIndex].ButtonTransform != null && Buttons[cancelButtonIndex].ButtonTransform.activeSelf)
			{
				Buttons[cancelButtonIndex].OnClick?.Invoke();
			}
			else if (BackgroundCloser != null && BackgroundCloser.onClick != null)
			{
				BackgroundCloser.onClick.Invoke();
			}
		}
	}

	private void HandleActiveState()
	{
	}

	private void UpdateSelectionHand(float speed)
	{
		if (selectionHand == null || Buttons == null || currentActiveButton < 0 || currentActiveButton >= Buttons.Count)
			return;
		var b = Buttons[currentActiveButton];
		if (b != null && b.ButtonTransform != null)
		{
			selectionHand.position = b.ButtonTransform.transform.position;
		}
	}
}
