using System.IO;
using Il2CppDummyDll;

namespace Moments.Encoder
{
	[Token(Token = "0x2000282")]
	public class GifEncoder
	{
		[Token(Token = "0x40010A5")]
		[FieldOffset(Offset = "0x10")]
		protected int m_Width;

		[Token(Token = "0x40010A6")]
		[FieldOffset(Offset = "0x14")]
		protected int m_Height;

		[Token(Token = "0x40010A7")]
		[FieldOffset(Offset = "0x18")]
		protected int m_Repeat;

		[Token(Token = "0x40010A8")]
		[FieldOffset(Offset = "0x1C")]
		protected int m_FrameDelay;

		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0x20")]
		protected bool m_HasStarted;

		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0x28")]
		protected FileStream m_FileStream;

		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0x30")]
		protected GifFrame m_CurrentFrame;

		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0x38")]
		protected byte[] m_Pixels;

		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0x40")]
		protected byte[] m_IndexedPixels;

		[Token(Token = "0x40010AE")]
		[FieldOffset(Offset = "0x48")]
		protected int m_ColorDepth;

		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0x50")]
		protected byte[] m_ColorTab;

		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0x58")]
		protected bool[] m_UsedEntry;

		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x60")]
		protected int m_PaletteSize;

		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x64")]
		protected int m_DisposalCode;

		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x68")]
		protected bool m_ShouldCloseStream;

		[Token(Token = "0x40010B4")]
		[FieldOffset(Offset = "0x69")]
		protected bool m_IsFirstFrame;

		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0x6A")]
		protected bool m_IsSizeSet;

		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x6C")]
		protected int m_SampleInterval;

		[Token(Token = "0x6001084")]
		[Address(RVA = "0x1376D9C", Offset = "0x1376D9C", VA = "0x1376D9C")]
		public GifEncoder(int repeat, int quality)
		{
		}

		[Token(Token = "0x6001085")]
		[Address(RVA = "0x1376E50", Offset = "0x1376E50", VA = "0x1376E50")]
		public void SetDelay(int ms)
		{
		}

		[Token(Token = "0x6001086")]
		[Address(RVA = "0x1376E84", Offset = "0x1376E84", VA = "0x1376E84")]
		public void AddFrame(GifFrame frame)
		{
		}

		[Token(Token = "0x6001087")]
		[Address(RVA = "0x1377854", Offset = "0x1377854", VA = "0x1377854")]
		public void Start(FileStream os)
		{
		}

		[Token(Token = "0x6001088")]
		[Address(RVA = "0x1377A20", Offset = "0x1377A20", VA = "0x1377A20")]
		public void Start(string file)
		{
		}

		[Token(Token = "0x6001089")]
		[Address(RVA = "0x1377B3C", Offset = "0x1377B3C", VA = "0x1377B3C")]
		public void Finish()
		{
		}

		[Token(Token = "0x600108A")]
		[Address(RVA = "0x1377024", Offset = "0x1377024", VA = "0x1377024")]
		protected void SetSize(int w, int h)
		{
		}

		[Token(Token = "0x600108B")]
		[Address(RVA = "0x1377034", Offset = "0x1377034", VA = "0x1377034")]
		protected void GetImagePixels()
		{
		}

		[Token(Token = "0x600108C")]
		[Address(RVA = "0x1377178", Offset = "0x1377178", VA = "0x1377178")]
		protected void AnalyzePixels()
		{
		}

		[Token(Token = "0x600108D")]
		[Address(RVA = "0x1377594", Offset = "0x1377594", VA = "0x1377594")]
		protected void WriteGraphicCtrlExt()
		{
		}

		[Token(Token = "0x600108E")]
		[Address(RVA = "0x13776CC", Offset = "0x13776CC", VA = "0x13776CC")]
		protected void WriteImageDesc()
		{
		}

		[Token(Token = "0x600108F")]
		[Address(RVA = "0x1377320", Offset = "0x1377320", VA = "0x1377320")]
		protected void WriteLSD()
		{
		}

		[Token(Token = "0x6001090")]
		[Address(RVA = "0x1377490", Offset = "0x1377490", VA = "0x1377490")]
		protected void WriteNetscapeExt()
		{
		}

		[Token(Token = "0x6001091")]
		[Address(RVA = "0x1377404", Offset = "0x1377404", VA = "0x1377404")]
		protected void WritePalette()
		{
		}

		[Token(Token = "0x6001092")]
		[Address(RVA = "0x13777BC", Offset = "0x13777BC", VA = "0x13777BC")]
		protected void WritePixels()
		{
		}

		[Token(Token = "0x6001093")]
		[Address(RVA = "0x1377CB0", Offset = "0x1377CB0", VA = "0x1377CB0")]
		protected void WriteShort(int value)
		{
		}

		[Token(Token = "0x6001094")]
		[Address(RVA = "0x1377984", Offset = "0x1377984", VA = "0x1377984")]
		protected void WriteString(string s)
		{
		}
	}
}
