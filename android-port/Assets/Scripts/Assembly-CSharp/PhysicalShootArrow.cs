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
		if (ColliderObject != null)
		{
			boxCollider = ColliderObject.GetComponent<BoxCollider>();
			if (boxCollider != null)
				startSize = boxCollider.size.y;
		}
	}

	private void Start()
	{
		if (Controller != null)
			Controller.OnAimUpdate += OnAimUpdate;
	}

	private void OnAimUpdate(Vector3 dir, bool blocked)
	{
		if (boxCollider == null)
			return;
		if (blocked)
		{
			Vector3 s = boxCollider.size;
			boxCollider.size = new Vector3(s.x, 0f, s.z);
			return;
		}
		Vector3 sz = boxCollider.size;
		boxCollider.size = new Vector3(sz.x, startSize * dir.magnitude, sz.z);
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
		if (hasAddedCollider || Controller == null || Controller.shootArrow == null)
			return;
		ShootArrow arrow = Controller.shootArrow;
		if (ColliderObject != null && arrow.basePivot != null)
			ColliderObject.SetParent(arrow.basePivot, false);

		hasAddedCollider = true;
		arrow.MoveMethod = ShootArrow.MoveMethodEnum.Physics;
		arrow.RotateMethod = ShootArrow.MoveMethodEnum.Physics;

		Rigidbody rb = arrow.gameObject.GetComponent<Rigidbody>() ?? arrow.gameObject.AddComponent<Rigidbody>();
		rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
		rb.isKinematic = true;

		AudioMaterialSettings ams = rb.gameObject.GetComponent<AudioMaterialSettings>() ?? rb.gameObject.AddComponent<AudioMaterialSettings>();
		ams.material = ArrowAudioMaterial;

		int layer = LayerMask.NameToLayer(ArrowLayer);
		if (layer >= 0)
			StansExtensions.SetLayerRecursively(arrow.gameObject, layer);

		SkinnedMeshRenderer smr = arrow.GetComponentInChildren<SkinnedMeshRenderer>();
		if (smr != null)
			smr.updateWhenOffscreen = true;
	}
}
