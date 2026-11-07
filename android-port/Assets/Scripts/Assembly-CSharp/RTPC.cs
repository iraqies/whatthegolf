using System.Collections.Generic;
using UnityEngine;
using Wwise2;
using WwiseXMLRTPCData;

public class RTPC : MonoBehaviour
{
	public string id;

	public float value;

	public float InitialValue;

	public float min;

	public float max;

	public List<MusicTrack> tracks;

	public uint shortID;

	private Coroutine currentRTPCOverTime;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void UpdateTracks()
	{
	}

	public void SetRTPCOverTime(float newValue, int ms)
	{
	}

	public void SetRTPC(float newValue)
	{
	}

	public void Init(GameParameter parameter, List<MusicPlaylist> playlists)
	{
	}

	public void Init(WwiseDocumentGameParametersWorkUnitChildrenListGameParameter parameter, List<MusicPlaylist> playlists)
	{
	}

	private void ParseProp(PropertyElement prop)
	{
	}

	private void ParseProp(WwiseDocumentGameParametersWorkUnitChildrenListGameParameterProperty prop)
	{
	}
}
