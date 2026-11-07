using System.Collections;

public interface IVideoPathProvider
{
	bool InitComplete { get; }

	IEnumerator Init();

	string GetVideoPath(string path);

	bool FileExists(string path);

	IEnumerator GetVideoClipForPath(string path, VideoClipResult result);

	void Cleanup();
}
