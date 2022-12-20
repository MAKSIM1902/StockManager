using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TS.EasyStockManager.Common.Enums
{
    public enum TransactionType
    {
        [Display(Name = "Получение Товара")]
        StockIn = 1,
        [Display(Name = "Нет в Наличии")]
        StockOut = 2,
        [Display(Name = "Отгрузка")]
        Transfer = 3
    }
}
