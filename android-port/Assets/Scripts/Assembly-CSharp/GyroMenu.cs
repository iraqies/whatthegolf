using CameraStack;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20008DF")]
public class GyroMenu : MonoBehaviour
{
	[Token(Token = "0x4003082")]
	[FieldOffset(Offset = "0x18")]
	private CBPerspecitveGyroscope gyro;

	[Token(Token = "0x4003083")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI title;

	[Token(Token = "0x4003084")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI titleShadow;

	[Token(Token = "0x4003085")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI helpText;

	[Token(Token = "0x4003086")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform gyroArm;

	[Token(Token = "0x4003087")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform content;

	[Token(Token = "0x4003088")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string upTitle;

	[Token(Token = "0x4003089")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string downTitle;

	[Token(Token = "0x400308A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string downHelp;

	[Token(Token = "0x400308B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string midwayHelp;

	[Token(Token = "0x400308C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private string upHelp;

	[Token(Token = "0x400308D")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float contentMoveOffset;

	[Token(Token = "0x400308E")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UnityEvent onSuccess;

	[Token(Token = "0x400308F")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UnityEvent onFail;

	[Token(Token = "0x4003090")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 contentStartPos;

	[Token(Token = "0x6002908")]
	[Address(RVA = "0x14C03D8", Offset = "0x14C03D8", VA = "0x14C03D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002909")]
	[Address(RVA = "0x14C04DC", Offset = "0x14C04DC", VA = "0x14C04DC")]
	private void Update()
	{
	}

	[Token(Token = "0x600290A")]
	[Address(RVA = "0x14C088C", Offset = "0x14C088C", VA = "0x14C088C")]
	public GyroMenu()
	{
	}
}
