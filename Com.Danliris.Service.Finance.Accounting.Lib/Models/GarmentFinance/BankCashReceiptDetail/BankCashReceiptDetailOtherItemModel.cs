﻿using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.Danliris.Service.Finance.Accounting.Lib.Models.GarmentFinance.BankCashReceiptDetail
{
    public class BankCashReceiptDetailOtherItemModel : StandardEntity
    {
        public int ChartOfAccountId { get; set; }
        [MaxLength(32)]
        public string ChartOfAccountCode { get; set; }
        [MaxLength(255)]
        public string ChartOfAccountName { get; set; }

        public int CurrencyId { get; set; }
        [MaxLength(32)]
        public string CurrencyCode { get; set; }
        public decimal CurrencyRate { get; set; }

        public decimal Amount { get; set; }

        public virtual int BankCashReceiptDetailId { get; set; }
        [ForeignKey("BankCashReceiptDetailId")]
        public virtual BankCashReceiptDetailModel BankCashReceiptDetailModel { get; set; }
    }
}
