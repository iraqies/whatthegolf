using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class GoopCamera : MonoBehaviour
{
	private enum Area
	{
		LIVING = 0,
		SOCCER = 1,
		SNEAK = 2,
		OUTSIDE = 3
	}

	public OverworldCameraSettings cameraForOpeningChest;

	private bool previousBallState;

	[SerializeField]
	private Transform _ballProxy;

	[SerializeField]
	private Transform _goop;

	[SerializeField]
	private Animator _goopFlagAnimatior;

	private static readonly int Living = Animator.StringToHash("Living");

	private static readonly int Soccer = Animator.StringToHash("Soccer");

	private static readonly int Sneak = Animator.StringToHash("Sneak");

	private static readonly int Outside = Animator.StringToHash("Outside");

	[SerializeField]
	private OpenBarricade _barricade;

	[SerializeField]
	private GameObject _openIndicator;

	[SerializeField]
	private ClipSettingsCollection _OnGoopMoveSFX;

	[SerializeField]
	private ClipSettingsCollection _OnGoopMoveSFX2;

	[SerializeField]
	private float _animationDuration = 2f;

	[SerializeField]
	private Area _area;

	private int GetAnimation()
	{
		return _area switch
		{
			Area.LIVING => Living,
			Area.SOCCER => Soccer,
			Area.SNEAK => Sneak,
			Area.OUTSIDE => Outside,
			_ => Living,
		};
	}

	private void Awake()
	{
		if (_barricade != null)
		{
			if (_openIndicator != null)
			{
				_barricade.SetActive(new List<GameObject> { _openIndicator });
			}
			List<GameObject> decals = new List<GameObject> { gameObject };
			if (_goopFlagAnimatior != null)
			{
				decals.Add(_goopFlagAnimatior.gameObject);
			}
			_barricade.SetDecals(decals);
			_barricade.UpdateState();
		}
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col != null && col.gameObject != null && col.gameObject.CompareTag("Player"))
		{
			StartCoroutine(GoopCR());
		}
	}

	private IEnumerator GoopCR()
	{
		if (_barricade != null)
		{
			_barricade.OpenDoor(false);
		}
		Collider2D col = GetComponent<Collider2D>();
		if (col != null)
		{
			col.enabled = false;
		}
		yield return StartCoroutine(DoSomething());
		if (_OnGoopMoveSFX != null && _goopFlagAnimatior != null)
		{
			_OnGoopMoveSFX.Play(null, _goopFlagAnimatior.transform.position, 1f, 1f);
		}
		if (_OnGoopMoveSFX2 != null && _goopFlagAnimatior != null)
		{
			_OnGoopMoveSFX2.Play(null, _goopFlagAnimatior.transform.position, 1f, 1f);
		}
		if (_goopFlagAnimatior != null)
		{
			_goopFlagAnimatior.SetBool(GetAnimation(), true);
		}
		float elapsed = 0f;
		while (elapsed < _animationDuration)
		{
			elapsed += Time.fixedDeltaTime;
			if (_goop != null && _ballProxy != null)
			{
				_ballProxy.position = _goop.position;
			}
			yield return new WaitForFixedUpdate();
		}
		if (_openIndicator != null)
		{
			_openIndicator.SetActive(false);
		}
		UnDoSomething();
	}

	private IEnumerator DoSomething()
	{
		OverworldBall2D ball = OverworldBallManager.Instance != null ? OverworldBallManager.Instance.Ball : null;
		if (ball != null && ball.controller != null)
		{
			ball.controller.CancelShooting();
			ball.StopAndSleep();
			previousBallState = ball.controller.enabled;
			ball.controller.enabled = false;
		}
		Vector3 startPos = _ballProxy != null ? _ballProxy.position : transform.position;
		yield return StartCoroutine(pTween.To(0.5f, t =>
		{
			if (cameraForOpeningChest != null)
			{
				cameraForOpeningChest.SetValue(t);
			}
			if (_ballProxy != null && _goop != null)
			{
				_ballProxy.position = Vector3.Lerp(startPos, _goop.position, Mathf.Clamp01(t));
			}
		}));
	}

	public void UnDoSomething()
	{
		StartCoroutine(pTween.To(0.5f, t =>
		{
			if (cameraForOpeningChest != null)
			{
				cameraForOpeningChest.SetValue(1f - t);
			}
		}));
		OverworldBall2D ball = OverworldBallManager.Instance != null ? OverworldBallManager.Instance.Ball : null;
		if (ball != null && ball.controller != null)
		{
			ball.controller.enabled = previousBallState;
		}
	}
}
