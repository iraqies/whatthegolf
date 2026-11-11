using System.Collections;
using Audio;
using Core;
using UnityEngine;

public class ExplosionWindmill : MonoBehaviour
{
	public ExplosionBarrel barrel;

	public Rigidbody wings;

	public Rigidbody main;

	public Collider mainCollider;

	public RotateAxis rotator;

	public ClipSettingsCollection explosionSweetenerSFX;

	public bool failLevelOnExplode;

	private float delayTimer = 5f;

	private GolfBallController controller;

	private void Start()
	{
		barrel.OnExplode += Barrel_OnExplode;
	}

	private void Barrel_OnExplode(Collider arg1, ExplosionBarrel arg2)
	{
		explosionSweetenerSFX.Play(base.transform.position, 1f, 1f);
		main.isKinematic = false;
		wings.isKinematic = false;
		rotator.enabled = false;
		mainCollider.isTrigger = false;
		wings.transform.SetParent(main.transform.parent, true);
		wings.AddTorque(wings.transform.forward * 500f, ForceMode.Acceleration);
		wings.AddForce(base.transform.forward * 150f + Vector3.up * 50f, ForceMode.Acceleration);
		main.AddForce(base.transform.forward * 20f + Vector3.up * 70f, ForceMode.Acceleration);
		if (failLevelOnExplode)
		{
			StartCoroutine(Boom());
		}
	}

	private IEnumerator Boom()
	{
		yield return new WaitForSeconds(0.6f);
		Level.Instance.Fail(true, true, null, 1.5f, true, "");
	}
}
