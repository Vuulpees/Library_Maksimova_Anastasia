using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    
    
        public class Team : IComparable<Team>
        {
            public string Name { get; set; }
            public string Address { get; set; }

            public Team(string name, string address)
            {
                Name = name;
                Address = address;
            }

            public int CompareTo(Team other)
            {
                return string.Compare(Name, other.Name);
            }

            public override string ToString()
            {
                return $"Команда: {Name}\nАдрес: {Address}";
            }
        }

        public class Player : IComparable<Player>
        {
            public string FullName { get; set; }
            public string Description { get; set; }

            public Player(string fullName, string description)
            {
                FullName = fullName;
                Description = description;
            }

            public int CompareTo(Player other)
            {
                return string.Compare(FullName, other.FullName);
            }

            public override string ToString()
            {
                return $"Игрок: {FullName}\nОписание: {Description}";
            }
        }
    }



