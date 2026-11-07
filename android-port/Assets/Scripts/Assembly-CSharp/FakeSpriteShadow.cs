using UnityEngine;

public class FakeSpriteShadow : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer shadowSprite;

	[SerializeField]
	private float maxDistance;

	private Vector3 _maxSize;

	private Transform _transform;

	private LayerMask groundLayerMask;

	private Transform _spriteTransform;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}
}
