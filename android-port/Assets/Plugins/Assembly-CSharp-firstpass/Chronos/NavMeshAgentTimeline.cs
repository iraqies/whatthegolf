using Il2CppDummyDll;
using UnityEngine.AI;

namespace Chronos
{
	[Token(Token = "0x20002B2")]
	public class NavMeshAgentTimeline : ComponentTimeline<NavMeshAgent>
	{
		[Token(Token = "0x400117F")]
		[FieldOffset(Offset = "0x20")]
		private float _speed;

		[Token(Token = "0x4001180")]
		[FieldOffset(Offset = "0x24")]
		private float _angularSpeed;

		[Token(Token = "0x17000245")]
		public float speed
		{
			[Token(Token = "0x6001211")]
			[Address(RVA = "0x13B9F9C", Offset = "0x13B9F9C", VA = "0x13B9F9C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000246")]
		public float angularSpeed
		{
			[Token(Token = "0x6001212")]
			[Address(RVA = "0x13B9FA4", Offset = "0x13B9FA4", VA = "0x13B9FA4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001213")]
		[Address(RVA = "0x13B9FAC", Offset = "0x13B9FAC", VA = "0x13B9FAC")]
		public NavMeshAgentTimeline(Timeline timeline, NavMeshAgent component)
		{
		}

		[Token(Token = "0x6001214")]
		[Address(RVA = "0x13BA01C", Offset = "0x13BA01C", VA = "0x13BA01C", Slot = "13")]
		public override void Update()
		{
		}

		[Token(Token = "0x6001215")]
		[Address(RVA = "0x13BA0AC", Offset = "0x13BA0AC", VA = "0x13BA0AC", Slot = "16")]
		public override void CopyProperties(NavMeshAgent source)
		{
		}

		[Token(Token = "0x6001216")]
		[Address(RVA = "0x13BA0F4", Offset = "0x13BA0F4", VA = "0x13BA0F4", Slot = "17")]
		public override void AdjustProperties(float timeScale)
		{
		}
	}
}
