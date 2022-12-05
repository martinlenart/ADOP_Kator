using Kata02_IEquatable_IComparable_Factory;

Console.WriteLine("Create a couple of members");
IMember member1 = Member.Factory.CreateRandom();
Console.WriteLine($"member1: {member1}");
IMember member2 = Member.Factory.CreateRandom();
Console.WriteLine($"member2: {member2}");

Console.WriteLine("\nCreate a 20 Hilton members");
IMemberList HiltonMembers = MemberList.Factory.CreateRandom(20);
HiltonMembers.Sort();
Console.WriteLine(HiltonMembers);

Console.WriteLine("\nCreate a 20 Radisson members");
IMemberList RadissonMembers = MemberList.Factory.CreateRandom(20);
RadissonMembers.Sort();
Console.WriteLine(RadissonMembers);

Console.WriteLine($"\nHilton member[0]: {HiltonMembers[0]}");
Console.WriteLine($"Radisson member[0]: {RadissonMembers[0]}");
Console.WriteLine();
