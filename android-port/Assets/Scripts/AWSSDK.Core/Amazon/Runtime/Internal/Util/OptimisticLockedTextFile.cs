using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x2000204")]
	public class OptimisticLockedTextFile
	{
		[Token(Token = "0x400079E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27B18", Offset = "0x27B18")]
		private string OriginalContents__BackingField;

		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27B28", Offset = "0x27B28")]
		private string FilePath__BackingField;

		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27B38", Offset = "0x27B38")]
		private List<string> Lines__BackingField;

		[Token(Token = "0x170003FC")]
		private string OriginalContents
		{
			[Token(Token = "0x6000FD5")]
			[Address(RVA = "0x1244550", Offset = "0x1244550", VA = "0x1244550")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BBE0", Offset = "0x2BBE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FD6")]
			[Address(RVA = "0x1244558", Offset = "0x1244558", VA = "0x1244558")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BBF0", Offset = "0x2BBF0")]
			set
			{
			}
		}

		[Token(Token = "0x170003FD")]
		public string FilePath
		{
			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x1244560", Offset = "0x1244560", VA = "0x1244560")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC00", Offset = "0x2BC00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FD8")]
			[Address(RVA = "0x1244568", Offset = "0x1244568", VA = "0x1244568")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC10", Offset = "0x2BC10")]
			private set
			{
			}
		}

		[Token(Token = "0x170003FE")]
		public List<string> Lines
		{
			[Token(Token = "0x6000FD9")]
			[Address(RVA = "0x1244570", Offset = "0x1244570", VA = "0x1244570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC20", Offset = "0x2BC20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FDA")]
			[Address(RVA = "0x1244578", Offset = "0x1244578", VA = "0x1244578")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC30", Offset = "0x2BC30")]
			private set
			{
			}
		}

		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x1244580", Offset = "0x1244580", VA = "0x1244580")]
		public OptimisticLockedTextFile(string filePath)
		{
		}

		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x12446C0", Offset = "0x12446C0", VA = "0x12446C0")]
		public void Persist()
		{
		}

		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x1244C4C", Offset = "0x1244C4C", VA = "0x1244C4C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x12445B0", Offset = "0x12445B0", VA = "0x12445B0")]
		private void Read()
		{
		}

		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x1244D88", Offset = "0x1244D88", VA = "0x1244D88")]
		private static bool HasEnding(string line)
		{
			return default;
		}

		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x1244DBC", Offset = "0x1244DBC", VA = "0x1244DBC")]
		private static List<string> ReadLinesWithEndings(string str)
		{
			return null;
		}
	}
}
