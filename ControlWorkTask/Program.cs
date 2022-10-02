Console.Clear();
string[] massive1 = new string[5] {"123", "56", "hello", "world", "num"};
DecisionTask(massive1);

void DecisionTask(string[] massive1)
{
    Console.Write("[ ");
    for (int i = 0; i < massive1.Length; i++)
    {
        if(massive1[i].Length <= 3)
        {
            Console.Write($"{massive1[i]} ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}