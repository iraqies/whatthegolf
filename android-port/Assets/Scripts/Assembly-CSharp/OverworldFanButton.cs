using System.Collections.Generic;
using Audio;
using UnityEngine;

public class OverworldFanButton : MonoBehaviour
{
	public List<OverworldFan> connectedFans;

	public bool onFanState;

	public SpriteRenderer RendererButtonUp;

	public Transform buttonTop;

	public List<SpriteRenderer> sprites;

	public InvisibleCullingObject culling;

	public float buttonTopUpPositionY;

	public float buttonTopDownPositionY;

	public AudioClipSettings downClip;

	public AudioClipSettings upClip;

	private bool visible;

	private int count;

	private BoxCollider2D col;

	private List<OverworldFanButtonActivator> rigidsOnButton;

	public OverworldFanButtonActivator defaultObject;

	private void SetFans(bool state)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void PokeObjectsAndHopePhysicsSolvedIssues()
	{
	}

	public void AddAObject()
	{
	}

	private void AddObject(OverworldFanButtonActivator buttonActivator)
	{
	}

	private void RemoveObject(OverworldFanButtonActivator buttonActivator)
	{
	}

	private void OnDrawGizmosSelected()
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
