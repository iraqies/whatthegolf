using Audio;
using Core;
using UnityEngine;

public class ArrowClubShooter : MonoBehaviour
{
	public GolfBallController Controller;

	public Transform ColliderObject;

	public Transform Hole;

	public float HoleAppearSpeed = 3f;

	public ParticleSystem Particles;

	public AudioMaterial ArrowAudioMaterial;

	public GameObject Crosshair;

	public float CrosshairSpeed = 0.5f;

	private bool hasAddedCollider;

	private Vector3 holeOriginalScale;

	private float holeScaletimer;

	private BoxCollider2D boxCollider;

	private float startSize;

	private void Awake()
	{
		if (Hole != null)
		{
			holeOriginalScale = Hole.transform.localScale;
		}
		if (Crosshair != null)
		{
			Crosshair.transform.SetParent(null);
		}
		if (ColliderObject != null)
		{
			boxCollider = ColliderObject.GetComponent<BoxCollider2D>();
			if (boxCollider != null)
			{
				startSize = boxCollider.size.y;
			}
		}
	}

	private void Start()
	{
		if (Controller != null)
		{
			Controller.OnAimUpdate += OnAimUpdate;
		}
	}

	private void OnAimUpdate(Vector3 dir, bool blocked)
	{
		if (boxCollider == null)
			return;

		if (blocked)
		{
			boxCollider.size = new Vector2(boxCollider.size.x, 0f);
			return;
		}

		boxCollider.size = new Vector2(boxCollider.size.x, startSize * dir.magnitude);
		if (Controller != null && Controller.shootArrow != null && Controller.shootArrow.arrowBaseJoint != null && Controller.shootArrow.arrowHeadJoint != null)
		{
			Vector3 basePos = Controller.shootArrow.arrowBaseJoint.position;
			Vector3 headPos = Controller.shootArrow.arrowHeadJoint.position;
			Vector3 diff = headPos - basePos;
			boxCollider.transform.position = basePos + diff.normalized * (diff.magnitude * 0.5f);
		}
	}

	private void Update()
	{
		if (base.transform.root != null)
		{
			base.transform.position = base.transform.root.position;
		}

		if (!hasAddedCollider && Controller != null && Controller.shootArrow != null)
		{
			if (ColliderObject != null)
			{
				ColliderObject.SetParent(Controller.shootArrow.basePivot, false);
			}
			hasAddedCollider = true;
			Controller.shootArrow.MoveMethod = ShootArrow.MoveMethodEnum.Physics2D;
			Controller.shootArrow.RotateMethod = ShootArrow.MoveMethodEnum.Physics2D;
			Rigidbody2D rb2d = Controller.shootArrow.gameObject.AddComponent<Rigidbody2D>();
			if (rb2d != null)
			{
				rb2d.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
				AudioMaterialSettings matSettings = rb2d.gameObject.AddComponent<AudioMaterialSettings>();
				if (matSettings != null)
				{
					matSettings.material = ArrowAudioMaterial;
				}
				rb2d.isKinematic = true;
			}
		}

		if (Controller != null && Controller.GetShootButtonDown(false, "GolfBallShoot"))
		{
			Cursor.visible = true;
			if (Crosshair != null)
			{
				Crosshair.SetActive(false);
			}
			if (Camera.main != null)
			{
				Vector3 mp = Input.mousePosition;
				Vector3 worldPt = Camera.main.ScreenToWorldPoint(new Vector3(mp.x, mp.y, 1.75f));
				TryAim(worldPt);
			}
		}

		if (Controller != null && Controller.GetShootButtonDown(true, "GolfBallShoot"))
		{
			holeScaletimer = 0f;
		}
		else if (Controller != null && Controller.enabled)
		{
			holeScaletimer += Time.deltaTime * HoleAppearSpeed;
		}

		if (Hole != null)
		{
			Hole.transform.localScale = Vector3.Lerp(Vector3.zero, holeOriginalScale, Mathf.Clamp01(holeScaletimer));
		}

		if (Controller != null && Controller.playerInput != null)
		{
			float ax = Controller.playerInput.GetAxisRaw("GolfBallAimHorizontal") * CrosshairSpeed;
			float ay = Controller.playerInput.GetAxisRaw("GolfBallAimVertical") * CrosshairSpeed;
			Vector2 move = new Vector2(ax, ay);
			if ((move - Vector2.zero).sqrMagnitude >= 1E-10f)
			{
				if (Crosshair != null)
				{
					Crosshair.SetActive(true);
				}
				Cursor.visible = false;
			}
			if (Controller.GetShootButtonDown(true, "GolfBallShoot"))
			{
				if (Crosshair != null)
				{
					TryAim(Crosshair.transform.position);
				}
			}
			else if (Crosshair != null && Crosshair.activeSelf && !Controller.GetShootButton(true, "GolfBallShoot"))
			{
				Crosshair.transform.position += new Vector3(ax, ay, 0f);
			}
		}
	}

	private void TryAim(Vector3 point)
	{
		if (Controller != null)
		{
			Controller.enabled = true;
		}
		base.transform.position = point;
		holeScaletimer = 0f;
		if (Particles != null)
		{
			Particles.Play();
		}
	}
}
