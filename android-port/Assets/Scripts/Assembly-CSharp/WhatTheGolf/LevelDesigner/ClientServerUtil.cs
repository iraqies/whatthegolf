using System;
using System.Collections;
using System.Text;
using UnityEngine.Networking;

namespace WhatTheGolf.LevelDesigner
{
	public static class ClientServerUtil
	{
		private static StringBuilder s_JsonBuilder;

		public static IEnumerator PostPlayer(ulong playerId, Action<bool> result)
		{
			return null;
		}

		public static IEnumerator PostPlay(ulong playerId, Guid levelId, Action<bool> result = null)
		{
			return null;
		}

		public static IEnumerator GetLevels(string query, Action<bool, SerializableLevelData[]> result)
		{
			return null;
		}

		public static IEnumerator PostLevel(ulong playerId, SerializableLevelData levelData, Action<bool> result)
		{
			return null;
		}

		private static IEnumerator Get(string query, Action<bool, string> result, (string, string)[] headers = null)
		{
			return null;
		}

		private static IEnumerator Post(string directory, string body, Action<bool> result, (string, string)[] headers = null)
		{
			return null;
		}

		private static void SetHeaders(ref UnityWebRequest www, (string, string)[] headers)
		{
		}

		public static void WrapJsonContainer(ref string json)
		{
		}

		private static void ValidateRequest(UnityWebRequest www, out bool isError)
		{
			isError = default;
		}
	}
}
