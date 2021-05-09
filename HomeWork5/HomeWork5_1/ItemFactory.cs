using System;
using HomeWork5_1.entities;

namespace HomeWork5_1
{
    public static class ItemFactory
    {
        private static readonly Random Random = new Random();

        //通过商品type获取对应的商品
       
        public static Item GetItem(int itemType)
        {
            switch (itemType)
            {
                case 0:
            
                    return new Item(
                        "龙虾", 10);
                case 1:
                    return new Item( "牛肉", 20);
            
                case 2:
            
                    return new Item( "猪肉", 30);
                default:
                    throw new Exception($"编号为{itemType}的商品不存在");
            }
            
        }
    }
}