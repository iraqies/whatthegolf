using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000071")]
	public interface ICinemachineCamera
	{
		[Token(Token = "0x170000BF")]
		string Name
		{
			[Token(Token = "0x60002CF")]
			get;
		}

		[Token(Token = "0x170000C0")]
		int Priority
		{
			[Token(Token = "0x60002D0")]
			get;
		}

		[Token(Token = "0x170000C1")]
		Transform LookAt
		{
			[Token(Token = "0x60002D1")]
			get;
		}

		[Token(Token = "0x170000C2")]
		Transform Follow
		{
			[Token(Token = "0x60002D2")]
			get;
		}

		[Token(Token = "0x170000C3")]
		CameraState State
		{
			[Token(Token = "0x60002D3")]
			get;
		}

		[Token(Token = "0x170000C4")]
		GameObject VirtualCameraGameObject
		{
			[Token(Token = "0x60002D4")]
			get;
		}

		[Token(Token = "0x170000C5")]
		bool IsValid
		{
			[Token(Token = "0x60002D5")]
			get;
		}

		[Token(Token = "0x170000C6")]
		ICinemachineCamera ParentCamera
		{
			[Token(Token = "0x60002D6")]
			get;
		}

		[Token(Token = "0x60002D7")]
		bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false);

		[Token(Token = "0x60002D8")]
		void UpdateCameraState(Vector3 worldUp, float deltaTime);

		[Token(Token = "0x60002D9")]
		void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime);
	}
}
