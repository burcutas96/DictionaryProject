using DictionaryProject;

MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

myDictionary.Add(1, "Burcu Taş");
myDictionary.Add(2, "Selim Kılıç");
myDictionary.Add(2, "Merve Doğu");

myDictionary.Print(myDictionary);

Console.WriteLine(myDictionary.Count);




