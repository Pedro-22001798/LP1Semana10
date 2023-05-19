using System;
namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// and override GetHashCode() and Equals()
    /// </summary>
    public class Loot: IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        public int CompareTo(Loot other)
        {
            if(other == null) return 1;
            if(string.Compare(other.Kind.ToString(),this.Kind.ToString()) == 0)
            {
                if(other.Kind == this.Kind)
                {
                    if(other.Value == this.Value)
                    {
                        return string.Compare(other.Description,this.Description);
                    }
                    else
                    {
                        return (int)(other.Value - this.Value);
                    }
                }
                else
                {
                    return other.Kind - this.Kind;
                }
            }
            else
            {
                return -(string.Compare(other.Kind.ToString(),this.Kind.ToString()));
            }
        }

        public override int GetHashCode()
        {
            return Kind.GetHashCode() ^ (this.ToString()?.GetHashCode() ?? 0);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Loot other = (Loot)obj;
            return Description == other.Description && Value == other.Value && Kind == other.Kind;            
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";
    }
}