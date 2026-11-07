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
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void RecieveObject(Rigidbody go, Vector3 relativeOffset)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
