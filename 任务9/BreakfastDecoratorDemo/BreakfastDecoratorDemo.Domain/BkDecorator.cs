using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreakfastDecoratorDemo.Domain
{
    public class BkDecorator : Breakfast
    {
        /// <summary>
        /// 添加的早餐
        /// </summary>
        private Breakfast _Bk;

        public BkDecorator(Breakfast breakfast)
        {
            this._Bk = breakfast;
        }

        /// <summary>
        /// 计算价格
        /// </summary>
        public override double GetPrice()
        {
            return _Bk.GetPrice();
        }
    }
}