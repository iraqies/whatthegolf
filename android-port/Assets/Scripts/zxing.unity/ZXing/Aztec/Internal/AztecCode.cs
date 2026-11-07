using System.Runtime.CompilerServices;
using ZXing.Common;

namespace ZXing.Aztec.Internal
{
	public sealed class AztecCode
	{
		[CompilerGenerated]
		private bool isCompact__BackingField;

		[CompilerGenerated]
		private int Size__BackingField;

		[CompilerGenerated]
		private int Layers__BackingField;

		[CompilerGenerated]
		private int CodeWords__BackingField;

		public bool isCompact
		{
			[CompilerGenerated]
			set
			{
				isCompact__BackingField = value;
			}
		}

		public int Size
		{
			[CompilerGenerated]
			set
			{
				Size__BackingField = value;
			}
		}

		public int Layers
		{
			[CompilerGenerated]
			set
			{
				Layers__BackingField = value;
			}
		}

		public int CodeWords
		{
			[CompilerGenerated]
			set
			{
				CodeWords__BackingField = value;
			}
		}

		public BitMatrix Matrix { get; set; }
	}
}
