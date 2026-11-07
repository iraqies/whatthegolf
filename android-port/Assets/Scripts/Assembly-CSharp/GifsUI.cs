using UnityEngine;

public class GifsUI : MonoBehaviour
{
	private static GifsUI s_instance;

	public static GifsUI instance => null;

	public GifsPanel gifsPanel => null;

	public GifDetailPanel gifDetailPanel => null;

	private void Awake()
	{
	}
}
