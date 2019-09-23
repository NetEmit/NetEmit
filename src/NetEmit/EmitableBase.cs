using System;
using System.Collections;
using System.Collections.Generic;

namespace NetEmit
{
	public abstract class EmitableBase<T> : IEmitable<T>
		where T : IEmiter, new()
	{
		private readonly SortedList<int, IEmiter> _EmitStack = new SortedList<int, IEmiter>();

		public T Emiter { get; } = new T();

		public int Capacity
		{
			get => _EmitStack.Capacity;
			protected set => _EmitStack.Capacity = value;
		}

		public bool Add(IEmitable<T> emitable)
		{
			try
			{
				//ToDo: Add checks and return false when checks fail.
				_EmitStack.Add(Count + 1, emitable.Emit());
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}

		public bool Add(IEmiter emiter)
		{
			try
			{
				//ToDo: Add checks and return false when checks fail.
				_EmitStack.Add(Count + 1, emiter);
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}

		public bool AddRange(IEmitable<T>[] emitableRange)
		{
			try
			{
				foreach (var emitable in emitableRange)
				{
					//ToDo: Add checks and return false when checks fail.
					_EmitStack.Add(Count + 1, emitable.Emit());
				}
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}

		public bool AddRange(IEmiter[] emiterRange)
		{
			try
			{
				foreach (var emitable in emiterRange)
				{
					//ToDo: Add checks and return false when checks fail.
					_EmitStack.Add(Count + 1, emitable);
				}
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}

		public int Count => _EmitStack.Count;

		public virtual T Emit()
		{
			foreach (var emitable in _EmitStack.Values)
			{
				Emiter.Append(emitable.Result());
			}

			return Emiter;
		}

		public IEmitable<T>[] Get(string name) => throw new NotImplementedException();

		public IEmitable<T>[] Get(Guid guid) => throw new NotImplementedException();

		public bool Remove(IEmitable<T> emitable) => throw new NotImplementedException();

		public IEnumerator<T> GetEnumerator() => GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => _EmitStack.GetEnumerator();
	}
}
