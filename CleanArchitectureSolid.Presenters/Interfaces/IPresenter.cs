namespace CleanArchitectureSolid.Presenters.Interfaces
{
    public interface IPresenter<T>
    {
        public T Content { get;  }
    }
}
