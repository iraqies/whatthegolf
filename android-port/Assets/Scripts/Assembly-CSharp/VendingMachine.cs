using System.Collections;
using Audio;
using UnityEngine;

public class VendingMachine : MonoBehaviour
{
	public GameObject[] EjectableFoodPrefabs;

	public float EjectForce;

	public float EjectForceAngular;

	private bool onCooldown;

	public float FoodDecayTime = 20f;

	public SpriteRenderer KeypadSuccessRenderer;

	public int FoodLeft = 10;

	public Transform FoodEjectPosition;

	[SerializeField]
	private AudioEventAsset clickBeepSFX;

	[SerializeField]
	private AudioEventAsset ejectionSFX;

	[SerializeField]
	private AudioEventAsset foodOutSFX;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.rigidbody == null)
		{
			return;
		}
		bool isPlayerBall = OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null && OverworldBallManager.Instance.Ball.Controller != null && collision.rigidbody == OverworldBallManager.Instance.Ball.Controller.rigid2D;
		if (!isPlayerBall && !collision.gameObject.CompareTag("Player"))
		{
			return;
		}
		if (onCooldown)
		{
			return;
		}
		int remaining = FoodLeft - 1;
		if (remaining < 0)
		{
			return;
		}
		FoodLeft = remaining;
		onCooldown = true;
		StartCoroutine(FoodEjectionRoutine());
	}

	private IEnumerator FoodEjectionRoutine()
	{
		if (KeypadSuccessRenderer != null)
			KeypadSuccessRenderer.enabled = true;
		PlaySFX(clickBeepSFX);
		yield return new WaitForSeconds(0.25f);
		if (KeypadSuccessRenderer != null)
			KeypadSuccessRenderer.enabled = false;
		PlaySFX(ejectionSFX);
		yield return new WaitForSeconds(0.25f);
		if (KeypadSuccessRenderer != null)
			KeypadSuccessRenderer.enabled = true;
		PlaySFX(foodOutSFX);
		EjectFood();
		yield return new WaitForSeconds(0.5f);
		if (KeypadSuccessRenderer != null)
			KeypadSuccessRenderer.enabled = false;
		onCooldown = false;
	}

	private void PlaySFX(AudioEventAsset _event)
	{
		if (_event != null)
		{
			_event.Play(transform.position, 1f, 1f, false);
		}
	}

	private void EjectFood()
	{
		if (EjectableFoodPrefabs == null || EjectableFoodPrefabs.Length == 0 || FoodEjectPosition == null)
		{
			return;
		}
		GameObject prefab = EjectableFoodPrefabs[Random.Range(0, EjectableFoodPrefabs.Length)];
		if (prefab == null) return;
		GameObject inst = Instantiate(prefab, FoodEjectPosition.position, FoodEjectPosition.rotation);
		Rigidbody2D rb = inst.GetComponent<Rigidbody2D>();
		if (rb != null)
		{
			rb.AddForce(-(Vector2)FoodEjectPosition.up * EjectForce, ForceMode2D.Impulse);
			rb.AddTorque(Random.Range(-EjectForceAngular, EjectForceAngular), ForceMode2D.Impulse);
		}
	}
}
