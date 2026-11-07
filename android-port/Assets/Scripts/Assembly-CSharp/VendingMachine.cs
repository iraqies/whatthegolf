using System.Collections;
using Audio;
using UnityEngine;

public class VendingMachine : MonoBehaviour
{
	public GameObject[] EjectableFoodPrefabs;

	public float EjectForce;

	public float EjectForceAngular;

	private bool onCooldown;

	public float FoodDecayTime;

	public SpriteRenderer KeypadSuccessRenderer;

	public int FoodLeft;

	public Transform FoodEjectPosition;

	[SerializeField]
	private AudioEventAsset clickBeepSFX;

	[SerializeField]
	private AudioEventAsset ejectionSFX;

	[SerializeField]
	private AudioEventAsset foodOutSFX;

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private IEnumerator FoodEjectionRoutine()
	{
		return null;
	}

	private void PlaySFX(AudioEventAsset _event)
	{
	}

	private void EjectFood()
	{
	}
}
