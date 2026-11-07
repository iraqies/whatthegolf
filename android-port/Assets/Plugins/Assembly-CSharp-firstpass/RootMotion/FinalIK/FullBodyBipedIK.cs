using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000154")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x1373A80", Offset = "0x1373A80", VA = "0x1373A80", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x39984", Offset = "0x39984")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1373AC8", Offset = "0x1373AC8", VA = "0x1373AC8", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x399BC", Offset = "0x399BC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x1373B10", Offset = "0x1373B10", VA = "0x1373B10")]
		[Attribute(Name = "ContextMenu", RVA = "0x399F4", Offset = "0x399F4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x1373B58", Offset = "0x1373B58", VA = "0x1373B58")]
		[Attribute(Name = "ContextMenu", RVA = "0x39A2C", Offset = "0x39A2C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x1373BA0", Offset = "0x1373BA0", VA = "0x1373BA0")]
		[Attribute(Name = "ContextMenu", RVA = "0x39A64", Offset = "0x39A64")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x1373BE8", Offset = "0x1373BE8", VA = "0x1373BE8")]
		[Attribute(Name = "ContextMenu", RVA = "0x39A9C", Offset = "0x39A9C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1373C30", Offset = "0x1373C30", VA = "0x1373C30")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x1373C50", Offset = "0x1373C50", VA = "0x1373C50", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1373C58", Offset = "0x1373C58", VA = "0x1373C58")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x1373E58", Offset = "0x1373E58", VA = "0x1373E58")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default;
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x13740FC", Offset = "0x13740FC", VA = "0x13740FC")]
		[Attribute(Name = "ContextMenu", RVA = "0x39AD4", Offset = "0x39AD4")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1374124", Offset = "0x1374124", VA = "0x1374124")]
		[Attribute(Name = "ContextMenu", RVA = "0x39B0C", Offset = "0x39B0C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x1374204", Offset = "0x1374204", VA = "0x1374204")]
		public FullBodyBipedIK()
		{
		}
	}
}
