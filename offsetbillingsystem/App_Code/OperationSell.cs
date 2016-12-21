using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using offsetLibrary;

/// <summary>
/// Summary description for OperationSell
/// </summary>
public class OperationSell
{
    BillOperation billops = new BillOperation();
    CustomerOperation custops = new CustomerOperation();
    ReceiptOperation receiptops = new ReceiptOperation();
	public OperationSell()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public bool onspotSellNow(Bill bill)
    {
        bool flag = false;

        try
        {
            bill.Billdate = DateTime.Today.ToShortDateString();
            bill.Transmonth = DateTime.Today.Month;
            bill.Transyear = DateTime.Today.Year;
            bill.Finalamount = bill.Totalamount - bill.Cons;
            bill =  billops.insertIntoBill(bill);
            if(bill!=null)
            {
              flag = true;
            }
          Transaction transaction = new Transaction();
          transaction.Description = "ONSPOT BILL";
          transaction.Method = "CASH";
          BillPaymentDetails payment = new BillPaymentDetails();
          payment.Billid = bill.Id;
          payment.Paidamount = bill.Finalamount;
          if (bill.Userid != 0)
          {
              payment.Outstanding = bill.Finalamount;
          }
          payment.Finalamount = bill.Finalamount;
          payment.Transdate = DateTime.Today.ToShortDateString();
          payment.Transmonth = DateTime.Today.Month;
          payment.Transyear = DateTime.Today.Year;
            if(flag)
            {
                flag = billops.payBillagainstSpecificBill(payment, transaction, bill.Customer);
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        return flag;
    }

    public Receipt payNow(Bill bill,float paidamount)
    {
        Receipt receipt = null;
        bool flag = false;
        try
        {
            //insert into user if new user
            CustomerDetails customer = bill.Customer;
            if (customer.Customerid == 0)
            {
                flag = custops.insertintoCustomer(customer);
                if (flag)
                {
                    List<CustomerDetails> customers = custops.readCustomerByNameMobNOAndAddress(customer);
                    if (customers != null && customers.Count > 0)
                    {
                        customer = customers[0];
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            else
            {
                flag = true;
            }
            if (flag)
            {
                flag = false;
                bill.Billdate = DateTime.Today.ToShortDateString();
                bill.Transmonth = DateTime.Today.Month;
                bill.Transyear = DateTime.Today.Year;
                bill.Finalamount = bill.Totalamount - bill.Cons;
                bill = billops.insertIntoBill(bill);
                if (bill != null)
                {
                    flag = true;
                }
                Transaction transaction = new Transaction();
                transaction.Description = "SELL";
                transaction.Method = "CASH";
                BillPaymentDetails payment = new BillPaymentDetails();
                payment.Billid = bill.Id;
                payment.Paidamount = paidamount;
                
                    payment.Outstanding = bill.Finalamount-paidamount;
                
                payment.Finalamount = bill.Finalamount;
                payment.Transdate = DateTime.Today.ToShortDateString();
                payment.Transmonth = DateTime.Today.Month;
                payment.Transyear = DateTime.Today.Year;
                payment.Outstanding = payment.Finalamount - payment.Paidamount;
                if (flag)
                {
                    flag = false;
                    flag = billops.payBillagainstSpecificBill(payment, transaction, bill.Customer);
                    if (flag)
                    {
                        List<Receipt> receipts = receiptops.readReceipt(bill);
                        if (receipts != null && receipts.Count > 0)
                        {
                            receipt = receipts[0];
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        return receipt;
    }
    QuotationOperation quotationops = new QuotationOperation();
    Quotation quotation = null;
    public Quotation saveQuote(Bill bill)
    {
        
        bool flag = false;
        if (bill != null)
        {
            try
            {
                CustomerDetails customer = bill.Customer;
            if (customer.Customerid == 0)
            {
                flag = custops.insertintoCustomer(customer);
                if (flag)
                {
                    List<CustomerDetails> customers = custops.readCustomerByNameMobNOAndAddress(customer);
                    if (customers != null && customers.Count > 0)
                    {
                        customer = customers[0];
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            else
            {
                flag = true;
            }
            if (flag)
            {
                quotation = new Quotation();
                quotation.Customer = bill.Customer;
                quotation.Orders = bill.Orders;
                quotation.Quotedate = DateTime.Today.ToShortDateString();
                quotation.Totalamount = bill.Totalamount;
                quotation.Transmonth = DateTime.Today.Month;
                quotation.Transyear = DateTime.Today.Year;
               quotation = quotationops.insertIntoQuotation(quotation);
               
            }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        return quotation;
    }
}
