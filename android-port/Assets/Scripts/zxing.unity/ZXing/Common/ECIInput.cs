namespace ZXing.Common
{
	public interface ECIInput
	{
		int Length { get; }

		char charAt(int index);

		string subSequence(int start, int end);

		bool isECI(int index);

		int getECIValue(int index);
	}
}
