using System.Collections.Generic;
using UnityEngine;

public class GolfPortal : MonoBehaviour
{
	public GolfPortal LinkedPortal;

	public List<string> AllowedTags;

	private GameObject entryPoint;

	public List<GameObject> waitForExits;

	[SerializeField]
	private AudioClip sfxPortal;

	private Color baseColor;

	private SpriteRenderer render;

	private float colorValue;

	private void Awake()
	{
		waitForExits = new List<GameObject>();
		entryPoint = new GameObject("portal entry");
		entryPoint.transform.SetParent(base.transform);
		entryPoint.transform.position = Vector3.zero;
		entryPoint.transform.rotation = Quaternion.identity;
		render = GetComponentInChildren<SpriteRenderer>();
		if (render != null)
		{
			baseColor = render.color;
		}
	}

	private void Update()
	{
		colorValue = Mathf.MoveTowards(colorValue, 0f, Time.unscaledDeltaTime * 3f);
		if (render != null)
		{
			render.color = Color.Lerp(baseColor, Color.white, colorValue);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (LinkedPortal == null || other == null || waitForExits == null || waitForExits.Contains(other.gameObject) || AllowedTags == null || !AllowedTags.Contains(other.transform.tag))
		{
			return;
		}
		if (render != null)
		{
			render.color = Color.white;
		}
		colorValue = 1f;
		LinkedPortal.colorValue = 1f;
		Rigidbody component = other.gameObject.GetComponent<Rigidbody>();
		if (component == null)
		{
			return;
		}
		entryPoint.transform.position = other.transform.position;
		entryPoint.transform.rotation = Quaternion.LookRotation(component.velocity.normalized, Vector3.up);
		Debug.DrawLine(entryPoint.transform.position, other.transform.position + component.velocity, Color.red, 5f);
		LinkedPortal.RecieveObject(component, entryPoint.transform.localPosition);
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(sfxPortal, delegate(AudioSource s)
			{
				if (s != null)
				{
					s.volume = 0.5f;
					s.pitch = 1f;
				}
			});
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other != null && waitForExits != null && waitForExits.Contains(other.gameObject))
		{
			waitForExits.Remove(other.gameObject);
		}
	}

	public void RecieveObject(Rigidbody go, Vector3 relativeOffset)
	{
		if (LinkedPortal == null || go == null)
		{
			return;
		}
		Vector3 position = LinkedPortal.transform.InverseTransformPoint(go.transform.position);
		go.transform.position = base.transform.TransformPoint(position) + base.transform.forward;
		go.velocity = base.transform.forward * go.velocity.magnitude;
		Debug.DrawLine(go.transform.position, go.transform.position + go.velocity, Color.blue, 5f);
		if (waitForExits != null && !waitForExits.Contains(go.gameObject))
		{
			waitForExits.Add(go.gameObject);
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		if (LinkedPortal != null)
		{
			Gizmos.DrawLine(base.transform.position, LinkedPortal.transform.position);
		}
	}
}
