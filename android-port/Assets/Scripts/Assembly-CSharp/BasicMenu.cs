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
	}

	private void Reset(int preselectedButtonIndex = 0)
	{
	}

	private void SetupButton(MenuButton button, bool active, Action clicked)
	{
	}

	public void HideWindow(bool didSayYes)
	{
	}

	private void Awake()
	{
	}

	private void OnMouseExitEvent(GameObject icon)
	{
	}

	private void OnMouseUpEvent(GameObject icon)
	{
	}

	private void OnMouseOverEvent(GameObject icon)
	{
	}

	private void Update()
	{
	}

	private void HandleActiveState()
	{
	}

	private void UpdateSelectionHand(float speed)
	{
	}
}
