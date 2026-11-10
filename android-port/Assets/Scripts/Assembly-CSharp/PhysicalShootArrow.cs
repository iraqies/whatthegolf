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
		if (Controller == null)
			Controller = GetComponent<GolfBallController>();
		if (Controller != null)
		{
			Controller.OnAimUpdate -= OnAimUpdate;
			Controller.OnAimUpdate += OnAimUpdate;
		}
		if (ColliderObject != null)
		{
			boxCollider = ColliderObject.GetComponent<BoxCollider>();
			if (boxCollider != null)
				startSize = boxCollider.size.z;
		}
	}

	private void Start()
	{
		if (Controller != null && Controller.shootArrow != null)
		{
			Controller.shootArrow.MoveMethod = ShootArrow.MoveMethodEnum.Physics;
			Controller.shootArrow.RotateMethod = ShootArrow.MoveMethodEnum.SmoothedPhysics;
		}
	}

	private void OnAimUpdate(Vector3 dir, bool blocked)
	{
		if (boxCollider != null)
		{
			float len = dir.magnitude * 0.125f + startSize;
			boxCollider.size = new Vector3(boxCollider.size.x, boxCollider.size.y, len);
			boxCollider.center = new Vector3(boxCollider.center.x, boxCollider.center.y, -len * 0.5f);
		}
	}

	private void Update()
	{
		if (hasAddedCollider || Controller == null)
			return;
		ShootArrow arrow = Controller.shootArrow;
		if (arrow == null || arrow.arrowHeadJoint == null)
			return;

		Rigidbody rb = arrow.gameObject.AddComponent<Rigidbody>();
		rb.useGravity = false;
		rb.isKinematic = true;
		rb.interpolation = RigidbodyInterpolation.Interpolate;

		if (ArrowAudioMaterial != null)
		{
			var ao = arrow.gameObject.GetComponent<Audio.AudioMaterialSettings>() ?? arrow.gameObject.AddComponent<Audio.AudioMaterialSettings>();
			ao.material = ArrowAudioMaterial;
		}

		if (ColliderObject != null)
		{
			Transform spawned = Instantiate(ColliderObject, arrow.arrowHeadJoint);
			spawned.localPosition = Vector3.zero;
			spawned.localRotation = Quaternion.identity;
			spawned.localScale = Vector3.one;
			boxCollider = spawned.GetComponent<BoxCollider>();
			if (boxCollider != null)
				startSize = boxCollider.size.z;
		}

		if (!string.IsNullOrEmpty(ArrowLayer))
		{
			int layer = LayerMask.NameToLayer(ArrowLayer);
			if (layer >= 0)
			{
				foreach (Transform t in arrow.GetComponentsInChildren<Transform>(true))
				{
					if (t != null)
						t.gameObject.layer = layer;
				}
			}
		}

		hasAddedCollider = true;
	}
}
