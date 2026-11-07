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
	}

	public void SetOpenIndicator(bool open, bool setRotation = false)
	{
	}

	public void ToggleBlinkRoutine(bool turnOn)
	{
	}

	private IEnumerator BlinkRoutine()
	{
		return null;
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
