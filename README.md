# FishShop 鱼店

- 作者: hufang360
- 出处: [hufang360/TShockFishShop](https://github.com/hufang360/TShockFishShop)
- 一个指令商店，除出售物品外，还支持出售以下自定义商品：

## 指令

### 用户指令
| 指令 | 说明 |
|------|------|
| `/fish list` | 查看商店商品列表 |
| `/fish ask <商品编号>` | 查询商品价格 |
| `/fish buy <商品编号> [件数]` | 购买商品 |
| `/fish info` | 显示钓鱼信息 |

### 管理员指令
| 指令 | 权限 | 说明 |
|------|------|------|
| `/fish reload` | `fishshop.reload` | 重载配置 |
| `/fish reset` | `fishshop.reload` | 重置限量记录（1.4） |
| `/fish special` | `fishshop.special` | 查看特别指令（仅管理员） |
| `/fish finish <次数>` | `fishshop.finish` | 修改自己的渔夫任务完成次数（仅管理员） |
| `/fish change` | `fishshop.change` | 更换今天的任务鱼（仅管理员） |
| `/fish changesuper <物品id\|物品名>` | `fishshop.changesuper` | 指定今天的任务鱼（仅管理员） |
| `/fish docs` | `fishshop.special` | 生成参考文档（仅管理员） |

### 指令别名
| 别名 | 对应指令 |
|------|----------|
| `/fish` | `/fishshop` |
| `/fs` | `/fishshop` |


## 配置
> 配置文件位置：tshock/AutoStoreItems.zh-CN.json
```json5
{
  "name": "鱼店",     // 店铺名字
  "pageSlots": 40,    // 一页显示几个商品
  "rowSlots": 10,     // 一行显示几个商品

  // 鱼店解锁条件，可以配置多个条件
  "unlock":  [
    {
      "name": "渔夫任务",
      "id": 0,         // id为0时会自动通过name去匹配
      "stack": 10     // 数量
    },

    // 插件1.4版 开始可以免写 id和stack
    {"name": "渔夫在场"}
  ],

  // 商品列表
  "shop": [
    {
      "name": "生命水晶",           // 物品名字，可不写，要让插件识别中文物品名，请在启动参数加上 -lang 7；
      "id": 29,                   // 物品id，写0时会根据name匹配物品，配置物品时建议使用物品id；
      "stack": 1,                 // 数量
      "prefix": "",               // 词缀，例如 虚幻
      "limit": "",                // 玩家限量（1.4）
      "serverLimit": "",          // 全服限量（1.4）
      "comment": "",              // 商品备注（1.4）
      "allowGroup": []            // 仅指定某个用户组可购买（不填，代表所有）（1.4）


      "unlock":  [             // 物品解锁条件，同样可以配置多条
        {
          "name": "肉后", // 物品名字，可不写；
          "id": 0,              // 物品id，写0时会根据name匹配j解锁条件；
          "stack": 1
        },
        {
          "name": "生命<400", // 生命<400 是商店特定功能，只能填写name来进行配置
          "id": 0,
          "stack": 1
        }
      ],
      "cost": [                   // 花费，钱 或 用于交易的物品；同样可以配置多条
        {
          "name": "金币",
          "id": 73,               //物品id，目前只有货币这几种物品支持填写文字，其它的都需要填写id
          "stack": 2          // 数量
        }
      ]
    },

    // 1.4 开始可以免写部分默认字段，例如 这条表示 1个墓石碑卖1金币
    {"name": "墓石碑", "cost":[{"name":"金币"}] }
  ]

}
```
详细配置说明请参考：[鱼店配置文档](https://www.yuque.com/hufang/bv/tshock-fish-shop)



## 反馈
- 优先发issued -> 共同维护的插件库：https://github.com/UnrealMultiple/TShockPlugin
- 次优先：TShock官方群：816771079
- 大概率看不到但是也可以：国内社区trhub.cn ，bbstr.net , tr.monika.love'''
