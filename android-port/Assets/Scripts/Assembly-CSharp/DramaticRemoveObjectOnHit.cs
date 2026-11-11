using CameraStack;
using UnityEngine;

public class DramaticRemoveObjectOnHit : MonoBehaviour
{
	public Vector2 DisappearDirection = new Vector2(1f, 0f);

	public LayerMask ValidObjects;

	public float DisappearSpeed = 10f;

	public float DisappearDuration = 1f;

	private bool isDisappearing;

	private Rigidbody2D rigid;

	private float timer;

	private void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		if (isDisappearing)
		{
			timer += Time.deltaTime;
			if (timer >= DisappearDuration)
			{
				isDisappearing = false;
				base.enabled = false;
			}
		}
	}

	private void FixedUpdate()
	{
		if (isDisappearing && rigid != null)
		{
			rigid.MovePosition(rigid.position + DisappearDirection * DisappearSpeed * Time.fixedDeltaTime);
			timer += Time.deltaTime;
		}
	}

	private void ObjectHit(GameObject hit)
	{
		if (isDisappearing || !base.enabled || hit == null)
		{
			return;
		}
		int num = ValidObjects;
		if (num == (num | (1 << hit.layer)))
		{
			isDisappearing = true;
			if (CameraManager.Instance != null)
			{
				CameraManager.Instance.Shake(DisappearDuration, 5f, 2f);
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col != null)
		{
			ObjectHit(col.gameObject);
		}
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col != null)
		{
			ObjectHit(col.gameObject);
		}
	}
}
