using System;

namespace Relations.Data
{
    public class Address: IEquatable<Address>
    {
        public string Street { get; set; }
        public string City { get; set; }

        //public override bool Equals(Address addres)
        //{
        //    return this.Street == addres.Street && this.City == addres.City;
        //}
        public bool Equals(Address other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Street.Equals(other.Street)
                   && this.City.Equals(other.City);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals((Address)obj);
        }

        public static bool operator ==(Address obj1, Address other)
        {
            if (ReferenceEquals(obj1, obj2))
            {
                return true;
            }

            if (ReferenceEquals(obj1, null))
            {
                return false;
            }
            if (ReferenceEquals(obj2, null))
            {
                return false;
            }
            return this.Street.Equals(other.Street)
                  && this.City.Equals(other.City);

        }


}