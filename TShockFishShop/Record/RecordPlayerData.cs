﻿using System.Collections.Generic;
using System.ComponentModel;

namespace FishShop.Record
{
    public class RecordPlayerData
    {
        /// <summary>
        /// 玩家名
        /// </summary>
        [DefaultValue("")]
        public string name = "";

        /// <summary>
        /// 铜币消耗
        /// </summary>
        public int costMoney = 0;

        /// <summary>
        /// 鱼消耗
        /// </summary>
        public int costFish = 0;

        /// <summary>
        /// 玩家购买物品数据
        /// </summary>
        public List<RecordData> datas = new List<RecordData>();

        public RecordPlayerData(string plrName)
        {
            name = plrName;
        }
    }
}