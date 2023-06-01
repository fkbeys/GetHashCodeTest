namespace ConsoleApp1
{

    public class Order : OrderAdvancedClass
    {
        public Order(long id) : base(id)
        {
        }

        public string name { get; set; }

    }

    public abstract class OrderAdvancedClass
    {
        public virtual long Id { get; protected set; }

        protected OrderAdvancedClass()
        {
        }

        protected OrderAdvancedClass(long id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            if (obj is not OrderAdvancedClass other)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (GetUnproxiedType(this) != GetUnproxiedType(other))
                return false;

            if (Id.Equals(default) || other.Id.Equals(default))
                return false;

            return Id.Equals(other.Id);
        }

        public static bool operator ==(OrderAdvancedClass a, OrderAdvancedClass b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(OrderAdvancedClass a, OrderAdvancedClass b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetUnproxiedType(this).ToString() + Id).GetHashCode();
        }

        internal static Type GetUnproxiedType(object obj)
        {
            const string EFCoreProxyPrefix = "Castle.Proxies.";
            const string NHibernateProxyPostfix = "Proxy";

            Type type = obj.GetType();
            string typeString = type.ToString();

            if (typeString.Contains(EFCoreProxyPrefix) || typeString.EndsWith(NHibernateProxyPostfix))
                return type.BaseType;

            return type;
        }
    }
}
