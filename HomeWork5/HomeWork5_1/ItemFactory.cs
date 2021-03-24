using System;

namespace HomeWork5_1
{
    public class ItemFactory
    {
        private static readonly Random Random = new Random();

        //通过商品type获取对应的商品
        //todo 如何创建id不重复的随机数？
        public static Item GetItem(int itemType)
        {
            switch (itemType)
            {
                case 0:

                    return new Item(Random.Next(1000), new ItemDescription(itemType,
                        10, "大米"));
                case 1:
                    return new Item(Random.Next(1000), new ItemDescription(itemType,
                        20, "牛肉"));

                case 2:

                    return new Item(Random.Next(1000), new ItemDescription(itemType,
                        30, "龙虾"));
                default:
                    throw new Exception($"编号为{itemType}的商品不存在");
            }
        }
    }
}