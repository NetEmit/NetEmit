using System;
using System.Collections.Generic;

namespace NetEmit
{
  public interface IEmitable<T> : IEnumerable<T>
    where T : IEmitter, new()
  {
    bool Add(IEmitable<T> emitable);

    bool Add(IEmitter emitter);

    bool AddRange(IEmitable<T>[] emitableRange);

    bool AddRange(IEmitter[] emitterRange);

    bool Remove(IEmitable<T> emitable);

    IEmitable<T>[] Get(string name);

    IEmitable<T>[] Get(Guid guid);

    int Count { get; }

    int Capacity { get; }

    T Emit();
  }
}
