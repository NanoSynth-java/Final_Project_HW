string[] people = {"Khalid Sultan","Zuhayr Arafat","Tabari Kazi","Majid Demian","Kaiden Abu","Shimaa Shabazz","Afya Zaki","Faazila Salman","Roheen Can","Noreen Shareef"};
int size = people.Length;
string[] nju = new string[size];
for (int i = 0; i < size; i++)
{
    var len = people[i].Length;
    if (len <= 11)
    {
        nju[i] = people[i];
    }
    Console.WriteLine($"{nju[i]}");
}