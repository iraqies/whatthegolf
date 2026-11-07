using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000542")]
public class TutorialManball : MonoBehaviour
{
	[Token(Token = "0x4001B38")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SpeechBubble _bubble;

	[Token(Token = "0x4001B39")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GolfBallController _ball;

	[Token(Token = "0x4001B3A")]
	[FieldOffset(Offset = "0x28")]
	private int _shotCount;

	[Token(Token = "0x4001B3B")]
	[FieldOffset(Offset = "0x2C")]
	private float _noActionDuration;

	[Token(Token = "0x4001B3C")]
	[FieldOffset(Offset = "0x30")]
	private bool _shown;

	[Token(Token = "0x4001B3D")]
	[FieldOffset(Offset = "0x34")]
	private float _shownTime;

	[Token(Token = "0x4001B3E")]
	private const float INACTIVE_DURATION = 10f;

	[Token(Token = "0x6001810")]
	[Address(RVA = "0x1733DA0", Offset = "0x1733DA0", VA = "0x1733DA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001811")]
	[Address(RVA = "0x1733E50", Offset = "0x1733E50", VA = "0x1733E50")]
	private void OnShoot(Vector3 aim)
	{
	}

	[Token(Token = "0x6001812")]
	[Address(RVA = "0x1733F7C", Offset = "0x1733F7C", VA = "0x1733F7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6001813")]
	[Address(RVA = "0x1734014", Offset = "0x1734014", VA = "0x1734014")]
	public TutorialManball()
	{
	}
}
