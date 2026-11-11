using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceOnEnable2D : MonoBehaviour
{
	public Rigidbody2D rigid;

	public List<AudioClip> clips;

	public float Delay = 0.3f;

	public Vector3 Force = new Vector3(3f, 20f, 0f);

	public float Torque = 1f;

	private Vector3 position;

	private Quaternion rotation;

	private void Awake()
	{
		position = base.transform.position;
		rotation = base.transform.rotation;
	}

	private void OnEnable()
	{
		if (rigid != null)
		{
			StartCoroutine(PopToast());
		}
	}

	private IEnumerator PopToast()
	{
		rigid.simulated = false;
		base.transform.position = position;
		base.transform.rotation = rotation;
		rigid.velocity = Vector2.zero;
		rigid.angularVelocity = 0f;
		yield return new WaitForSeconds(Delay);
		rigid.simulated = true;
		rigid.AddForce(Force, ForceMode2D.Impulse);
		rigid.AddTorque(Torque, ForceMode2D.Impulse);
		AudioManager.Instance.sfx.Play(clips);
	}
}
