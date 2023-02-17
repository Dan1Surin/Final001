
string[] Array = {"1234234","dsafd","=)","dfsfa","dd","324","3","d","asdfvc"};

int size=0;
int i=0;
while (i<Array.Length)
{
    if (Array[i].Length<3)
    {
        size++;
    }
    i++;
}

string[] NewArray = new string[size];

i=0;
int a=0;
while (i<Array.Length)
{
    if (Array[i].Length<3)
    {
        NewArray[a] = Array[i];
        a++;
    }
    i++;
}

Console.WriteLine(string.Join(" , ",NewArray));