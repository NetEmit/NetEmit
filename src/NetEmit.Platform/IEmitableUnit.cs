namespace NetEmit.Platform;

public interface IEmitableUnit<T> : IEmitable<T>
	where T : IEmitter, new()
{
	IEmitable<T> EmitableUnit { get; }
}