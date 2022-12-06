using Kata02_IEquatable_IComparable_Factory;

Console.WriteLine("Create a couple of members");
IMember member1 = Member.Factory.CreateRandom();
Console.WriteLine($"member1: {member1}");
IMember member2 = Member.Factory.CreateRandom();
Console.WriteLine($"member2: {member2}");

Console.WriteLine("Test the copy constructor");
IMember member3 = new Member(member1);
Console.WriteLine($"member3: {member3}");

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

Console.WriteLine("Test the copy constructor");

//I make a cast IMemberList -> MemberList of HiltonMembers to be able to use
//the copy contructor as the list _member is private
IMemberList copyList = new MemberList((MemberList)HiltonMembers);
Console.WriteLine(copyList);
Console.WriteLine(copyList[10]);


