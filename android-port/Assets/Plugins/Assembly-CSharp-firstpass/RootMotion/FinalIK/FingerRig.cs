using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000141")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Attribute(Name = "RangeAttribute", RVA = "0x35B00", Offset = "0x35B00")]
		public float weight;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x35B18", Offset = "0x35B18")]
		private bool initiated__BackingField;

		[Token(Token = "0x17000126")]
		public bool initiated
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x1371BF8", Offset = "0x1371BF8", VA = "0x1371BF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38FD4", Offset = "0x38FD4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1371C00", Offset = "0x1371C00", VA = "0x1371C00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38FE4", Offset = "0x38FE4")]
			private set
			{
			}
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x1371C08", Offset = "0x1371C08", VA = "0x1371C08")]
		public bool IsValid(ref string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x1371C8C", Offset = "0x1371C8C", VA = "0x1371C8C")]
		[Attribute(Name = "ContextMenu", RVA = "0x38FF4", Offset = "0x38FF4")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1371FDC", Offset = "0x1371FDC", VA = "0x1371FDC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1372154", Offset = "0x1372154", VA = "0x1372154")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1371ED8", Offset = "0x1371ED8", VA = "0x1371ED8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x13722DC", Offset = "0x13722DC", VA = "0x13722DC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x13723A0", Offset = "0x13723A0", VA = "0x13723A0")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1372418", Offset = "0x1372418", VA = "0x1372418")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1372494", Offset = "0x1372494", VA = "0x1372494")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x1372504", Offset = "0x1372504", VA = "0x1372504", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x1372580", Offset = "0x1372580", VA = "0x1372580", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x1372600", Offset = "0x1372600", VA = "0x1372600")]
		public FingerRig()
		{
		}
	}
}
