using System.Reflection;
using System.Windows.Input;

namespace Cosmetics_store.Application.UnitOfWork
{
    public class UnitOfWorkAttributeManager
    {
        private readonly HashSet<string> unitofWorkMethods;
        public UnitOfWorkAttributeManager()
        {
            unitofWorkMethods = new HashSet<string>();
            SetValue();
        }
        private void SetValue()
        {
            var targets = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsAssignableTo(typeof(ICommand)) && !x.IsInterface).SelectMany(m => m.GetMethods()).Where(x => x.GetCustomAttributes().Any(x => x is UnitOfWorkAttribute));
            foreach (var target in targets)
            {
                var targetName = "I" + target.DeclaringType.Name + "/" + target.Name;
                unitofWorkMethods.Add(targetName);
            }
        }
        public bool HasValue(string targetName)
        {
            return unitofWorkMethods.TryGetValue(targetName, out _);
        }
    }
}
