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
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void OnCollisionEnter(Collision collision)
	{
	}

	public IEnumerator ClickButtonRoutine()
	{
		return null;
	}
}
