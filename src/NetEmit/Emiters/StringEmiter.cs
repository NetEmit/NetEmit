using System.Text;

namespace NetEmit.Emiters;

public class StringEmiter : IEmitter
{
	public StringEmiter()
	{
	}

	public StringEmiter(object initial)
	{
		Append(initial);
	}

	private readonly StringBuilder _Builder = new();

	public void Append(object addee) => _Builder.Append(addee);

	public void AppendLine(object line) => _Builder.AppendLine(line.ToString());

	public void AppendLine() => _Builder.AppendLine();

	public IEmitter GetEmitter() => this;

	public object Result() => _Builder.ToString();

	public override string ToString() => (string)Result();
}