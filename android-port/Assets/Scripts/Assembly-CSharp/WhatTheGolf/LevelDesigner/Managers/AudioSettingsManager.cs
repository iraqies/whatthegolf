using System.Collections;
using Audio;
using UnityEngine;
using UnityEngine.Audio;
using WhatTheGolf.LevelDesigner.Audio;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.Managers
{
	public class AudioSettingsManager : BaseManager, IRequireEvents<AudioEvent>, IRequireEvents, IRequireEvents<GameStateEvent>
	{
		[SerializeField]
		private MusicStateSettings m_MusicStateSettings;

		[SerializeField]
		private AmbientAudio m_AmbiencePrefab;

		[SerializeField]
		private PaintBrushSFX m_PaintBrushSFX;

		[SerializeField]
		private AudioMixerSnapshot m_EditModeAudioSnapshot;

		[SerializeField]
		private AudioMixerSnapshot m_PlayModeAudioSnapshot;

		[SerializeField]
		private AudioMixerSnapshot m_EditModeMusicSnapshot;

		[SerializeField]
		private AudioMixerSnapshot m_PlayModeMusicSnapshot;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnPropPlaced;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnObjectHoverAny;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnObjectSelectAny;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnObjectDelete;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnObjectDeleteByEraser;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnButtonHoverAny;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnButtonDownAny;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnSave;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnUndo;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnRedo;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnPublishStart;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnPublishSuccess;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnPublishFail;

		[SerializeField]
		private ClipSettingsCollection m_SfxOnFail;

		private float m_NextUISfxTime;

		public override void Init()
		{
		}

		private IEnumerator SetInitialMixerSnapshot()
		{
			return null;
		}

		public void OnEvent(AudioEvent evt)
		{
		}

		public void OnEvent(GameStateEvent evt)
		{
		}

		private void MusicTransitionEditMode()
		{
		}

		private void MusicTransitionPlaymode()
		{
		}
	}
}
