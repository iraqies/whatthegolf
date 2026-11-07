using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SneakTreeForLaser : MonoBehaviour
{
	[SerializeField]
	private Animation _animation;

	[SerializeField]
	private AnimationClip _walk;

	[SerializeField]
	private AnimationClip _still;

	[SerializeField]
	private GameObject _arms;

	[SerializeField]
	private float _speed;

	[SerializeField]
	private List<Transform> _positions;

	[SerializeField]
	private UnityEvent _OnLasered;

	[SerializeField]
	private AudioSource _audio;

	private int index;

	private bool _moving;

	private bool _canMove;

	private void Start()
	{
	}

	private void OnLasered()
	{
	}

	public void Move()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnDrawGizmos()
	{
	}

	private IEnumerator MoveCR()
	{
		return null;
	}
}
