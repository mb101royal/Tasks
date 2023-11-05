namespace tlist.Models
{
	internal class CustomList<T>
	{
		int _size;
		public int Count { get => _size; }
		const int DefaultCapacity = 4;
		T[] _items;

		public CustomList()
		{
			_items = new T[DefaultCapacity];
		}
		// Add
		public void Add(T item)
		{
			if (_size == _items.Length)
			{
				EnsureCapacity(_size + 1);
			}
			_items[_size++] = item;
		}
		// Clear
		public void Clear()
		{
			Array.Clear(_items, 0, _size);
			_size = 0;
		}
		// Exist
		public bool Exist(T item)
		{
			for (int i = 0; i < _items.Length; i++)
			{
				if (_items[i].Equals(item))
				{
					return true;
				}
			}
			return false;
		}
		// Remove At
		public void RemoveAt(int index)
		{
			if (index >= _size || index < 0)
			{
				throw new IndexOutOfRangeException("Index is out of range.");
			}

			for (int i = index; i < _size - 1; i++)
			{
				_items[i] = _items[i + 1];
			}
			_size--;
		}
		// Remove
		public bool Remove(T item)
		{
			int index = IndexOf(item);
			if (index >= 0)
			{
				RemoveAt(index);
				return true;
			}
			return false;
		}
		// Reverse
		public void Reverse()
		{
			int left = 0;
			int right = _size - 1;

			while (left < right)
			{
				T temp = _items[left];
				_items[left] = _items[right];
				_items[right] = temp;

				left++;
				right--;
			}
		}
		// Index of
		public int IndexOf(T item)
		{
			for (int i = 0; i < _size; i++)
			{
				if (_items[i].Equals(item))
				{
					return i;
				}
			}
			return -1;
		}
		// Last index of
		public int LastIndexOf(T item)
		{
			for (int i = _size - 1; i >= 0; i--)
			{
				if (_items[i].Equals(item))
				{
					return i;
				}
			}
			return -1;
		}
		// Indexer
		public T this[int index]
		{
			get
			{
				if (index >= _size || index < 0)
				{
					throw new IndexOutOfRangeException("Index is out of range.");
				}
				return _items[index];
			}
			set
			{
				if (index >= _size || index < 0)
				{
					throw new IndexOutOfRangeException("Index is out of range.");
				}
				_items[index] = value;
			}
		}
		// Is there enough space?
		void EnsureCapacity(int min)
		{
			if (_items.Length < min)
			{
				int newCapacity = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;
				if (newCapacity < min)
				{
					newCapacity = min;
				}
				Array.Resize(ref _items, newCapacity);
			}
		}
	}
}