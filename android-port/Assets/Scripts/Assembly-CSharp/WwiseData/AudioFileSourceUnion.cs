using System.Collections.Generic;

namespace WwiseData
{
	public struct AudioFileSourceUnion
	{
		public List<AudioFileSourceElement> AudioFileSourceElementArray;

		public PurpleAudioFileSource PurpleAudioFileSource;
	}
}
