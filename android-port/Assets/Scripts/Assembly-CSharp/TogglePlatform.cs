using UnityEngine;

public class TogglePlatform : MonoBehaviour
{
	[SerializeField]
	private Transform Position1;

	[SerializeField]
	private Transform Position2;

	[SerializeField]
	private Transform MovableTransform;

	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private float turnSpeed;

	private bool isToggled;

	private Transform _currentTarget;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Toggle()
	{
	}

	public void SetStatus(bool on)
	{
	}

	private void FixedUpdate()
	{
	}

	private void LockPosition()
	{
	}
}
