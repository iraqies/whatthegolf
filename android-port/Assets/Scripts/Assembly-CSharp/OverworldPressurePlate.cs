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
	public float buttonTopUpPositionY = 0.1f;
	public float buttonTopDownPositionY;
	public UnityEvent OnPress;
	public UnityEvent OnRelease;
	public AudioClipSettings downClip;
	public AudioClipSettings upClip;
	private bool visible = true;
	private int count;
	private BoxCollider2D col;
	private List<OverworldFanButtonActivator> rigidsOnButton = new List<OverworldFanButtonActivator>();

	private void Awake()
	{
		col = GetComponent<BoxCollider2D>();
		if (rigidsOnButton == null)
			rigidsOnButton = new List<OverworldFanButtonActivator>();
	}

	private void OnEnable()
	{
		PokeObjectsAndHopePhysicsSolvedIssues();
	}

	private void PokeObjectsAndHopePhysicsSolvedIssues()
	{
		if (rigidsOnButton == null) return;
		foreach (var r in rigidsOnButton)
		{
			if (r != null)
			{
				var rb = r.GetComponent<Rigidbody2D>();
				if (rb != null) rb.WakeUp();
			}
		}
	}

	private void AddObject(OverworldFanButtonActivator buttonActivator)
	{
		if (buttonActivator == null) return;
		if (rigidsOnButton == null)
			rigidsOnButton = new List<OverworldFanButtonActivator>();
		if (!rigidsOnButton.Contains(buttonActivator))
		{
			rigidsOnButton.Add(buttonActivator);
			count = rigidsOnButton.Count;
			if (count == 1)
				SetButtonDown();
		}
	}

	private void RemoveObject(OverworldFanButtonActivator buttonActivator)
	{
		if (buttonActivator == null || rigidsOnButton == null) return;
		if (rigidsOnButton.Remove(buttonActivator))
		{
			count = rigidsOnButton.Count;
			if (count == 0)
				SetButtonUp();
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision == null) return;
		var act = collision.GetComponent<OverworldFanButtonActivator>() ?? collision.GetComponentInParent<OverworldFanButtonActivator>();
		if (act != null)
		{
			AddObject(act);
		}
		else if (collision.GetComponent<OverworldBall2D>() != null || collision.attachedRigidbody != null)
		{
			count++;
			if (count == 1)
				SetButtonDown();
		}
	}

	private void SetButtonDown()
	{
		if (buttonTop != null)
		{
			Vector3 p = buttonTop.localPosition;
			p.y = buttonTopDownPositionY;
			buttonTop.localPosition = p;
		}
		if (RendererButtonUp != null)
			RendererButtonUp.enabled = false;
		if (downClip != null)
			downClip.Play(transform.position);
		OnPress?.Invoke();
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision == null) return;
		var act = collision.GetComponent<OverworldFanButtonActivator>() ?? collision.GetComponentInParent<OverworldFanButtonActivator>();
		if (act != null)
		{
			RemoveObject(act);
		}
		else if (collision.GetComponent<OverworldBall2D>() != null || collision.attachedRigidbody != null)
		{
			count = Mathf.Max(0, count - 1);
			if (count == 0)
				SetButtonUp();
		}
	}

	private void SetButtonUp()
	{
		if (buttonTop != null)
		{
			Vector3 p = buttonTop.localPosition;
			p.y = buttonTopUpPositionY;
			buttonTop.localPosition = p;
		}
		if (RendererButtonUp != null)
			RendererButtonUp.enabled = true;
		if (upClip != null)
			upClip.Play(transform.position);
		OnRelease?.Invoke();
	}
}
