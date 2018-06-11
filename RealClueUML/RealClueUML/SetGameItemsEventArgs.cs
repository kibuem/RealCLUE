using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealClueUML
{
    public class SetGameItemsEventArgs
    {
        /// <summary>
        /// 카드타입(Key), GetAllItems로 가져온 각 타입별 카드(Value)
        /// </summary>
        public System.Collections.Generic.Dictionary<System.Enum, List<string>> _clueDictionary;
    }
}