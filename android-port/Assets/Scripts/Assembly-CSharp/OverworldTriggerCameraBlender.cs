using System.Collections.Generic;
using UnityEngine;

public class OverworldTriggerCameraBlender : MonoBehaviour
{
	public OverworldCameraSettings CameraSettings;

	public List<SpriteRenderer> backgroundRenderers;

	public Color baseBackground;

	public Color endBackground;

	private bool ballIsInside;

	private Coroutine current;

	private float lastPct;

	private Collider2D collider;

	public bool dontBlend;

	private void Awake()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	public void BlendIn(float time)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	public void BlendOut(float time)
	{
	}

	public void BlendInWithoutSettings()
	{
	}

	public void BlendOutWithoutSettings()
	{
	}
}
