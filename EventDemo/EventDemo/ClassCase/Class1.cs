using System;

namespace EventDemo
{
    public class Class1
    {
        public Class1()
        {
            Suggestion suggestion = new Suggestion();
            suggestion.SuggestionNeeded += SuggestionOnSuggestionNeeded;
        }

        private void SuggestionOnSuggestionNeeded(object sender, Suggestion.SuggestionNeededEventArgs e)
        {
            Console.WriteLine("추리 아이템을 하나씩 입력하세요:");
            e.CardName = Console.ReadLine();

            if (e.CardName.Length < 3)
                e.Canceled = true;
        }
    }
}