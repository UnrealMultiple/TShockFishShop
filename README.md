# 鱼店

指令商店，支持使用金币和物品来购买 物品、召唤boss、召唤入侵、生成NPC、获得buff、调时间 等。

<br>

## 指令

```
/fish list，查看商店;
/fish ask <商品编号>，询价;
/fish buy <商品编号> [件数]，购买;

/fish info, 查询钓鱼信息;

/fish reload, 重载配置;
/fish reset, 重置限量记录（1.4）;

/fish = /fishshop = /fs
```

<br>

## 权限

| 权限 | 说明 |
|---|---|
| fishshop.change | 切换钓鱼任务 |
| fishshop.changesuper | 指定钓鱼任务 |
| fishshop.finish  | 修改钓鱼完成次数 |
| fishshop.reload  | 重载鱼店配置 和 重置限量记录 |
| fishshop.special  | 服主和开发者专用 |

授权示意（服主默认拥有全部权限）：
```shell
/group addperm default fishshop.change
```

<br>

商品配置说明：

[https://www.yuque.com/hufang/bv/tshock-fish-shop](https://www.yuque.com/hufang/bv/tshock-fish-shop)（由于gitee审核太严，经常发不出东西，以后插件说明会在语雀上更新说明）

<br>

爱发电支持：
[https://afdian.net/@hufang360](https://afdian.net/@hufang360)
