using Core;
using UnityEngine;

public class ArrowClubShooter : MonoBehaviour
{
	public GolfBallController Controller;

	public Transform ColliderObject;

	public Transform Hole;

	public float HoleAppearSpeed;

	public ParticleSystem Particles;

	public AudioMaterial ArrowAudioMaterial;

	public GameObject Crosshair;

	public float CrosshairSpeed;

	private bool hasAddedCollider;

	private Vector3 holeOriginalScale;

	private float holeScaletimer;

	private BoxCollider2D boxCollider;

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

	private void TryAim(Vector3 point)
	{
	}
}
