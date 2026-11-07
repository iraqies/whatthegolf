using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000237")]
	public class Grab : MonoBehaviour
	{
		[Token(Token = "0x4000E7A")]
		[FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000E7B")]
		[FieldOffset(Offset = "0x20")]
		public UserControlMelee userControl;

		[Token(Token = "0x4000E7C")]
		[FieldOffset(Offset = "0x28")]
		public int grabLayer;

		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0x2C")]
		private bool grabbed;

		[Token(Token = "0x4000E7E")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0x38")]
		private Collider c;

		[Token(Token = "0x4000E80")]
		[FieldOffset(Offset = "0x40")]
		private BehaviourPuppet otherPuppet;

		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0x48")]
		private Collider otherCollider;

		[Token(Token = "0x4000E82")]
		[FieldOffset(Offset = "0x50")]
		private ConfigurableJoint joint;

		[Token(Token = "0x4000E83")]
		[FieldOffset(Offset = "0x58")]
		private float nextGrabTime;

		[Token(Token = "0x4000E84")]
		private const float massMlp = 5f;

		[Token(Token = "0x4000E85")]
		private const int solverIterationMlp = 10;

		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x1378204", Offset = "0x1378204", VA = "0x1378204")]
		private void Start()
		{
		}

		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x1378284", Offset = "0x1378284", VA = "0x1378284")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x1378660", Offset = "0x1378660", VA = "0x1378660")]
		private void Update()
		{
		}

		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x1378794", Offset = "0x1378794", VA = "0x1378794")]
		public Grab()
		{
		}
	}
}
