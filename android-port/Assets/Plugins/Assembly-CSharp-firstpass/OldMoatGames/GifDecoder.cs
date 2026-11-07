using System.IO;

namespace OldMoatGames
{
	public class GifDecoder
	{
		public enum Status
		{
			StatusOk = 0,
			StatusFormatError = 1,
			StatusOpenError = 2
		}

		public class GifFrame
		{
			public byte[] Image;

			public float Delay;

			public GifFrame(byte[] im, float del)
			{
			}
		}

		private Stream _inStream;

		private Status _status;

		private int _width;

		private int _height;

		private bool _gctFlag;

		private int _gctSize;

		private int _loopCount;

		private int[] _gct;

		private int[] _lct;

		private int[] _act;

		private int _bgIndex;

		private int _bgColor;

		private int _lastBgColor;

		private bool _lctFlag;

		private bool _interlace;

		private int _lctSize;

		private int _ix;

		private int _iy;

		private int _iw;

		private int _ih;

		private int _lix;

		private int _liy;

		private int _liw;

		private int _lih;

		private int[] _image;

		private byte[] _bimage;

		private readonly byte[] _block;

		private int _blockSize;

		private int _dispose;

		private int _lastDispose;

		private bool _transparency;

		private float _delay;

		private int _transIndex;

		private long _imageDataOffset;

		private const int MaxStackSize = 4096;

		private short[] _prefix;

		private byte[] _suffix;

		private byte[] _pixelStack;

		private byte[] _pixels;

		private GifFrame _currentFrame;

		private int _frameCount;

		public int NumberOfFrames { get; private set; }

		public bool AllFramesRead { get; private set; }

		public int GetFrameCount()
		{
			return 0;
		}

		public GifFrame GetCurrentFrame()
		{
			return null;
		}

		public int GetFrameWidth()
		{
			return 0;
		}

		public int GetFrameHeight()
		{
			return 0;
		}

		public Status Read(Stream inStream)
		{
			return Status.StatusOk;
		}

		private bool Error()
		{
			return false;
		}

		public void ReadNextFrame(bool loop)
		{
		}

		private void RewindReader()
		{
		}

		private void SetPixels()
		{
		}

		private void DecodeImageData()
		{
		}

		private void Init()
		{
		}

		private int Read()
		{
			return 0;
		}

		private int ReadBlock()
		{
			return 0;
		}

		private int[] ReadColorTable(int ncolors)
		{
			return null;
		}

		private void ReadGraphicControlExt()
		{
		}

		private void ReadHeader()
		{
		}

		private void ReadImage()
		{
		}

		private void ReadLsd()
		{
		}

		private void ReadNetscapeExt()
		{
		}

		private int ReadShort()
		{
			return 0;
		}

		private void ResetFrame()
		{
		}

		private void Skip()
		{
		}
	}
}
