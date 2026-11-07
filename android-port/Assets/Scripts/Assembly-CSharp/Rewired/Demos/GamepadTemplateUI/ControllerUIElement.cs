using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI
{
	[Token(Token = "0x200117C")]
	[Attribute(Name = "RequireComponent", RVA = "0x480C4", Offset = "0x480C4")]
	public class ControllerUIElement : MonoBehaviour
	{
		[Token(Token = "0x4005C73")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _highlightColor;

		[Token(Token = "0x4005C74")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ControllerUIEffect _positiveUIEffect;

		[Token(Token = "0x4005C75")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ControllerUIEffect _negativeUIEffect;

		[Token(Token = "0x4005C76")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _label;

		[Token(Token = "0x4005C77")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _positiveLabel;

		[Token(Token = "0x4005C78")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _negativeLabel;

		[Token(Token = "0x4005C79")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ControllerUIElement[] _childElements;

		[Token(Token = "0x4005C7A")]
		[FieldOffset(Offset = "0x58")]
		private Image _image;

		[Token(Token = "0x4005C7B")]
		[FieldOffset(Offset = "0x60")]
		private Color _color;

		[Token(Token = "0x4005C7C")]
		[FieldOffset(Offset = "0x70")]
		private Color _origColor;

		[Token(Token = "0x4005C7D")]
		[FieldOffset(Offset = "0x80")]
		private bool _isActive;

		[Token(Token = "0x4005C7E")]
		[FieldOffset(Offset = "0x84")]
		private float _highlightAmount;

		[Token(Token = "0x17000899")]
		private bool hasEffects
		{
			[Token(Token = "0x6004FF1")]
			[Address(RVA = "0x18B9958", Offset = "0x18B9958", VA = "0x18B9958")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004FF2")]
		[Address(RVA = "0x18B9A20", Offset = "0x18B9A20", VA = "0x18B9A20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004FF3")]
		[Address(RVA = "0x18B9CD8", Offset = "0x18B9CD8", VA = "0x18B9CD8")]
		public void Activate(float amount)
		{
		}

		[Token(Token = "0x6004FF4")]
		[Address(RVA = "0x18B9F48", Offset = "0x18B9F48", VA = "0x18B9F48")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x6004FF5")]
		[Address(RVA = "0x18BA19C", Offset = "0x18BA19C", VA = "0x18BA19C")]
		public void SetLabel(string text, AxisRange labelType)
		{
		}

		[Token(Token = "0x6004FF6")]
		[Address(RVA = "0x18B9AA8", Offset = "0x18B9AA8", VA = "0x18B9AA8")]
		public void ClearLabels()
		{
		}

		[Token(Token = "0x6004FF7")]
		[Address(RVA = "0x18B9F18", Offset = "0x18B9F18", VA = "0x18B9F18")]
		private void RedrawImage()
		{
		}

		[Token(Token = "0x6004FF8")]
		[Address(RVA = "0x18BA344", Offset = "0x18BA344", VA = "0x18BA344")]
		public ControllerUIElement()
		{
		}
	}
}
