using System.Collections.Generic;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200135E")]
	public class ImpactSFXPuppetMaster : ImpactUser
	{
		[Token(Token = "0x40067AE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PuppetMaster puppetMaster;

		[Token(Token = "0x40067AF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Muscle.Group> muscleGroups;

		[Token(Token = "0x6005A56")]
		[Address(RVA = "0x14E7B34", Offset = "0x14E7B34", VA = "0x14E7B34")]
		private void Start()
		{
		}

		[Token(Token = "0x6005A57")]
		[Address(RVA = "0x14E7C58", Offset = "0x14E7C58", VA = "0x14E7C58")]
		private void OnMuscleCollision(MuscleCollision colData)
		{
		}

		[Token(Token = "0x6005A58")]
		[Address(RVA = "0x14E7E90", Offset = "0x14E7E90", VA = "0x14E7E90")]
		public ImpactSFXPuppetMaster()
		{
		}
	}
}
