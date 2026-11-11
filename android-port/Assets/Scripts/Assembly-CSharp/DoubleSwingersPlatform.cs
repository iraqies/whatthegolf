using Audio;
using UnityEngine;

public class DoubleSwingersPlatform : MonoBehaviour
{
	public float BounceSpeed = 10f;

	public float BounceHeight = 1f;

	public float RotateSpeed = 45f;

	public Color GlowColor = Color.white;

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
		rigid = GetComponent<Rigidbody>();
		basePosition = transform.position;
		targetPosition = basePosition;
		if (OuterMat != null)
		{
			baseColor = OuterMat.color;
			OuterMat = Object.Instantiate(OuterMat);
			if (OuterRing != null)
			{
				OuterRing.material = OuterMat;
			}
		}
	}

	private void Update()
	{
		if (OuterMat != null)
		{
			OuterMat.color = Color.Lerp(baseColor, GlowColor, colorTarget);
		}
		colorTarget = Mathf.MoveTowards(colorTarget, 0f, Time.deltaTime * 2f);
	}

	private void FixedUpdate()
	{
		if (rigid != null)
		{
			if (BounceSpeed > 0f)
			{
				rigid.MovePosition(Vector3.MoveTowards(rigid.position, targetPosition, Time.deltaTime * BounceSpeed));
			}
			if (RotateSpeed != 0f)
			{
				rigid.MoveRotation(rigid.rotation * Quaternion.AngleAxis(RotateSpeed * Time.deltaTime, Vector3.up));
			}
		}
		targetPosition = Vector3.SmoothDamp(targetPosition, basePosition, ref velRef, 0.2f);
	}

	public void Glow()
	{
		colorTarget = 1f;
	}

	public void Bounce()
	{
		targetPosition = basePosition + Vector3.down * BounceHeight;
		if (HitClip != null)
		{
			HitClip.Play(null, transform.position, 1f, 1f);
		}
	}
}
