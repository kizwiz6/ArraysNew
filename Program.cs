using System.Reflection.Metadata;
using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            int threeRating = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {threeRating + 1} is rated three stars.");

            string findName = Array.Find(summerStrut, song => song.Length > 10);

            Console.WriteLine($"The first song that has more than 10 characters in the title is {findName}.");

            Array.Sort(summerStrut);
            string firstSong = summerStrut[0];
            string lastSong = summerStrut[7];
            Console.WriteLine($"The first song in the playlist is now {firstSong}.");
            Console.WriteLine($"The last song in the playlist is now {lastSong}.");


            string[] summerStrutCopy = new string[7];

            // Array.Copy() copies a range of elements from one array to a second array. It takes three parameters: the name of the array to be copied, the new array, and the length of the array elements.
            Array.Copy(summerStrut, summerStrutCopy, 7);

            // Array.Reverse() will switch the order of elements in an entire array. It can also reverse them in a portion of an array, if the overload is used
            Array.Reverse(summerStrutCopy);

            // Array.Clear() sets a range of elements in an array to the default value. It takes three parameters: the name of the array, the starting index of the range to clear, and the number of elements to clear. To clear an entire array, set the index to 0(if it is zero - indexed) and then pass in the length of the array for the third parameter.
                        Array.Clear(summerStrutCopy, 0, summerStrutCopy.Length);
        }
    }
}