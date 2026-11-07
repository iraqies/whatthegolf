using Audio;
using UnityEngine;

public class DoubleSwingersPlatform : MonoBehaviour
{
	public float BounceSpeed;

	public float BounceHeight;

	public float RotateSpeed;

	public Color GlowColor;

	public Material OuterMat;

	public MeshRenderer OuterRing;

	public ClipSettingsCollection HitClip;

	private Vector3 basePosition;

	private Rigidbody rigid;

	private Vector3 targetPosition;

	private Vector3 velRef;

	private float colorTarget;

	private Color baseColor;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Glow()
	{
	}

	public void Bounce()
	{
	}
}
