namespace NetEmit
{
	public interface IEmiter
	{
		void Append(object addee);

		IEmiter GetEmiter();

		object Result();
	}
}
