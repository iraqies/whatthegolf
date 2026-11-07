using System;
using System.Collections.Generic;
using UnityEngine;
using WwiseData;

public class Wwise : MonoBehaviour
{
	public enum exitType
	{
		Immediate = 0,
		NextBar = 1,
		NextBeat = 2,
		ExitCue = 3
	}

	public TextAsset wwiseProjectFile;

	[NonSerialized]
	public WwiseDocument document;

	public static bool verbose;

	public List<MusicState> musicStates;

	public List<MusicTransition> musicTransitions;

	public WwiseRTPC rtpc;

	public WwiseAudioSources sourcesMusic;

	public WwiseAudioSources sourcesTransition;

	public WwiseAudioSources sourcesTrigger;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public static void Log(object message)
	{
	}
}
