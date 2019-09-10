using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string>()
            {
                "cartier",
                "manxion",
                "mouse",
                "chevy",
                "fish",
                "xheese",
                "man",
                "alad",
            };

            var wordsBeginningWithA = strings.Where(currentString => currentString.StartsWith("a"));

            var firstWord = strings.FirstOrDefault(currentString => currentString.StartsWith("a"));
            var secondWord = strings.Skip(1).First();
            var anyWordsWithX = strings.Any(currentWord => currentWord.StartsWith("x"));
            var allWordsWithX = strings.All(currentWord => currentWord.StartsWith("x"));

            var transformed = strings.Select(item => $"{item} - transformed");
            var transformedAnimals = strings.Select(item => new Animal { Name = item });

            var letterAAnimals = strings
                .Where(currentString => currentString.StartsWith("a"))
                .Select(item => new Animal { Name = item });

            var groupedStrings = strings
                .GroupBy(currentString => currentString.First());

            strings.OrderByDescending(currentString => currentString.Last());
            strings.OrderBy(currentString => currentString.Last());

            foreach (var grouping in groupedStrings)
            {
                Console.WriteLine($"I'm grouping over the {grouping.Key} group");
                foreach (var currentString in grouping)
                {
                    Console.WriteLine($"{currentString} is in group {grouping.Key}");
                }


                strings.Add("blerg");
                strings.Contains("blarg");



                foreach (var currentString in strings)
                {
                    Console.WriteLine($"Current string is {currentString}.");
                }
                var alphabetWords = new Dictionary<char, string>();
                alphabetWords.Add('1', "apple");
                alphabetWords.Add('5', "baby");
                alphabetWords.Add('7', "catastraphe");

                var seven = alphabetWords['7'];
                alphabetWords['7'] = "dogastrophe";

                foreach (var word in alphabetWords)
                {
                    Console.WriteLine($"The current key is {word.Key} and the value is {word.Value}");
                }

                var hashset = new HashSet<Animal>();
                var tom = new Animal { Age = 12, Color = "golden", Name = "Tom", Type = "dog" };
                var jerry = new Animal { Age = 3, Color = "brown", Name = "Jerry", Type = "elephant" };
                hashset.Add(tom);
                hashset.Add(jerry);
            }
        }

        class Animal
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public string Type { get; set; }
            public int Age { get; set; }
        }
    }

}