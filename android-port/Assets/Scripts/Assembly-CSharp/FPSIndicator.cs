using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20008E0")]
public class FPSIndicator : MonoBehaviour
{
	[Token(Token = "0x4003091")]
	[FieldOffset(Offset = "0x18")]
	public Image Indicator;

	[Token(Token = "0x4003092")]
	[FieldOffset(Offset = "0x20")]
	public Canvas Canvas;

	[Token(Token = "0x4003093")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI fpsText;

	[Token(Token = "0x4003094")]
	[FieldOffset(Offset = "0x30")]
	private float deltaTime;

	[Token(Token = "0x4003095")]
	[FieldOffset(Offset = "0x34")]
	private float holdTimer;

	[Token(Token = "0x4003096")]
	[FieldOffset(Offset = "0x38")]
	private float frameCount;

	[Token(Token = "0x4003097")]
	[FieldOffset(Offset = "0x3C")]
	private float dt;

	[Token(Token = "0x4003098")]
	[FieldOffset(Offset = "0x40")]
	private float fps;

	[Token(Token = "0x4003099")]
	[FieldOffset(Offset = "0x44")]
	private float updateRate;

	[Token(Token = "0x600290B")]
	[Address(RVA = "0x1459DE4", Offset = "0x1459DE4", VA = "0x1459DE4")]
	private void Update()
	{
	}

	[Token(Token = "0x600290C")]
	[Address(RVA = "0x1459FA8", Offset = "0x1459FA8", VA = "0x1459FA8")]
	private bool CheckFps(float fps, int from, int to, Color color)
	{
		return default;
	}

	[Token(Token = "0x600290D")]
	[Address(RVA = "0x145A010", Offset = "0x145A010", VA = "0x145A010")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600290E")]
	[Address(RVA = "0x145A030", Offset = "0x145A030", VA = "0x145A030")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600290F")]
	[Address(RVA = "0x145A050", Offset = "0x145A050", VA = "0x145A050")]
	public void EnableIndicator()
	{
	}

	[Token(Token = "0x6002910")]
	[Address(RVA = "0x145A080", Offset = "0x145A080", VA = "0x145A080")]
	public void DisableIndicator()
	{
	}

	[Token(Token = "0x6002911")]
	[Address(RVA = "0x145A0B0", Offset = "0x145A0B0", VA = "0x145A0B0")]
	public void SetActiveIndicator(bool enable)
	{
	}

	[Token(Token = "0x6002912")]
	[Address(RVA = "0x145A0FC", Offset = "0x145A0FC", VA = "0x145A0FC")]
	public FPSIndicator()
	{
	}
}
