namespace MyWeb.BLL.Application
{
    public  interface IApplication
    {
        void Add<T>(T t);

        void Delete(long id);

        void Change<T>(T t);

       T   Search<T>();
    }
}
