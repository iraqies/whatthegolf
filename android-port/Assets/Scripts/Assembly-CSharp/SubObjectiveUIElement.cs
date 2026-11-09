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
		if (ChallengedLocked != null)
			lockedImage = ChallengedLocked.GetComponent<SVGImage>();
	}

	public void Init(bool isLast)
	{
		IsLast = isLast;
	}

	public void Lock()
	{
		if (ElementAnimator != null)
			ElementAnimator.enabled = false;
		if (lockedImage != null)
			lockedImage.color = LockedColor;
		if (ChallengedLocked != null)
			ChallengedLocked.SetActive(true);
	}

	public void Unlock(float duration)
	{
		if (routineRunning)
			return;
		if (duration > 0f && gameObject.activeInHierarchy)
		{
			StartCoroutine(UnlockRoutine(duration));
			return;
		}
		if (lockedImage != null)
			lockedImage.color = UnlockedColor;
		if (ChallengedLocked != null)
			ChallengedLocked.SetActive(false);
	}

	private IEnumerator UnlockRoutine(float duration)
	{
		routineRunning = true;
		yield return new WaitForSecondsRealtime(duration);
		if (lockedImage != null)
			lockedImage.color = UnlockedColor;
		if (ChallengedLocked != null)
			ChallengedLocked.SetActive(false);
		routineRunning = false;
	}
}
