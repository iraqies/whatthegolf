using CameraStack;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GyroMenu : MonoBehaviour
{
	private CBPerspecitveGyroscope gyro;

	[SerializeField]
	private TextMeshProUGUI title;

	[SerializeField]
	private TextMeshProUGUI titleShadow;

	[SerializeField]
	private TextMeshProUGUI helpText;

	[SerializeField]
	private Transform gyroArm;

	[SerializeField]
	private Transform content;

	[SerializeField]
	private string upTitle;

	[SerializeField]
	private string downTitle;

	[SerializeField]
	private string downHelp;

	[SerializeField]
	private string midwayHelp;

	[SerializeField]
	private string upHelp;

	[SerializeField]
	private float contentMoveOffset;

	[SerializeField]
	private UnityEvent onSuccess;

	[SerializeField]
	private UnityEvent onFail;

	private Vector3 contentStartPos;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
