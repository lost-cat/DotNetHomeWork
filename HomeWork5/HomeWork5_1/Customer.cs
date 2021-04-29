using System;

namespace HomeWork5_1
{
    [Serializable]
    public class Customer
    {
        public Customer()
        {
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(int customerId,string name, string address)
        {
            CustomerId = customerId;
            Name = name;
            Address = address;
        }

        private bool Equals(Customer other)
        {
            return Name == other.Name && Address == other.Address;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Customer) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (Address != null ? Address.GetHashCode() : 0);
            }
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}";
        }
    }
}