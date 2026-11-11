using System;
using System.Collections;
using UnityEngine;

public class DampVelocityOnTrigger : MonoBehaviour
{
	[Flags]
	public enum TriggerMode
	{
		None = 0,
		OnEnter = 1,
		OnExit = 2
	}

	[SerializeField]
	private LayerMask affectLayer;

	[SerializeField]
	private float dampDuration = 0.15f;

	[SerializeField]
	private float dampFactor = 0.7f;

	[SerializeField]
	private TriggerMode dampOnTrigger = TriggerMode.OnEnter;

	public float DampFactor => 1f - dampFactor;

	private IEnumerator DampCoroutine(Rigidbody rigid)
	{
		float timer = 0f;
		while (timer < dampDuration)
		{
			rigid.velocity *= DampFactor;
			yield return null;
			timer += Time.deltaTime;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (dampOnTrigger.HasFlag(TriggerMode.OnEnter) && IsInLayer(other.gameObject) && other.TryGetComponent<Rigidbody>(out var component))
		{
			StartCoroutine(DampCoroutine(component));
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (dampOnTrigger.HasFlag(TriggerMode.OnExit) && IsInLayer(other.gameObject) && other.TryGetComponent<Rigidbody>(out var component))
		{
			StartCoroutine(DampCoroutine(component));
		}
	}

	private bool IsInLayer(GameObject go)
	{
		return (affectLayer.value & (1 << go.gameObject.layer)) == 1 << go.gameObject.layer;
	}
}
