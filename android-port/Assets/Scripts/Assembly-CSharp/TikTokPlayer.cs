using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Video;

public class TikTokPlayer : MonoBehaviour
{
	[SerializeField]
	private SVGImage playImage;

	[SerializeField]
	private float distanceTolerance;

	[SerializeField]
	private VideoPlayer videoPlayer;

	[SerializeField]
	private GameObject loading;

	[SerializeField]
	private AssetReference[] videoClips;

	[SerializeField]
	private Camera camera;

	[SerializeField]
	private AudioSource audioSource;

	private bool _isInitiated;

	private bool _isCentered;

	private bool _wasCentered;

	private void Start()
	{
	}

	private Task InitVideoPlayer()
	{
		return null;
	}

	private int GetVideoIndex()
	{
		return 0;
	}

	private void Update()
	{
	}

	private bool IsCentered()
	{
		return false;
	}

	public void OnPlayClicked()
	{
	}

	private void PauseOrPlay(bool shouldPlay)
	{
	}

	public void OnGoToTikTokClicked()
	{
	}
}
