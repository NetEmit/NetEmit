using System.Text;

namespace NetEmit.Emiters
{
	public class StringEmiter : IEmiter
	{
		public StringEmiter()
		{
		}

		public StringEmiter(object initial)
		{
			Append(initial);
		}

		private readonly StringBuilder _Builder = new StringBuilder();

		public void Append(object addee) => _Builder.Append(addee);

		public void AppendLine(object line) => _Builder.AppendLine(line.ToString());

		public void AppendLine() => _Builder.AppendLine();

		public IEmiter GetEmiter() => this;

		public object Result() => _Builder.ToString();

		public override string ToString() => (string)Result();
	}
}
