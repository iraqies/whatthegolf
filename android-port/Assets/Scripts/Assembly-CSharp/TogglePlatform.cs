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
	private float moveSpeed = 3f;

	[SerializeField]
	private float turnSpeed = 180f;

	private bool isToggled;

	private Transform _currentTarget;

	private void Awake()
	{
		_currentTarget = Position1;
		LockPosition();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			Toggle();
		}
	}

	public void Toggle()
	{
		bool flag = isToggled;
		isToggled = !flag;
		_currentTarget = (flag ? Position2 : Position1);
	}

	public void SetStatus(bool on)
	{
		isToggled = on;
		_currentTarget = (on ? Position1 : Position2);
	}

	private void FixedUpdate()
	{
		if (_currentTarget == null || MovableTransform == null)
		{
			return;
		}
		float num = Vector3.Distance(_currentTarget.position, MovableTransform.position);
		float num2 = Quaternion.Angle(_currentTarget.rotation, MovableTransform.rotation);
		if (num < 0.1f && Mathf.Abs(num2) < 0.5f)
		{
			LockPosition();
			return;
		}
		MovableTransform.position = Vector3.MoveTowards(MovableTransform.position, _currentTarget.position, moveSpeed * Time.fixedDeltaTime);
		MovableTransform.rotation = Quaternion.RotateTowards(MovableTransform.rotation, _currentTarget.rotation, turnSpeed * Time.fixedDeltaTime);
	}

	private void LockPosition()
	{
		if (_currentTarget != null && MovableTransform != null)
		{
			MovableTransform.position = _currentTarget.position;
			MovableTransform.rotation = _currentTarget.rotation;
		}
	}
}
