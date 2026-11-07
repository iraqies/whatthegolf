using System.IO;
using Il2CppDummyDll;

namespace OldMoatGames
{
	[Token(Token = "0x20002E7")]
	public class GifDecoder
	{
		[Token(Token = "0x20002E8")]
		public enum Status
		{
			[Token(Token = "0x4001268")]
			StatusOk = 0,
			[Token(Token = "0x4001269")]
			StatusFormatError = 1,
			[Token(Token = "0x400126A")]
			StatusOpenError = 2
		}

		[Token(Token = "0x20002E9")]
		public class GifFrame
		{
			[Token(Token = "0x400126B")]
			[FieldOffset(Offset = "0x10")]
			public byte[] Image;

			[Token(Token = "0x400126C")]
			[FieldOffset(Offset = "0x18")]
			public float Delay;

			[Token(Token = "0x6001339")]
			[Address(RVA = "0x133AC90", Offset = "0x133AC90", VA = "0x133AC90")]
			public GifFrame(byte[] im, float del)
			{
			}
		}

		[Token(Token = "0x400123C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37600", Offset = "0x37600")]
		private int NumberOfFrames__BackingField;

		[Token(Token = "0x400123D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37610", Offset = "0x37610")]
		private bool AllFramesRead__BackingField;

		[Token(Token = "0x400123E")]
		[FieldOffset(Offset = "0x18")]
		private Stream _inStream;

		[Token(Token = "0x400123F")]
		[FieldOffset(Offset = "0x20")]
		private Status _status;

		[Token(Token = "0x4001240")]
		[FieldOffset(Offset = "0x24")]
		private int _width;

		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0x28")]
		private int _height;

		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0x2C")]
		private bool _gctFlag;

		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0x30")]
		private int _gctSize;

		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x34")]
		private int _loopCount;

		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x38")]
		private int[] _gct;

		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x40")]
		private int[] _lct;

		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x48")]
		private int[] _act;

		[Token(Token = "0x4001248")]
		[FieldOffset(Offset = "0x50")]
		private int _bgIndex;

		[Token(Token = "0x4001249")]
		[FieldOffset(Offset = "0x54")]
		private int _bgColor;

		[Token(Token = "0x400124A")]
		[FieldOffset(Offset = "0x58")]
		private int _lastBgColor;

		[Token(Token = "0x400124B")]
		[FieldOffset(Offset = "0x5C")]
		private bool _lctFlag;

		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0x5D")]
		private bool _interlace;

		[Token(Token = "0x400124D")]
		[FieldOffset(Offset = "0x60")]
		private int _lctSize;

		[Token(Token = "0x400124E")]
		[FieldOffset(Offset = "0x64")]
		private int _ix;

		[Token(Token = "0x400124F")]
		[FieldOffset(Offset = "0x68")]
		private int _iy;

		[Token(Token = "0x4001250")]
		[FieldOffset(Offset = "0x6C")]
		private int _iw;

		[Token(Token = "0x4001251")]
		[FieldOffset(Offset = "0x70")]
		private int _ih;

		[Token(Token = "0x4001252")]
		[FieldOffset(Offset = "0x74")]
		private int _lix;

		[Token(Token = "0x4001253")]
		[FieldOffset(Offset = "0x78")]
		private int _liy;

		[Token(Token = "0x4001254")]
		[FieldOffset(Offset = "0x7C")]
		private int _liw;

		[Token(Token = "0x4001255")]
		[FieldOffset(Offset = "0x80")]
		private int _lih;

		[Token(Token = "0x4001256")]
		[FieldOffset(Offset = "0x88")]
		private int[] _image;

		[Token(Token = "0x4001257")]
		[FieldOffset(Offset = "0x90")]
		private byte[] _bimage;

		[Token(Token = "0x4001258")]
		[FieldOffset(Offset = "0x98")]
		private readonly byte[] _block;

		[Token(Token = "0x4001259")]
		[FieldOffset(Offset = "0xA0")]
		private int _blockSize;

		[Token(Token = "0x400125A")]
		[FieldOffset(Offset = "0xA4")]
		private int _dispose;

		[Token(Token = "0x400125B")]
		[FieldOffset(Offset = "0xA8")]
		private int _lastDispose;

		[Token(Token = "0x400125C")]
		[FieldOffset(Offset = "0xAC")]
		private bool _transparency;

		[Token(Token = "0x400125D")]
		[FieldOffset(Offset = "0xB0")]
		private float _delay;

		[Token(Token = "0x400125E")]
		[FieldOffset(Offset = "0xB4")]
		private int _transIndex;

		[Token(Token = "0x400125F")]
		[FieldOffset(Offset = "0xB8")]
		private long _imageDataOffset;

		[Token(Token = "0x4001260")]
		private const int MaxStackSize = 4096;

		[Token(Token = "0x4001261")]
		[FieldOffset(Offset = "0xC0")]
		private short[] _prefix;

		[Token(Token = "0x4001262")]
		[FieldOffset(Offset = "0xC8")]
		private byte[] _suffix;

		[Token(Token = "0x4001263")]
		[FieldOffset(Offset = "0xD0")]
		private byte[] _pixelStack;

		[Token(Token = "0x4001264")]
		[FieldOffset(Offset = "0xD8")]
		private byte[] _pixels;

		[Token(Token = "0x4001265")]
		[FieldOffset(Offset = "0xE0")]
		private GifFrame _currentFrame;

