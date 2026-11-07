using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI
{
	[Token(Token = "0x200117B")]
	[Attribute(Name = "RequireComponent", RVA = "0x4805C", Offset = "0x4805C")]
	public class ControllerUIEffect : MonoBehaviour
	{
		[Token(Token = "0x4005C6D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _highlightColor;

		[Token(Token = "0x4005C6E")]
		[FieldOffset(Offset = "0x28")]
		private Image _image;

		[Token(Token = "0x4005C6F")]
		[FieldOffset(Offset = "0x30")]
		private Color _color;

		[Token(Token = "0x4005C70")]
		[FieldOffset(Offset = "0x40")]
		private Color _origColor;

		[Token(Token = "0x4005C71")]
		[FieldOffset(Offset = "0x50")]
		private bool _isActive;

		[Token(Token = "0x4005C72")]
		[FieldOffset(Offset = "0x54")]
		private float _highlightAmount;

		[Token(Token = "0x6004FEC")]
		[Address(RVA = "0x18B9724", Offset = "0x18B9724", VA = "0x18B9724")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004FED")]
		[Address(RVA = "0x18B97A8", Offset = "0x18B97A8", VA = "0x18B97A8")]
		public void Activate(float amount)
		{
		}

		[Token(Token = "0x6004FEE")]
		[Address(RVA = "0x18B98AC", Offset = "0x18B98AC", VA = "0x18B98AC")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x6004FEF")]
		[Address(RVA = "0x18B985C", Offset = "0x18B985C", VA = "0x18B985C")]
		private void RedrawImage()
		{
		}

		[Token(Token = "0x6004FF0")]
		[Address(RVA = "0x18B9924", Offset = "0x18B9924", VA = "0x18B9924")]
		public ControllerUIEffect()
		{
		}
	}
}
