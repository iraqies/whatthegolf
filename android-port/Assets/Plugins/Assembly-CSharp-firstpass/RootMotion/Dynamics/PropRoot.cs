using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000119")]
	public class PropRoot : MonoBehaviour
	{
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody connectTo;

		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x28")]
		public Prop currentProp;

		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x30")]
		private Prop lastProp;

		[Token(Token = "0x4000690")]
		[FieldOffset(Offset = "0x38")]
		private bool fixedUpdateCalled;

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x13C3538", Offset = "0x13C3538", VA = "0x13C3538")]
		[Attribute(Name = "ContextMenu", RVA = "0x38814", Offset = "0x38814")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x13C3580", Offset = "0x13C3580", VA = "0x13C3580")]
		[Attribute(Name = "ContextMenu", RVA = "0x3884C", Offset = "0x3884C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x13C35C8", Offset = "0x13C35C8", VA = "0x13C35C8")]
		public void DropImmediate()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x13C44AC", Offset = "0x13C44AC", VA = "0x13C44AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x13C45A8", Offset = "0x13C45A8", VA = "0x13C45A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x13C46F4", Offset = "0x13C46F4", VA = "0x13C46F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x13C4944", Offset = "0x13C4944", VA = "0x13C4944")]
		private void AttachProp(Prop prop)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x13C5558", Offset = "0x13C5558", VA = "0x13C5558")]
		public PropRoot()
		{
		}
	}
}
