string[] people = {"John","Sam","Laury"};
string[] nju = new string[3];
int size = people.Length;
for (int i = 0; i < size; i++)
{
    var len = people[i].Length;
    if (len <= 3)
    {
        nju[i] = people[i];
    }
}
    Console.WriteLine($"va2: {nju[0]}, {nju[1]}, {nju[2]}");