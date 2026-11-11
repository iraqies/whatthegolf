using System.Collections.Generic;
using UnityEngine;

public class HotdogHole : MonoBehaviour
{
	private const string IgnoreGround = "IgnoreGround";

	public string Default = "Default";

	public float upForceForRagdoll = 10f;

	public bool ShouldCheckForRagdoll;

	[SerializeField]
	private string TagToCheckForRoot = "Player";

	[SerializeField]
	private string TagToCheckForRagdoll = "Player";

	[SerializeField]
	private LayerMask BlacklistLayers;

	private List<Transform> ToAddForceTo = new List<Transform>();

	[SerializeField]
	private bool ObjectsCanEscape = true;

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.gameObject == null)
		{
			return;
		}
		int mask = BlacklistLayers;
		if (mask == (mask | (1 << other.gameObject.layer)))
		{
			return;
		}
		Transform root = other.transform.root;
		GameObject target = (root != null && root.gameObject.CompareTag(TagToCheckForRoot)) ? root.gameObject : other.gameObject;
		SetLayerRecursively(target, LayerMask.NameToLayer(IgnoreGround));
	}

	private void OnTriggerExit(Collider other)
	{
		if (!ObjectsCanEscape || other == null || other.gameObject == null)
		{
			return;
		}
		int mask = BlacklistLayers;
		if (mask == (mask | (1 << other.gameObject.layer)))
		{
			return;
		}
		Transform root = other.transform.root;
		bool isPlayerRoot = root != null && root.gameObject.CompareTag("Player");
		bool isRagdollRoot = root != null && root.gameObject.CompareTag(TagToCheckForRagdoll);
		GameObject target = isRagdollRoot ? root.gameObject : other.gameObject;
		if (isPlayerRoot && isRagdollRoot && ShouldCheckForRagdoll)
		{
			if (ToAddForceTo != null && !ToAddForceTo.Contains(root))
			{
				ToAddForceTo.Add(root);
			}
		}
		else
		{
			SetLayerRecursively(target, LayerMask.NameToLayer(Default));
		}
	}

	private void FixedUpdate()
	{
		if (ToAddForceTo != null && ToAddForceTo.Count > 0)
		{
			MoveRagdoll();
		}
	}

	private void MoveRagdoll()
	{
		if (ToAddForceTo == null) return;
		for (int i = 0; i < ToAddForceTo.Count; i++)
		{
			Transform t = ToAddForceTo[i];
			if (t == null) continue;
			Rigidbody[] bodies = t.GetComponentsInChildren<Rigidbody>();
			Vector3 com = getCenterOfMass(bodies);
			bool isAbove = com.y > transform.position.y;
			float dirSign = isAbove ? 1f : -1f;
			int targetLayer = LayerMask.NameToLayer(isAbove ? Default : IgnoreGround);
			if (bodies != null)
			{
				for (int j = 0; j < bodies.Length; j++)
				{
					Rigidbody rb = bodies[j];
					if (rb == null) continue;
					if (rb.position.y < transform.position.y)
					{
						rb.AddForce(Vector3.up * upForceForRagdoll * dirSign);
					}
					rb.gameObject.layer = targetLayer;
				}
			}
		}
		ToAddForceTo.Clear();
	}

	private Vector3 getCenterOfMass(Rigidbody[] assembly)
	{
		Vector3 sum = Vector3.zero;
		if (assembly == null || assembly.Length == 0)
		{
			return sum;
		}
		float totalMass = 0f;
		for (int i = 0; i < assembly.Length; i++)
		{
			if (assembly[i] == null) continue;
			float m = assembly[i].mass;
			sum += assembly[i].worldCenterOfMass * m;
			totalMass += m;
		}
		return totalMass > 0f ? (sum / totalMass) : Vector3.zero;
	}

	public static void SetLayerRecursively(GameObject go, int layerNumber)
	{
		if (go == null) return;
		Transform[] transforms = go.GetComponentsInChildren<Transform>(true);
		if (transforms == null) return;
		for (int i = 0; i < transforms.Length; i++)
		{
			if (transforms[i] != null)
			{
				transforms[i].gameObject.layer = layerNumber;
			}
		}
	}
}
