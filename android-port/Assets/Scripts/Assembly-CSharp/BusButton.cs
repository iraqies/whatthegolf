using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BusButton : MonoBehaviour
{
	public AudioClip sfxOnClick;

	[CompilerGenerated]
	private Action m_OnPressed;

	private Rigidbody rigid;

	private bool wasPressed;

	private FixedJoint joint;

	public event Action OnPressed
	{
		[CompilerGenerated]
		add
		{
			m_OnPressed = (Action)Delegate.Combine(m_OnPressed, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnPressed = (Action)Delegate.Remove(m_OnPressed, value);
		}
	}

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		joint = GetComponent<FixedJoint>();
	}

	public void OnCollisionEnter(Collision collision)
	{
		if (wasPressed || collision == null)
		{
			return;
		}
		if (collision.gameObject.GetComponentInParent<BusFightPlayer>() != null || collision.gameObject.CompareTag("Player"))
		{
			wasPressed = true;
			StartCoroutine(ClickButtonRoutine());
		}
	}

	public IEnumerator ClickButtonRoutine()
	{
		wasPressed = true;
		if (sfxOnClick != null)
		{
			AudioManager.PlaySFX(sfxOnClick, transform.position);
		}
		Vector3 startLocal = transform.localPosition;
		Vector3 endLocal = startLocal + Vector3.down * 0.25f;
		float t = 0f;
		while (t < 0.15f)
		{
			t += Time.deltaTime;
			transform.localPosition = Vector3.Lerp(startLocal, endLocal, t / 0.15f);
			yield return null;
		}
		transform.localPosition = endLocal;
		m_OnPressed?.Invoke();
	}
}
