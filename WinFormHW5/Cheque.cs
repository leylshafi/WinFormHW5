using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormHW5;

public class Cheque
{


    public Guid ChequeCode { get; set; }
    public string? Information { get; set; }
    public DateTime Time { get; set; }
    public string? CashierName { get; set; }

    public Cheque(Guid chequeCode, string? information, DateTime time, string? cashierName)
    {
        ChequeCode = chequeCode;
        Information = information;
        Time = time;
        CashierName = cashierName;
    }

    public override string ToString() => $@"
Code: {ChequeCode},
Full information: {Information},
Time: {Time},
Cashier Name: {CashierName}";
}
