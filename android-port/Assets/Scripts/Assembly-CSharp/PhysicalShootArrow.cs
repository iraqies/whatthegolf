using Core;
using UnityEngine;

public class PhysicalShootArrow : MonoBehaviour
{
	public GolfBallController Controller;

	public Transform ColliderObject;

	public AudioMaterial ArrowAudioMaterial;

	public string ArrowLayer;

	private bool hasAddedCollider;

	private BoxCollider boxCollider;

	private float startSize;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnAimUpdate(Vector3 dir, bool blocked)
	{
	}

	private void Update()
	{
	}
}
