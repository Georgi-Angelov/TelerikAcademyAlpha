using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Units_Of_Work
{
    class UnitsOfWork
    {
        private static readonly Dictionary<int, ICollection<Unit>> byPower = new Dictionary<int, ICollection<Unit>>();

        static void Main()
        {
            Dictionary<string, Unit> byName = new Dictionary<string, Unit>();
            Dictionary<string, ICollection<Unit>> byType = new Dictionary<string, ICollection<Unit>>();
            StringBuilder output = new StringBuilder();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParams = command.Split();
                switch (commandParams[0])
                {
                    case "add":
                        Unit unitToAdd = new Unit(commandParams[1], commandParams[2], int.Parse(commandParams[3]));
                        if (byName.ContainsKey(unitToAdd.Name))
                        {
                            output.AppendLine("FAIL: " + unitToAdd.Name + " already exists!");
                            break;
                        }

                        byName.Add(unitToAdd.Name, unitToAdd);

                        if (!byType.ContainsKey(unitToAdd.Type))
                        {
                            byType.Add(unitToAdd.Type, new List<Unit>());
                        }

                        byType[unitToAdd.Type].Add(unitToAdd);

                        if (!byPower.ContainsKey(unitToAdd.Attack))
                        {
                            byPower.Add(unitToAdd.Attack, new List<Unit>());
                        }

                        byPower[unitToAdd.Attack].Add(unitToAdd);

                        output.AppendLine("SUCCESS: " + unitToAdd.Name + " added!");

                        break;
                    case "remove":
                        string name = commandParams[1];

                        if (!byName.ContainsKey(name))
                        {
                            output.AppendLine("FAIL: " + name + " could not be found!");
                            break;
                        }

                        Unit toRemove = byName[name];
                        byName.Remove(name);

                        byType[toRemove.Type].Remove(toRemove);
                        byPower[toRemove.Attack].Remove(toRemove);

                        output.AppendLine("SUCCESS: " + name + " removed!");
                       
                        break;
                    case "find":
                        if (!byType.ContainsKey(commandParams[1]))
                        {
                            output.AppendLine("RESULT:");
                            break;
                        }

                        List<Unit> result = byType[commandParams[1]]
                                         .OrderByDescending(x => x.Attack)
                                         .ThenBy(x => x.Name)
                                         .Take(10)
                                         .ToList();

                        output.AppendLine("RESULT: " + string.Join(", ", result));
                        break;
                    case "power":
                        output.AppendLine(GetByPower(int.Parse(commandParams[1])));
                        break;
                }
            }
            Console.WriteLine(output.ToString().Trim());
        }
        public static string GetByPower(int power)
        {
            int counter = 0;

            List<Unit> topTen = new List<Unit>();

            List<int> keys = byPower.Keys.OrderByDescending(x => x).ToList();

            foreach (int k in keys)
            {
                List<Unit> next = byPower[k].OrderBy(x => x.Name).ToList();

                foreach (Unit item in next)
                {
                    topTen.Add(item);
                    counter++;

                    if (counter >= power)
                    {
                        return "RESULT: " + string.Join(", ", topTen);
                    }
                }
            }

            return "RESULT: " + string.Join(", ", topTen);
        }


    }
    public class Unit : IComparable<Unit>
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int Attack { get; set; }
        public Unit(string name, string type, int attack)
        {
            this.Name = name;
            this.Type = type;
            this.Attack = attack;
        }

        public override string ToString()
        {
            return this.Name + "[" + this.Type + "](" + this.Attack + ")";
        }
        public override bool Equals(object obj)
        {
            Unit objAsUnit = obj as Unit;

            if (objAsUnit == null)
            {
                return false;
            }

            return objAsUnit.Name == this.Name;
        }
        public int CompareTo(Unit other)
        {
            if (this.Attack - other.Attack != 0)
            {
                return other.Attack - this.Attack;
            }

            return other.Name.CompareTo(this.Name);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
