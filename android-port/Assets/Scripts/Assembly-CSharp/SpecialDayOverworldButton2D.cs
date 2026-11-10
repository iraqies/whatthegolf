using System.Collections;
using Hub;
using UnityEngine;

public class SpecialDayOverworldButton2D : MonoBehaviour
{
	public SpecialDayOverworldDoor door;

	[SerializeField]
	private PerlinShake bubbleShake;

	[SerializeField]
	private SpriteRenderer[] ButtonRenderers;

	[SerializeField]
	private SpriteRenderer[] ButtonBackRenderers;

	[SerializeField]
	private Transform openIndicator;

	[SerializeField]
	private SpecialDayLockView lockView;

	[SerializeField]
	private SpecialDayView view;

	public Color[] OpenColors;

	public Color[] UnlockedColors;

	private OverworldID _overworldID;

	private Coroutine _currentBlinkRoutine;

	private bool _canOpen;

	public void SetState(bool isOpen, bool hasBeenOpenedBefore)
	{
		if (isOpen)
		{
			if (!hasBeenOpenedBefore && !DailyChallenges.HasSpecialBeenPlayedBefore())
			{
				_canOpen = true;
				SetOpenIndicator(open: true, setRotation: true);
				ToggleBlinkRoutine(turnOn: true);
			}
			else if (door != null)
			{
				door.OpenDoor(null, instant: true);
			}
		}
		else
		{
			_canOpen = false;
			if (openIndicator != null)
			{
				openIndicator.gameObject.SetActive(value: false);
			}
			if (_currentBlinkRoutine != null)
			{
				StopCoroutine(_currentBlinkRoutine);
				_currentBlinkRoutine = null;
			}
			if (door != null)
			{
				door.CloseDoor(null, instant: false);
			}
		}
	}

	public void SetOpenIndicator(bool open, bool setRotation = false)
	{
		if (setRotation && door != null && openIndicator != null)
		{
			Vector3 diff = door.transform.position - openIndicator.position;
			float angle = Mathf.Atan2(diff.y, diff.x) * 57.29578f - 90f;
			openIndicator.rotation = Quaternion.Euler(0f, 0f, angle);
		}
		if (openIndicator != null)
		{
			openIndicator.gameObject.SetActive(open);
		}
	}

	public void ToggleBlinkRoutine(bool turnOn)
	{
		if (turnOn)
		{
			if (gameObject.activeInHierarchy && _currentBlinkRoutine == null)
			{
				_currentBlinkRoutine = StartCoroutine(BlinkRoutine());
			}
		}
		else if (_currentBlinkRoutine != null)
		{
			StopCoroutine(_currentBlinkRoutine);
			_currentBlinkRoutine = null;
		}
	}

	private IEnumerator BlinkRoutine()
	{
		WaitForSeconds wait = new WaitForSeconds(0.6f);
		while (true)
		{
			if (ButtonRenderers != null && OpenColors != null && OpenColors.Length >= 2)
			{
				for (int i = 0; i < ButtonRenderers.Length; i++)
				{
					if (ButtonRenderers[i] != null) ButtonRenderers[i].color = OpenColors[0];
					if (ButtonBackRenderers != null && i < ButtonBackRenderers.Length && ButtonBackRenderers[i] != null) ButtonBackRenderers[i].color = OpenColors[1];
				}
			}
			yield return wait;
			if (ButtonRenderers != null && UnlockedColors != null && UnlockedColors.Length >= 2)
			{
				for (int j = 0; j < ButtonRenderers.Length; j++)
				{
					if (ButtonRenderers[j] != null) ButtonRenderers[j].color = UnlockedColors[0];
					if (ButtonBackRenderers != null && j < ButtonBackRenderers.Length && ButtonBackRenderers[j] != null) ButtonBackRenderers[j].color = UnlockedColors[1];
				}
			}
			yield return wait;
		}
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (!_canOpen || collision == null || collision.gameObject == null)
		{
			return;
		}
		var ball = collision.gameObject.GetComponent<OverworldBall2D>() ?? collision.collider?.GetComponentInParent<OverworldBall2D>();
		if (ball == null || !ball.CheckUseInteractiveThing())
		{
			return;
		}
		_canOpen = false;
		if (_currentBlinkRoutine != null)
		{
			StopCoroutine(_currentBlinkRoutine);
			_currentBlinkRoutine = null;
		}
		if (ButtonRenderers != null && OpenColors != null && OpenColors.Length >= 2)
		{
			for (int i = 0; i < ButtonRenderers.Length; i++)
			{
				if (ButtonRenderers[i] != null) ButtonRenderers[i].color = OpenColors[0];
				if (ButtonBackRenderers != null && i < ButtonBackRenderers.Length && ButtonBackRenderers[i] != null) ButtonBackRenderers[i].color = OpenColors[1];
			}
		}
		if (openIndicator != null)
		{
			openIndicator.gameObject.SetActive(value: false);
		}
		if (door != null)
		{
			door.OpenDoor(null, instant: false);
		}
		if (lockView != null)
		{
			lockView.Unlock(immediate: false);
		}
		if (view != null)
		{
			view.MarkDoorAsOpened();
		}
		var rb = ball.GetComponent<Rigidbody2D>();
		if (rb != null && openIndicator != null)
		{
			Vector3 dir = (openIndicator.position - transform.position).normalized;
			Vector2 newDir = new Vector2(dir.x, dir.y) + rb.velocity.normalized;
			rb.velocity = newDir * rb.velocity.magnitude * 0.16f;
		}
	}
}
