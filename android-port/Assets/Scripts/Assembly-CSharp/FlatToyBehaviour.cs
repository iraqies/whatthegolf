using System.Collections;
using UnityEngine;

public class FlatToyBehaviour : MonoBehaviour
{
	public float lifeTime;

	public GameObject objectTest;

	private Rigidbody rigidbody;

	private Animator animator;

	private MeshRenderer meshRenderer;

	private MeshFilter meshFilter;

	private MeshRenderer rendererToCopy;

	private MeshFilter meshToCopy;

	private GameObject flattenedObject;

	private bool startedShaking;

	private Coroutine lifetimeCoroutine;

	private BoxCollider flatCollider;

	private void Start()
	{
		lifetimeCoroutine = StartCoroutine(FlatLifetime());
	}

	public void Initialize(GameObject flattenedGO)
	{
		meshRenderer = GetComponentInChildren<MeshRenderer>();
		meshFilter = GetComponentInChildren<MeshFilter>();
		rigidbody = GetComponent<Rigidbody>();
		animator = GetComponentInChildren<Animator>();
		flattenedObject = flattenedGO;
		if (flattenedGO != null)
		{
			meshToCopy = flattenedGO.GetComponentInChildren<MeshFilter>();
			rendererToCopy = flattenedGO.GetComponentInChildren<MeshRenderer>();
		}
		if (rendererToCopy != null && meshRenderer != null)
		{
			meshRenderer.sharedMaterial = rendererToCopy.sharedMaterial;
		}
		if (meshToCopy != null && meshFilter != null)
		{
			meshFilter.sharedMesh = meshToCopy.sharedMesh;
		}
		if (meshRenderer != null)
		{
			flatCollider = meshRenderer.transform.gameObject.AddComponent<BoxCollider>();
			Vector3 size = flatCollider.size;
			flatCollider.size = new Vector3(size.x, size.y + size.y, size.z);
			if (meshToCopy != null)
			{
				Vector3 lossyScale = meshToCopy.transform.lossyScale;
				meshRenderer.transform.localScale = new Vector3(lossyScale.x, 0.1f, lossyScale.z);
			}
		}
		if (flattenedObject != null)
		{
			flattenedObject.SetActive(false);
		}
	}

	private void Update()
	{
		if (flattenedObject != null && meshFilter != null)
		{
			flattenedObject.transform.position = meshFilter.transform.position;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || !other.CompareTag("Bat") || !startedShaking)
		{
			return;
		}
		StopAllCoroutines();
		if (animator != null)
		{
			animator.SetTrigger("Stop");
		}
		startedShaking = false;
		if (flatCollider != null)
		{
			Vector3 size = flatCollider.size;
			flatCollider.size = new Vector3(size.x, size.y + size.y, size.z);
		}
		if (meshRenderer != null && meshToCopy != null)
		{
			Vector3 lossyScale = meshToCopy.transform.lossyScale;
			meshRenderer.transform.localScale = new Vector3(lossyScale.x, 0.1f, lossyScale.z);
		}
		lifetimeCoroutine = StartCoroutine(FlatLifetime());
	}

	private void OnEnable()
	{
		if (lifetimeCoroutine != null)
		{
			StopAllCoroutines();
			lifetimeCoroutine = StartCoroutine(FlatLifetime());
		}
	}

	private IEnumerator FlatLifetime()
	{
		yield return new WaitForSeconds(lifeTime * 0.5f);
		startedShaking = true;
		if (animator != null)
		{
			animator.SetTrigger("Shaking");
		}
		yield return new WaitForSeconds(lifeTime * 0.5f);
		if (animator != null)
		{
			animator.SetTrigger("Revert");
		}
		if (flatCollider != null)
		{
			Vector3 size = flatCollider.size;
			flatCollider.size = new Vector3(size.x, size.y * 0.5f, size.z);
		}
		if (meshRenderer != null && meshToCopy != null)
		{
			meshRenderer.transform.localScale = meshToCopy.transform.lossyScale;
		}
		if (rigidbody != null)
		{
			rigidbody.AddForce(Vector3.up * 40f, ForceMode.VelocityChange);
			rigidbody.AddTorque(Vector3.one, ForceMode.VelocityChange);
		}
		yield return new WaitForSeconds(0.3f);
		RevertBackToNormal();
	}

	public void RevertBackToNormal()
	{
		if (flattenedObject != null)
		{
			Rigidbody componentInChildren = flattenedObject.GetComponentInChildren<Rigidbody>();
			flattenedObject.transform.rotation = base.transform.rotation;
			flattenedObject.SetActive(true);
			if (rigidbody != null && componentInChildren != null)
			{
				componentInChildren.velocity = rigidbody.velocity;
				componentInChildren.angularVelocity = rigidbody.angularVelocity;
			}
		}
		Object.Destroy(base.gameObject);
	}
}
