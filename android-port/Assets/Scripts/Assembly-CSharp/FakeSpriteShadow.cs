using UnityEngine;

public class FakeSpriteShadow : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer shadowSprite;

	[SerializeField]
	private float maxDistance = 10f;

	private Vector3 _maxSize;

	private Transform _transform;

	private LayerMask groundLayerMask;

	private Transform _spriteTransform;

	private void Awake()
	{
		_transform = transform;
		groundLayerMask = 1 << LayerMask.NameToLayer("Ground");
		if (shadowSprite != null)
		{
			_spriteTransform = shadowSprite.transform;
			_maxSize = _spriteTransform.lossyScale;
			_spriteTransform.SetParent(null);
			_spriteTransform.rotation = Quaternion.LookRotation(Vector3.up, Vector3.up);
		}
	}

	private void OnDestroy()
	{
		if (shadowSprite != null)
		{
			Object.Destroy(shadowSprite.gameObject);
		}
	}

	private void OnDisable()
	{
		if (shadowSprite != null)
		{
			shadowSprite.gameObject.SetActive(false);
		}
	}

	private void OnEnable()
	{
		if (shadowSprite != null)
		{
			shadowSprite.gameObject.SetActive(true);
		}
	}

	private void FixedUpdate()
	{
		if (_spriteTransform == null || _transform == null)
		{
			return;
		}
		if (Physics.Raycast(_transform.position, Vector3.down, out RaycastHit hit, maxDistance, groundLayerMask))
		{
			float t = Mathf.Clamp01(hit.distance / Mathf.Max(0.01f, maxDistance));
			_spriteTransform.position = hit.point + Vector3.up * 0.02f;
			_spriteTransform.localScale = Vector3.Lerp(_maxSize, Vector3.zero, t);
		}
		else
		{
			_spriteTransform.localScale = Vector3.zero;
		}
	}
}
