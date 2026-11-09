using System.Collections;
using Core;
using UnityEngine;

public class ExplosionBarrelHelper : MonoBehaviour, IExplodable
{
	public bool stopWhileAiming = true;

	private ExplosionBarrel barrel;
	private GolfBallController controller;
	private GolfBallShooterExperimental shooter;
	private Rigidbody rigid;
	private float startDrag;
	private bool didExplode;

	private void Start()
	{
		controller = GetComponent<GolfBallController>();
		barrel = GetComponent<ExplosionBarrel>();
		rigid = GetComponent<Rigidbody>();
		shooter = GetComponent<GolfBallShooterExperimental>();
		if (rigid != null)
			startDrag = rigid.drag;
	}

	private void FixedUpdate()
	{
		if (controller == null) return;
		if (controller.IsAiming && !controller.BlockShooting && controller.IsGrounded)
		{
			if (stopWhileAiming && rigid != null)
			{
				rigid.drag = 100f;
				rigid.angularVelocity = Vector3.zero;
			}
		}
		else if (!didExplode && rigid != null)
		{
			rigid.drag = startDrag;
		}
	}

	public void OnExplode() => Explode();

	public void Explode()
	{
		if (didExplode) return;
		didExplode = true;
		if (barrel != null)
		{
			barrel.canExplode = true;
			barrel.Explode(null);
		}
		StartCoroutine(Boom());
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (didExplode || barrel == null || collision == null || collision.collider == null) return;
		int mask = barrel.ignoreLayers.value;
		if ((mask & (1 << collision.collider.gameObject.layer)) != 0)
			return;
		var contacts = collision.contacts;
		if (contacts != null && contacts.Length > 0)
		{
			if (Vector3.Angle(contacts[0].normal, Vector3.up) > 50f && Vector3.Angle(-collision.relativeVelocity, Vector3.up) > 50f)
				Explode();
		}
	}

	private IEnumerator Boom()
	{
		if (shooter != null) shooter.enabled = false;
		if (controller != null) controller.enabled = false;
		if (rigid != null) rigid.drag = 8f;
		yield return new WaitForSeconds(0.1f);
		if (rigid != null) rigid.drag = 0.5f;
		yield return new WaitForSeconds(1.5f);
		if (Level.HasInstance)
			Level.Instance.Restart();
	}
}
