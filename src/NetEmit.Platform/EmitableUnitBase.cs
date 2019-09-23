using NetEmit.Emiters;

namespace NetEmit.Platform
{
	public abstract class EmitableUnitBase<T> : EmitableBase<StringEmiter>, IEmitableUnit<StringEmiter>
		where T : IEmiter, new()
	{
		public IEmitable<StringEmiter> EmitableUnit { get; }

		public EmitableUnitBase(IEmitable<StringEmiter> emitableUnit)
		{
			EmitableUnit = emitableUnit;
		}
	}
}
