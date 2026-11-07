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
	}

	public void Initialize(GameObject flattenedGO)
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator FlatLifetime()
	{
		return null;
	}

	public void RevertBackToNormal()
	{
	}
}
