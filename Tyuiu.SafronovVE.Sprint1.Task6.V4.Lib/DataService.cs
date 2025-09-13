using System.Diagnostics.Tracing;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SafronovVE.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string text = value;
            string letterToFind = "нн";

            string[] words = text.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var wordsWithLetter = words.Where(word => word.Contains(letterToFind, StringComparison.OrdinalIgnoreCase));
            List<string> list = new List<string>();
            foreach (var word in wordsWithLetter)
            {
                list.Add(word);
            }
            string res = string.Join(", ", list.ToArray());
            return res;
        }
    }
}