		[Token(Token = "0x4001266")]
		[FieldOffset(Offset = "0xE8")]
		private int _frameCount;

		[Token(Token = "0x17000288")]
		public int NumberOfFrames
		{
			[Token(Token = "0x600131E")]
			[Address(RVA = "0x1375820", Offset = "0x1375820", VA = "0x1375820")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BFC0", Offset = "0x3BFC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600131F")]
			[Address(RVA = "0x1375828", Offset = "0x1375828", VA = "0x1375828")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BFD0", Offset = "0x3BFD0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000289")]
		public bool AllFramesRead
		{
			[Token(Token = "0x6001320")]
			[Address(RVA = "0x1375830", Offset = "0x1375830", VA = "0x1375830")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BFE0", Offset = "0x3BFE0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001321")]
			[Address(RVA = "0x1375838", Offset = "0x1375838", VA = "0x1375838")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BFF0", Offset = "0x3BFF0")]
			private set
			{
			}
		}

		[Token(Token = "0x6001322")]
		[Address(RVA = "0x1375840", Offset = "0x1375840", VA = "0x1375840")]
		public int GetFrameCount()
		{
			return default;
		}

		[Token(Token = "0x6001323")]
		[Address(RVA = "0x1375848", Offset = "0x1375848", VA = "0x1375848")]
		public GifFrame GetCurrentFrame()
		{
			return null;
		}

		[Token(Token = "0x6001324")]
		[Address(RVA = "0x1375850", Offset = "0x1375850", VA = "0x1375850")]
		public int GetFrameWidth()
		{
			return default;
		}

		[Token(Token = "0x6001325")]
		[Address(RVA = "0x1375858", Offset = "0x1375858", VA = "0x1375858")]
		public int GetFrameHeight()
		{
			return default;
		}

		[Token(Token = "0x6001326")]
		[Address(RVA = "0x1375860", Offset = "0x1375860", VA = "0x1375860")]
		public Status Read(Stream inStream)
		{
			return default;
		}

		[Token(Token = "0x6001327")]
		[Address(RVA = "0x1375A78", Offset = "0x1375A78", VA = "0x1375A78")]
		private bool Error()
		{
			return default;
		}

		[Token(Token = "0x6001328")]
		[Address(RVA = "0x1375A88", Offset = "0x1375A88", VA = "0x1375A88")]
		public void ReadNextFrame(bool loop)
		{
		}

		[Token(Token = "0x6001329")]
		[Address(RVA = "0x13762DC", Offset = "0x13762DC", VA = "0x13762DC")]
		private void RewindReader()
		{
		}

		[Token(Token = "0x600132A")]
		[Address(RVA = "0x1376310", Offset = "0x1376310", VA = "0x1376310")]
		private void SetPixels()
		{
		}

		[Token(Token = "0x600132B")]
		[Address(RVA = "0x1376580", Offset = "0x1376580", VA = "0x1376580")]
		private void DecodeImageData()
		{
		}

		[Token(Token = "0x600132C")]
		[Address(RVA = "0x13758BC", Offset = "0x13758BC", VA = "0x13758BC")]
		private void Init()
		{
		}

		[Token(Token = "0x600132D")]
		[Address(RVA = "0x1375CFC", Offset = "0x1375CFC", VA = "0x1375CFC")]
		private int Read()
		{
			return default;
		}

		[Token(Token = "0x600132E")]
		[Address(RVA = "0x1376110", Offset = "0x1376110", VA = "0x1376110")]
		private int ReadBlock()
		{
			return default;
		}

		[Token(Token = "0x600132F")]
		[Address(RVA = "0x1376A64", Offset = "0x1376A64", VA = "0x1376A64")]
		private int[] ReadColorTable(int ncolors)
		{
			return null;
		}

		[Token(Token = "0x6001330")]
		[Address(RVA = "0x1376090", Offset = "0x1376090", VA = "0x1376090")]
		private void ReadGraphicControlExt()
		{
		}

		[Token(Token = "0x6001331")]
		[Address(RVA = "0x13758D4", Offset = "0x13758D4", VA = "0x13758D4")]
		private void ReadHeader()
		{
		}

		[Token(Token = "0x6001332")]
		[Address(RVA = "0x1375DBC", Offset = "0x1375DBC", VA = "0x1375DBC")]
		private void ReadImage()
		{
		}

		[Token(Token = "0x6001333")]
		[Address(RVA = "0x1376C80", Offset = "0x1376C80", VA = "0x1376C80")]
		private void ReadLsd()
		{
		}

		[Token(Token = "0x6001334")]
		[Address(RVA = "0x1376228", Offset = "0x1376228", VA = "0x1376228")]
		private void ReadNetscapeExt()
		{
		}

		[Token(Token = "0x6001335")]
		[Address(RVA = "0x1376C50", Offset = "0x1376C50", VA = "0x1376C50")]
		private int ReadShort()
		{
			return default;
		}

		[Token(Token = "0x6001336")]
		[Address(RVA = "0x1376D00", Offset = "0x1376D00", VA = "0x1376D00")]
		private void ResetFrame()
		{
		}

		[Token(Token = "0x6001337")]
		[Address(RVA = "0x13762A4", Offset = "0x13762A4", VA = "0x13762A4")]
		private void Skip()
		{
		}

		[Token(Token = "0x6001338")]
		[Address(RVA = "0x1376D30", Offset = "0x1376D30", VA = "0x1376D30")]
		public GifDecoder()
		{
		}
	}
}
