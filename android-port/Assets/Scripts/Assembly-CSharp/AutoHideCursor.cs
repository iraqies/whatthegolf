using UnityEngine;

public class AutoHideCursor : MonoBehaviour
{
	[SerializeField]
	private float timeBeforeHide;

	[SerializeField]
	private bool hidden;

	private float timer;

	private Vector3 mousePosLastFrame;

	private bool updatePosition;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Toggle(bool isVisible)
	{
	}
}
