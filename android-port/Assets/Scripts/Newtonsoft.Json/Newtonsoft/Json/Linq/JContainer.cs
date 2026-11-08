using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Newtonsoft.Json.Linq
{
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList
	{
		internal ListChangedEventHandler _listChanged;

		internal AddingNewEventHandler _addingNew;

		internal NotifyCollectionChangedEventHandler _collectionChanged;

		private object _syncRoot;

		private bool _busy;

		protected abstract IList<JToken> ChildrenTokens { get; }

		public override bool HasValues => false;

		public override JToken First => null;

		public override JToken Last => null;

		JToken IList<JToken>.this[int index]
		{
			get => null;
			set { }
		}

		bool ICollection<JToken>.IsReadOnly => false;

		bool IList.IsFixedSize => false;

		bool IList.IsReadOnly => false;

		object IList.this[int index]
		{
			get => null;
			set { }
		}

		public int Count => 0;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		bool IBindingList.AllowEdit => false;

		bool IBindingList.AllowNew => false;

		bool IBindingList.AllowRemove => false;

		bool IBindingList.IsSorted => false;

		ListSortDirection IBindingList.SortDirection => ListSortDirection.Ascending;

		PropertyDescriptor IBindingList.SortProperty => null;

		bool IBindingList.SupportsChangeNotification => false;

		bool IBindingList.SupportsSearching => false;

		bool IBindingList.SupportsSorting => false;

		public event ListChangedEventHandler ListChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal JContainer()
		{
		}

		internal JContainer(JContainer other)
		{
		}

		internal void CheckReentrancy()
		{
		}

		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
		}

		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
		}

		public override JEnumerable<JToken> Children()
		{
			return default;
		}

		internal bool IsMultiContent(object content)
		{
			return false;
		}

		internal JToken EnsureParentToken(JToken item, bool skipParentCheck)
		{
			return null;
		}

		internal abstract int IndexOfItem(JToken item);

		internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck)
		{
			return false;
		}

		internal virtual void RemoveItemAt(int index)
		{
		}

		internal virtual bool RemoveItem(JToken item)
		{
			return false;
		}

		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		internal virtual void SetItem(int index, JToken item)
		{
		}

		internal virtual void ClearItems()
		{
		}

		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		internal virtual bool ContainsItem(JToken item)
		{
			return false;
		}

		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			return false;
		}

		internal virtual void ValidateToken(JToken o, JToken existing)
		{
		}

		public virtual void Add(object content)
		{
		}

		internal bool TryAdd(object content)
		{
			return false;
		}

		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		internal bool TryAddInternal(int index, object content, bool skipParentCheck)
		{
			return false;
		}

		internal static JToken CreateFromContent(object content)
		{
			return null;
		}

		public void RemoveAll()
		{
		}

		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options)
		{
		}

		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings)
		{
		}

		private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent)
		{
			return null;
		}

		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		int IList<JToken>.IndexOf(JToken item)
		{
			return 0;
		}

		void IList<JToken>.Insert(int index, JToken item)
		{
		}

		void IList<JToken>.RemoveAt(int index)
		{
		}

		void ICollection<JToken>.Add(JToken item)
		{
		}

		void ICollection<JToken>.Clear()
		{
		}

		bool ICollection<JToken>.Contains(JToken item)
		{
			return false;
		}

		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
		}

		bool ICollection<JToken>.Remove(JToken item)
		{
			return false;
		}

		private JToken EnsureValue(object value)
		{
			return null;
		}

		int IList.Add(object value)
		{
			return 0;
		}

		void IList.Clear()
		{
		}

		bool IList.Contains(object value)
		{
			return false;
		}

		int IList.IndexOf(object value)
		{
			return 0;
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		void IBindingList.AddIndex(PropertyDescriptor property)
		{
		}

		object IBindingList.AddNew()
		{
			return null;
		}

		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
		}

		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			return 0;
		}

		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		void IBindingList.RemoveSort()
		{
		}
	}
}
