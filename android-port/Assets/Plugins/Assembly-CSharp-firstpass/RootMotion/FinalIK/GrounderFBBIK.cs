using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000145")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000146")]
		public class SpineEffector
		{
			[Token(Token = "0x40007D2")]
			[FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007D3")]
			[FieldOffset(Offset = "0x14")]
			public float horizontalWeight;

			[Token(Token = "0x40007D4")]
			[FieldOffset(Offset = "0x18")]
			public float verticalWeight;

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x133B048", Offset = "0x133B048", VA = "0x133B048")]
			public SpineEffector()
			{
			}
		}

		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x40")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x48")]
		public float spineBend;

		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x4C")]
		public float spineSpeed;

		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x137BD50", Offset = "0x137BD50", VA = "0x137BD50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x390BC", Offset = "0x390BC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x137BD98", Offset = "0x137BD98", VA = "0x137BD98", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x390F4", Offset = "0x390F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x137BDE0", Offset = "0x137BDE0", VA = "0x137BDE0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3912C", Offset = "0x3912C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x137BE28", Offset = "0x137BE28", VA = "0x137BE28", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x137BE68", Offset = "0x137BE68", VA = "0x137BE68")]
		private bool IsReadyToInitiate()
		{
			return default;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x137BF10", Offset = "0x137BF10", VA = "0x137BF10")]
		private void Update()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x137C198", Offset = "0x137C198", VA = "0x137C198")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x137C1A4", Offset = "0x137C1A4", VA = "0x137C1A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x137BF78", Offset = "0x137BF78", VA = "0x137BF78")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x137C1B0", Offset = "0x137C1B0", VA = "0x137C1B0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x137C4F4", Offset = "0x137C4F4", VA = "0x137C4F4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x137C614", Offset = "0x137C614", VA = "0x137C614")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x137C774", Offset = "0x137C774", VA = "0x137C774")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x137C89C", Offset = "0x137C89C", VA = "0x137C89C")]
		public GrounderFBBIK()
		{
		}
	}
}
