using System.Collections;
using Audio;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SubObjectiveUIElement : MonoBehaviour
{
	public SVGImage Image;

	public TextMeshProUGUI Text;

	public Button Button;

	public RectTransform RectTransform;

	public GameObject ChallengedLocked;

	public Color LockedColor;

	public Color UnlockedColor;

	public string ChallengeID;

	public string ChallengeTitleID;

	public SVGImage ImageDisabled;

	public SVGImage ImageButton;

	public Sprite SpriteButton;

	public Sprite SpriteDisabled;

	public Animator ElementAnimator;

	public Sprite ArrowSprite;

	public Sprite SquareSprite;

	public Sprite ArrowSpriteMask;

	public Sprite SquareSpriteMask;

	public ClipSettingsCollection sfxOnSelect;

	private SVGImage lockedImage;

	private bool routineRunning;

	public bool IsLast { get; private set; }

	private void Awake()
	{
	}

	public void Init(bool isLast)
	{
	}

	public void Lock()
	{
	}

	public void Unlock(float duration)
	{
	}

	private IEnumerator UnlockRoutine(float duration)
	{
		return null;
	}
}
