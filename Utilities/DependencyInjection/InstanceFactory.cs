using WindowsForm.Services.Abstract;
using WindowsForm.Services.Concrete;

namespace WindowsForm.Utilities.DependencyInjection
{
    public static class InstanceFactory
    {
        public static T GetInstance<T>() where T : class
        {
            if (typeof(T) == typeof(IPersonService))
            {
                return new PersonService() as T;
            }

            return null;
        }
    }
}
