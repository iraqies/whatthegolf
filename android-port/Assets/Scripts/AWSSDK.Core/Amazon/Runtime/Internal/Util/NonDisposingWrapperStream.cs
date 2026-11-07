using System.IO;

namespace Amazon.Runtime.Internal.Util
{
	public class NonDisposingWrapperStream : WrapperStream
	{
		public NonDisposingWrapperStream(Stream baseStream)
			: base(null)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
