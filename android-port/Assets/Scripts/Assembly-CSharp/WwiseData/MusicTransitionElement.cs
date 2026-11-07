namespace WwiseData
{
	public class MusicTransitionElement
	{
		private string Id;

		public TransitionInfoUnion TransitionInfo { get; }

		public MusicTransitionName Name { get; }

		public MusicClipPropertyList PropertyList { get; }

		public MusicTransitionReferenceList ReferenceList { get; }
	}
}
