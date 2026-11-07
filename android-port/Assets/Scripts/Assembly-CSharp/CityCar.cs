using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CityCar : MonoBehaviour
{
	[SerializeField]
	private float speed;

	[SerializeField]
	private LayerMask crashWithLayer;

	[SerializeField]
	private bool changeLayerOnCrash;

	[SerializeField]
	private int changeToLayer;

	private Rigidbody _rigidbody;

	[CompilerGenerated]
	private Action<CityCar> m_OnEnterEnd;

	[CompilerGenerated]
	private Action<CityCar> m_OnCrash;

	public bool Crashed { get; private set; }

	public Collider EnterCollider { get; set; }

	public Collider ExitCollider { get; set; }

	public event Action<CityCar> OnEnterEnd
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

	public event Action<CityCar> OnCrash
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

	public void Init(Collider enter, Collider exit)
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
