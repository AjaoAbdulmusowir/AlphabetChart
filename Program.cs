static void AlphabetsChart()
{   
    Dictionary<char, string> alphabets = new Dictionary<char, string>
    {
        {'A', "Apple"},
        {'B', "Ball"},
        {'C', "Cow"},
        {'D', "Dog"},
        {'E', "Egg"},
        {'F', "Fan"},
        {'G', "Gun"},
        {'H', "House"},
        {'I', "Ice cream"},
        {'J', "Jug"},
        {'K', "Kettle"},
        {'L', "Lion"},
        {'M', "Mango"},
        {'N', "Nose"},
        {'O', "Orange"},
        {'P', "Prince"},
        {'Q', "Queen"},
        {'R', "Rabbit"},
        {'S', "Snail"},
        {'T', "Toy"},
        {'U', "Umbrella"},
        {'V', "Van"},
        {'W', "Watch"},
        {'X', "X-mas"},
        {'Y', "Yatch"},
        {'Z', "Zebra"}
    };
    for (int i = 0; i < alphabets.Count; i++)
    {
        KeyValuePair<char, string> pair = alphabets.ElementAt(i);
        Console.WriteLine($"{i+1}. {pair.Key} for {pair.Value}");
    }
}
AlphabetsChart();