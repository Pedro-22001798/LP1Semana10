using System;
using System.Collections.Generic;

namespace SamePlayer
{
    public class Player
    {
        public PlayerType Type {get; set;}
        public string Name {get; set;}

        public override int GetHashCode()
        {
            return Type.GetHashCode() ^ (Name?.GetHashCode() ?? 0);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Player other = (Player)obj;
            return Type == other.Type && Name == other.Name;            
        }
    }
}