using System.Collections.Generic;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class OverworldPressurePlate : MonoBehaviour
{
	public SpriteRenderer RendererButtonUp;

	public Transform buttonTop;

	public List<SpriteRenderer> sprites;

	public InvisibleCullingObject culling;

	public float buttonTopUpPositionY;

	public float buttonTopDownPositionY;

	public UnityEvent OnPress;

	public UnityEvent OnRelease;

	public AudioClipSettings downClip;

	public AudioClipSettings upClip;

	private bool visible;

	private int count;

	private BoxCollider2D col;

	private List<OverworldFanButtonActivator> rigidsOnButton;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void PokeObjectsAndHopePhysicsSolvedIssues()
	{
	}

	private void AddObject(OverworldFanButtonActivator buttonActivator)
	{
	}

	private void RemoveObject(OverworldFanButtonActivator buttonActivator)
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void SetButtonDown()
	{
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	private void SetButtonUp()
	{
	}
}
