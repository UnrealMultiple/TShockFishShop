using FishShop.Shop;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;


namespace FishShop;

public class Config
{
    // 商店名称
    public string name = "鱼店";

    // 货架展示容量
    public int pageSlots = 40;

    // 一行展示多少个
    public int rowSlots = 10;

    // 解锁条件
    public List<ItemData> unlock = new List<ItemData>();

    // 货架物品
    public List<ShopItemData> shop = new List<ShopItemData>();


    public static Config Load(string path)
    {
        if (File.Exists(path))
        {
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(path));
        }

        // 读取内嵌配置文件
        var text = utils.FromEmbeddedPath("FishShop.res.config.json");
        var c = JsonConvert.DeserializeObject<Config>(text);

        // 将内嵌配置文件拷出
        File.WriteAllText(path, text);

        return c;
    }

    public static void GenConfig(string path)
    {
        // 将内嵌配置文件拷出
        if (!File.Exists(path)) File.WriteAllText(path, utils.FromEmbeddedPath("FishShop.res.config.json"));
    }

}