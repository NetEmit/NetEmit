namespace NetEmit
{
  public interface IEmitter
  {
    void Append(object addee);

    IEmitter GetEmitter();

    object Result();
  }
}
