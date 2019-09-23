namespace NetEmit.Platform
{
	public interface IEmitableUnit<T> : IEmitable<T>
		where T : IEmiter, new()
	{
		IEmitable<T> EmitableUnit { get; }
	}
}
