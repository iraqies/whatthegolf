using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x200122A")]
	public abstract class BaseCameraController : MonoBehaviour
	{
		[Token(Token = "0x17000941")]
		public abstract CinemachineVirtualCamera virtualCamera
		{
			[Token(Token = "0x60053BB")]
			get;
		}

		[Token(Token = "0x60053BC")]
		public abstract void SetActive(bool value);

		[Token(Token = "0x60053BD")]
		public abstract void SetTarget(Transform target);

		[Token(Token = "0x60053BE")]
		[Address(RVA = "0x151B668", Offset = "0x151B668", VA = "0x151B668")]
		protected BaseCameraController()
		{
		}
	}
}
