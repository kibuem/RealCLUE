using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    static class Suggestion
    {
//        private List<Card> _suspects;
//
//        public Suggestion(RoomId roomId)
//        {
//            MakeSuggestion(roomId);
//        }
//
//        public bool Check()
//        {
//            throw new NotImplementedException("Suggestion.Check");
//        }

        public static List<Card> MakeSuggestion(RoomId roomId)
        {
            string suggestion;

            if (suggestions.Count >= 3)
            {
                //TODO 추리에 반박하는 이벤트를 실행한다


                return false;
            }
            //            
            //                SuggestionNeededEventArgs args = new SuggestionNeededEventArgs();
            //            OnSuggestionNeededForOut(args);
            //
            //            if (args.Canceled)
            //                return;
            //
            //            suggestion = args.CardName;
            //
            //

            List<Card> candidates = Deck.Instance.GetCandidates(roomId);


            #region For Console
            if (!roomObjs.Keys.ToArray().Contains(suggestion))
            {
                Console.WriteLine("추리 아이템을 잘못 입력했습니다, 다시 입력하세요");
                return true;
            }
            #endregion

            //Place 타입이면 추리를 무시한다

            Card card = candidates.Find(x => x.CardName == suggestion);

            if (card.CardType == CardType.Place)
            {
                return true;
            }

            //이미 한 추리이면 제거한다
            if (suggestions.Contains(suggestion))
            {
                suggestions.Remove(suggestion);
                return true;
            }
            //처음으로 한 추리이면 추가한다
            else
            {
                suggestions.Add(suggestion);
                return true;
            }


        }

        #region SuggestionNeeded event things for C# 3.0
        public event EventHandler<SuggestionNeededEventArgs> SuggestionNeeded;

        protected virtual void OnSuggestionNeeded(SuggestionNeededEventArgs e)
        {
            if (SuggestionNeeded != null)
                SuggestionNeeded(this, e);
        }

        private SuggestionNeededEventArgs OnSuggestionNeeded(string cardName, bool canceled)
        {
            SuggestionNeededEventArgs args = new SuggestionNeededEventArgs(cardName, canceled);
            OnSuggestionNeeded(args);

            return args;
        }

        private SuggestionNeededEventArgs OnSuggestionNeededForOut()
        {
            SuggestionNeededEventArgs args = new SuggestionNeededEventArgs();
            OnSuggestionNeeded(args);

            return args;
        }

        public class SuggestionNeededEventArgs : EventArgs
        {
            public string CardName { get; set; }
            public bool Canceled { get; set; }

            public SuggestionNeededEventArgs()
            {
            }

            public SuggestionNeededEventArgs(string cardName, bool canceled)
            {
                CardName = cardName;
                Canceled = canceled;
            }
        }
        #endregion
    }
}
