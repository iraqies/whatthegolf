using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class ActionCategoryMap
	{
		[Serializable]
		public class Entry
		{
			private sealed class KpKOwspLQmNeJTAqHzvkTzXndMo : IDisposable, IEnumerable, IEnumerator, IEnumerable<int>, IEnumerator<int>
			{
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				private int VqEePGSMyrGKIqkWibsjeHcWPSIx;

				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				public Entry TtytLoUfsgUyhsklaKccrnoMiiek;

				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				int IEnumerator<int>.Current
				{
					[DebuggerHidden]
					get
					{
						return 0;
					}
				}

				object IEnumerator.Current
				{
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[DebuggerHidden]
				public KpKOwspLQmNeJTAqHzvkTzXndMo(int P_0)
				{
				}

				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				private bool MoveNext()
				{
					return false;
				}

				bool IEnumerator.MoveNext()
				{
					//ILSpy generated this explicit interface implementation from .override directive in MoveNext
					return this.MoveNext();
				}

				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[DebuggerHidden]
				IEnumerator<int> IEnumerable<int>.GetEnumerator()
				{
					return null;
				}

				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			public int categoryId;

			public List<int> actionIds;

			public IEnumerable<int> ActionIds => null;

			public Entry()
			{
			}

			public Entry(int P_0)
			{
			}
		}

		private sealed class YKoEIaasnOPnuZcGBXgOnNhocKZB : IDisposable, IEnumerable, IEnumerator, IEnumerable<int>, IEnumerator<int>
		{
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			private int VqEePGSMyrGKIqkWibsjeHcWPSIx;

			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			public ActionCategoryMap TtytLoUfsgUyhsklaKccrnoMiiek;

			private int IHGOXTDxkGUFIdzxXaNUTxjYneo;

			public int lIKkctcWVTwoXwHsmpFUIPKIHahI;

			private IEnumerator<int> hSeONskmQJhVsjVUHGUASYbDGJrU;

			int IEnumerator<int>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public YKoEIaasnOPnuZcGBXgOnNhocKZB(int P_0)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void uvbwjgAeXsWySvtbvsLpuFVuAgJB()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<int> IEnumerable<int>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[SerializeField]
		private List<Entry> list;

		public IEnumerable<int> ActionIdsInCategory(int categoryId)
		{
			return null;
		}

		public void AddCategory(int id)
		{
		}

		public int IndexOfCategory(int id)
		{
			return 0;
		}
	}
}
