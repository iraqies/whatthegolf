using System.Collections;
using Audio;
using UnityEngine;

public class FishStickSpawnOnColision : MonoBehaviour
{
	public GameObject[] EjectableFoodPrefabs;

	public float EjectForce;

	public float EjectForceAngular;

	private bool onCooldown;

	public float FoodDecayTime = 20f;

	public int FoodLeft = 10;

	[SerializeField]
	private float SpawnDelay;

	public Transform FoodEjectPosition;

	[SerializeField]
	private AudioEventAsset clickBeepSFX;

	[SerializeField]
	private AudioEventAsset ejectionSFX;

	[SerializeField]
	private AudioEventAsset foodOutSFX;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.rigidbody != null && collision.rigidbody == OverworldBallManager.Instance.Ball.rigidBody && collision.gameObject.CompareTag("Player") && !onCooldown && --FoodLeft >= 0)
		{
			onCooldown = true;
			StartCoroutine(FoodEjectionRoutine());
		}
	}

	private IEnumerator FoodEjectionRoutine()
	{
		PlaySFX(clickBeepSFX);
		yield return new WaitForSeconds(SpawnDelay);
		PlaySFX(ejectionSFX);
		yield return new WaitForSeconds(SpawnDelay);
		PlaySFX(foodOutSFX);
		EjectFood();
		yield return new WaitForSeconds(0.5f);
		onCooldown = false;
	}

	private void PlaySFX(AudioEventAsset _event)
	{
		if (_event != null)
		{
			_event.Play(base.transform.position);
		}
	}

	private void EjectFood()
	{
		Rigidbody2D component = Object.Instantiate(EjectableFoodPrefabs[Random.Range(0, EjectableFoodPrefabs.Length)], FoodEjectPosition.position, FoodEjectPosition.rotation).GetComponent<Rigidbody2D>();
		component.AddForce(-FoodEjectPosition.up * EjectForce, ForceMode2D.Impulse);
		component.AddTorque(Random.Range(0f - EjectForceAngular, EjectForceAngular), ForceMode2D.Impulse);
	}
}
