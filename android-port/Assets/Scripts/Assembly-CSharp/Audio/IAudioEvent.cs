using System;
using UnityEngine;

namespace Audio
{
	public interface IAudioEvent
	{
		Action<Vector3> OnAudioEvent { get; set; }
	}
}
