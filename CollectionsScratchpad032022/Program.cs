

List<int> numbers = new List<int> { 9, 8, 7, 6, 5 };

//Console.WriteLine(numbers[3]);
//numbers[2] = 500;

//numbers.Sort();

numbers.Insert(1, 42);
numbers.Add(100);
numbers.Remove(5);
numbers.RemoveAt(5);
numbers.Sort();
numbers.Reverse();



//string input;
//List<string> words = new List<string>();
//do
//{
//    Console.WriteLine("Enter a word, or press Enter to stop:");
//    input = Console.ReadLine();
//    if (!string.IsNullOrEmpty(input))
//    {
//        words.Add(input);
//    }
//} while (!string.IsNullOrEmpty(input));

//words.Reverse();

//foreach(string word in words)
//{
//    Console.WriteLine(word);
//}



Dictionary<int, string> dict = new Dictionary<int, string>();
dict[0] = "Hello";
dict[1] = "Cruel";
dict[2] = "World";
dict[-42] = "Life";
dict[27] = "Universe";
dict[9000] = "Everything";

dict[27] = "Space is really big";

dict[100] = "Hello";
//dict.Add(100, "Goodbye");

foreach(KeyValuePair<int, string> kvp in dict)
{
    int key = kvp.Key;
    string value = kvp.Value;

    Console.WriteLine($"Key: {key} | Value: {value}");
}

foreach(int key in dict.Keys)
{
    Console.WriteLine(key);
}

foreach(string val in dict.Values)
{
    Console.WriteLine(val);
}

Console.WriteLine(dict.ContainsKey(3));
Console.WriteLine(dict.ContainsValue("Life"));



//Console.WriteLine("Type a sentence:");
//string sentence = Console.ReadLine();
//string[] words = sentence.Split(' ');

//Dictionary<string, int> wordCounts = new Dictionary<string, int>();
//foreach(string word in words)
//{
//    if (wordCounts.ContainsKey(word))
//    {
//        wordCounts[word] += 1;
//    }
//    else
//    {
//        wordCounts[word] = 1;
//    }
//}

//wordCounts.Remove("the");



Dictionary<string, double> grades = new Dictionary<string, double>
{
    { "Sam", 87.4 },
    { "Dean", 68.7 },
    { "Bobby", 98.7 }
};





//Queue<int> queue = new Queue<int>();

//// Number: Add to queue
//// checkout: "check out" the oldest number (remove from queue)
//do
//{
//    string input = Console.ReadLine();

//    if (input == "checkout")
//    {
//        int customer = queue.Dequeue();
//        Console.WriteLine(customer);
//    }
//    else
//    {
//        int newCustomer = int.Parse(input);
//        queue.Enqueue(newCustomer);
//    }

//} while (queue.Count > 0);
//Console.WriteLine("All numbers have checked out");



//Stack<int> stack = new Stack<int>();

//// Number: Add to queue
//// checkout: "check out" the oldest number (remove from queue)
//do
//{
//    string input = Console.ReadLine();

//    if (input == "checkout")
//    {
//        int customer = stack.Pop();
//        Console.WriteLine($"Popped: {customer}");
//    }
//    else
//    {
//        int newCustomer = int.Parse(input);
//        stack.Push(newCustomer);
//    }

//} while (stack.Count > 0);
//Console.WriteLine("All numbers have checked out");



string parentheses = "(()))((())())";

Stack<char> parenStack = new Stack<char>();
bool valid = true;
foreach(char c in parentheses)
{
    if (c == '(')
    {
        parenStack.Push(c);
    }
    if (c == ')' && parenStack.Count > 0)
    {
        parenStack.Pop();
    }
    else if (c == ')')
    {
        valid = false;
        break;
    }
}

if (parenStack.Count == 0 && valid)
{
    Console.WriteLine("Balanced");
}
else
{
    Console.WriteLine("Unbalanced");
}




Console.WriteLine("Done");



