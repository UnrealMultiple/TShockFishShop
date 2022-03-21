using System.Collections.Generic;
using System;
using TShockAPI;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace FishShop
{
    public class MyUtils
    {
        public static List<string> moonPhases = new List<string>() {"满月","亏凸月","下弦月","残月","新月","娥眉月","上弦月","盈凸月"};

        public static void init()
        {
            // 支持第一分形
            // 清空弃用物品清单
            Array.Clear(ItemID.Sets.Deprecated, 0, ItemID.Sets.Deprecated.Length-1);
        }
        // public static string GetItemDescByShopItem(ShopItem item)
        // {
        //     return GetItemDesc(item.name, item.id, item.stack, item.prefix);
        // }
        public static string GetItemDesc(string name="", int id=0, int stack=1, string prefix="", bool realPlayer=true)
        {
            if (id==0)
                return "";

            string s = "";

            // https://terraria.fandom.com/wiki/Chat
            // [i:29]   数量
            // [i/s10:29]   数量
            // [i/p57:4]    词缀

            // -24~5124 为泰拉原版的物品id
            // <-24 为本插件自定义id
            if( id <-24 )
            {
                s = IDSet.GetNameByID(id, prefix);
            } else {
                if(stack>1)
                {
                    s = $"[i/s{stack}:{id}]";
                } else {
                    int num = 0;
                    if( int.TryParse( prefix, out num) && num!=0 )
                    {
                        prefix = GetPrefixInt(prefix).ToString();
                        s = $"[i/p{prefix}:{id}]";
                    } else {
                        s = $"[i:{id}]";
                    }
                }
            }

            return s;
        }

        private static int GetPrefixInt(string prefix)
        {
            int num = 0;
            if ( int.TryParse( prefix, out num ) )
                return num;
            else
                return AffixNameToPrefix(prefix);
        }
        
        public static string GetMoneyDesc(int price){
            string msg = "";

            // 铂金币
            float num = price/1000000;
            int stack = (int)Math.Floor( num );
            if( stack>0 ){
                price -= stack*1000000;
                msg = $"[i/s{stack}:74]";
            }

            // 金币
            num = price/10000;
            stack = (int)Math.Floor( num );
            if( stack>0 ){
                price -= stack*10000;
                msg += $"[i/s{stack}:73]";
            }

            // 银币
            num = price/100;
            stack = (int)Math.Floor( num );
            if( stack>0 ){
                price -= stack*100;
                msg += $"[i/s{stack}:72]";
            }

            // 铜币
            if( price>0 ){
                msg += $"[i/s{price}:71]";
            }

            return msg;
        }
        // 数字补零
        public static string AlignZero(int num){
            if( num<10 ){
                return $"00{num}";
            } else if(num<100) {
                return $"0{num}";
            } else {
                return $"{num}";
            }
        }

        public static int AffixNameToPrefix( string affixname )
        {
            switch (affixname)
            {
                case "大": return 1;
                case "巨大": return 2;
                case "危险": return 3;
                case "凶残": return 4;
                case "锋利": return 5;
                case "尖锐": return 6;
                case "微小": return 7;
                case "可怕": return 8;
                case "小": return 9;
                case "钝": return 10;
                case "倒霉": return 11;
                case "笨重": return 12;
                case "可耻": return 13;
                case "重": return 14;
                case "轻": return 15;
                case "精准": return 16;
                case "迅速": return 17;
                case "急速": return 18;
                case "恐怖": return 19;
                case "致命-远程": return 20;
                case "可靠": return 21;
                case "可畏": return 22;
                case "无力": return 23;
                case "粗笨": return 24;
                case "强大": return 25;
                case "神秘": return 26;
                case "精巧": return 27;
                case "精湛": return 28;
                case "笨拙": return 29;
                case "无知": return 30;
                case "错乱": return 31;
                case "威猛": return 32;
                case "禁忌": return 33;
                case "天界": return 34;
                case "狂怒": return 35;
                case "锐利": return 36;
                case "高端": return 37;
                case "强力": return 38;
                case "碎裂": return 39;
                case "破损": return 40;
                case "粗劣": return 41;
                case "迅捷": return 42;
                case "致命": return 43;
                case "灵活": return 44;
                case "灵巧": return 45;
                case "残暴": return 46;
                case "缓慢": return 47;
                case "迟钝": return 48;
                case "呆滞": return 49;
                case "惹恼": return 50;
                case "凶险": return 51;
                case "狂躁": return 52;
                case "致伤": return 53;
                case "强劲": return 54;
                case "粗鲁": return 55;
                case "虚弱": return 56;
                case "无情": return 57;
                case "暴怒": return 58;
                case "神级": return 59;
                case "恶魔": return 60;
                case "狂热": return 61;
                case "坚硬": return 62;
                case "守护": return 63;
                case "装甲": return 64;
                case "护佑": return 65;
                case "奥秘": return 66;
                case "精确": return 67;
                case "幸运": return 68;
                case "锯齿": return 69;
                case "尖刺": return 70;
                case "愤怒": return 71;
                case "险恶": return 72;
                case "轻快": return 73;
                case "快速": return 74;
                case "狂野": return 77;
                case "鲁莽": return 78;
                case "勇猛": return 79;
                case "暴力": return 80;
                case "传奇": return 81;
                case "虚幻": return 82;
                case "神话": return 83;
            }

            // 纯数字
            int num = 0;
            if( int.TryParse(affixname, out num) )
            {
                if( num<=83 && num>0 )
                {
                    return num;
                }
            }

            return 0;
        }


        public static void updatePlayerSlot(TSPlayer player, Item item, int slotIndex){
            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, NetworkText.FromLiteral(item.Name), player.Index, slotIndex, (float)item.prefix);
            NetMessage.SendData((int)PacketTypes.PlayerSlot, player.Index, -1, NetworkText.FromLiteral(item.Name), player.Index, slotIndex, (float)item.prefix);
        }


    }

    class Log{
        public static void info(string msg){
            TShock.Log.ConsoleInfo("[fishshop]: "+msg);
        }
    }
}