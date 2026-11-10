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
		if (_walk != null && _animation != null && _animation[_walk.name] != null)
		{
			_animation[_walk.name].speed = 4f;
		}
		if (_animation != null)
		{
			_animation.Play();
		}
		if (_still != null && _animation != null)
		{
			_animation.CrossFade(_still.name, 0.1f);
		}
		if (_arms != null)
		{
			_arms.SetActive(value: false);
		}
		_moving = false;
		if (_audio != null)
		{
			_audio.Stop();
		}
		LaserSentryTarget component = GetComponent<LaserSentryTarget>();
		if (component != null)
		{
			component.OnLasered += OnLasered;
		}
	}

	private void OnLasered()
	{
		_moving = false;
		_canMove = false;
		Rigidbody component = GetComponent<Rigidbody>();
		if (component != null)
		{
			component.constraints = RigidbodyConstraints.None;
		}
		if (_animation != null)
		{
			_animation.Stop();
		}
		StopAllCoroutines();
		_OnLasered?.Invoke();
		if (_audio != null)
		{
			_audio.Stop();
		}
	}

	public void Move()
	{
		if (_canMove && !_moving)
		{
			_moving = true;
			StartCoroutine(MoveCR());
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.attachedRigidbody != null && other.attachedRigidbody.CompareTag("Player") && _canMove && !_moving)
		{
			_moving = true;
			StartCoroutine(MoveCR());
		}
	}

	private void OnDrawGizmos()
	{
		if (_positions == null)
		{
			return;
		}
		foreach (Transform position in _positions)
		{
			if (position != null)
			{
				Gizmos.DrawSphere(position.position, 1f);
			}
		}
	}

	private IEnumerator MoveCR()
	{
		if (_audio != null)
		{
			_audio.Play();
		}
		_moving = true;
		if (_arms != null)
		{
			_arms.SetActive(value: true);
		}
		if (_walk != null && _animation != null)
		{
			_animation.CrossFade(_walk.name, 0.1f);
		}
		double elapsed = 0.0;
		Vector3 startPos = base.transform.position;
		Vector3 endPos = ((_positions != null && index < _positions.Count && _positions[index] != null) ? _positions[index].position : startPos);
		while (elapsed < 1.0)
		{
			base.transform.position = Vector3.Lerp(startPos, endPos, Mathf.Clamp01((float)elapsed));
			elapsed += (double)(Time.fixedDeltaTime * _speed);
			yield return new WaitForFixedUpdate();
		}
		if (_positions != null && _positions.Count > 0)
		{
			index = (index + 1) % _positions.Count;
		}
		if (_still != null && _animation != null)
		{
			_animation.CrossFade(_still.name, 0.1f);
		}
		if (_arms != null)
		{
			_arms.SetActive(value: false);
		}
		_moving = false;
		if (_audio != null)
		{
			_audio.Stop();
		}
	}

	public SneakTreeForLaser()
	{
		_canMove = true;
	}
}
