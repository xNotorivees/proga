static void Main1(string[] args)
    {
        List<string> inputList = new List<string> { "qw", "er", "ty", };
        List<string> outputList = GenerateNewList(inputList);

        Console.WriteLine("Input List:");
        PrintList1(inputList);

        Console.WriteLine("\nOutput List:");
        PrintList1(outputList);
    }
static List<string> GenerateNewList(List<string> inputList)
    {
        List<string> outputList = new List<string>();

        for (int i = 0; i < inputList.Count; i++)
        {
            string newItem = "";
            for (int j = i; j >= 0; j--)
            {
                newItem += inputList[j] + " ";
            }
            newItem = newItem.Trim();
            outputList.Add(newItem);
        }

        return outputList;
    }

static void PrintList1(List<string> list)
{
    Console.Write(string.Join(", ", list));
    Console.WriteLine();
}
