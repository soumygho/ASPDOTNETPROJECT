using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using offsetLibrary;
using System.Web.SessionState;

/// <summary>
/// Summary description for ConstructCost
/// </summary>
public class ConstructCost
{
    ActualCostOperation actualcostops = new ActualCostOperation();
    PrintCostOperation printcostops = new PrintCostOperation();
    DigitalPrintingOperation digitalops = new DigitalPrintingOperation();
    FlexOperation flexops = new FlexOperation();
    IdentitycardOperation identityops = new IdentitycardOperation();
	public ConstructCost()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    /*
     * 1.first create order
     * 2.call getcost
     * 3.call set profit
     * 4.get bill details
     * 5.set cost for the order
     * 6.set order into bill
     * 7.set total value
     */

    public CostTable getCost( bool dtpcost, bool bindingcost,bool profit, bool delivery,Category category,int count,int dtpcount,float distance)
    {
        CostTable cost = null;
        try
        {
            List<ActualCost> actualcosts = actualcostops.readActualcost(category);
            if (actualcosts != null && actualcosts.Count > 0)
            {
                ActualCost actualcost = actualcosts[0];
                cost = new CostTable();
                cost.Totalcost = 0;
                
                if (dtpcost)
                {
                    cost.Dtpcost = actualcost.Dtpcostperpage * dtpcount;
                    cost.Totalcost+=cost.Dtpcost;

                }
                if (bindingcost)
                {
                    cost.Bindingcost = actualcost.Bindingcost * count;
                    cost.Totalcost+= cost.Bindingcost;

                }
                
                if (delivery)
                {
                    cost.Deliverycost = actualcost.Deliverycostperunit * distance;
                    cost.Totalcost+=cost.Deliverycost;
                }
                if (profit)
                {
                    cost.Additionalprofit = actualcost.Profit;
                }
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        return cost;
    }


    public Bill getBillDetails()
    {
        Bill currentbill = null;
        currentbill =(Bill) HttpContext.Current.Session["bill"];
        return currentbill;
    }
    public CostTable setProfit(CostTable cost)
    {
        cost.Additionalprofit = (cost.Totalcost * cost.Additionalprofit) / 100;
        cost.Totalcost += cost.Additionalprofit;
        return cost;

    }

    public Bill setTotalValue()
    {
        Bill currentbill = (Bill)HttpContext.Current.Session["bill"];
        if (currentbill != null && currentbill.Orders != null && currentbill.Orders.Count > 0)
        {
            float totalvalue = 0;
            for (int i = 0; i < currentbill.Orders.Count; i++)
            {
                OrderDetails order = currentbill.Orders[i];
                totalvalue += order.Cost.Totalcost;

            }
            currentbill.Totalamount = totalvalue;
            
        }
        return currentbill;
    }

    public OrderDetails createOrderDetails(String color, String printside, String flexsize, String stampmodelno, String papername, String papersize, int qty, String description, int catid)
    {

        OrderDetails order = new OrderDetails();
        order.Color = color;
        order.Printside = printside;
        order.Flexsize = flexsize;
        order.Stampmodelno = stampmodelno;
        order.Papername = papername;
        order.Size = papersize;
        order.Qty = qty;
        order.Description = description;
        order.Categoryid = catid;
        return order;
    }

    public OrderDetails setCost(OrderDetails order, CostTable cost)
    {
        order.Cost = cost;
        return order;
    }
    public Bill setOrderIntoBill(Bill bill,OrderDetails order)
    {
        bill.Orders.Add(order);
        return bill;
    }

    public CostTable getPrintCostForOffset(CostTable cost,List<PrintCost> printcosts,int dtpcount,int qty)
    {
        //get total no of prints first
        int totalnoofprints = dtpcount * qty;
        try
        {
            //read printcost
            PrintCost printcost = printcostops.getPrintcostByQty(printcosts, totalnoofprints);
            if (printcost != null)
            {
                cost.Printcost = printcost.Printrate;
                cost.Totalcost += printcost.Printrate;
            }

        }
        catch (Exception e)
        {
            throw e;
        }
        //calculate 
        return cost;
    }

    public CostTable getPrintCostForDigitalPrinting(CostTable cost, int dtpcount, int qty)
    {
        int totalnoofprints = dtpcount * qty;
        try
        {
           List< DigitalPrintingCost> printingcosts = digitalops.getPrintingCost();
           if (printingcosts != null && printingcosts.Count > 0)
           {
               cost.Printcost = printingcosts[0].Rateperpage * totalnoofprints;
               cost.Totalcost += cost.Printcost;
           }
        }
        catch (Exception e)
        {
            throw e;
        }
        return cost;
    }

    public CostTable getFlexCost(CostTable cost, int qty, float total)
    {
        try
        {
            List<Flex> flexs = flexops.readFlex();
            if (flexs != null && flexs.Count > 0)
            {
                cost.Printcost = flexs[0].Ratepersquarefeet * qty * total;
                cost.Totalcost += cost.Printcost;
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        return cost;
    }

    public CostTable getIdentityCost(CostTable cost, int qty)
    {
        try
        {
            List<Identitycard> cards = identityops.readIdentityCard();
            if (cards != null && cards.Count > 0)
            {
                cost.Printcost = cards[0].Ratepercard * qty;
                cost.Totalcost += cost.Printcost;
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        return cost;
    }
    PasspostPhotoOperation passportops = new PasspostPhotoOperation();
    public CostTable getPhotoCost(CostTable cost, int qty)
    {
        try
        {
            List<PassportPhoto> photos = passportops.readPassport();
            if (photos != null && photos.Count > 0)
            {
                cost.Printcost = photos[0].Rateperphoto * qty;
                cost.Totalcost += cost.Printcost;
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        return cost;
    }
    DtpOperation dtpops = new DtpOperation();
    public CostTable getXeroxCost(CostTable cost, int qty, int xeroxcount,Dtp dtp)
    {
        try
        {
            List<Dtp> dtps = dtpops.readDtp(dtp);
            if (dtps != null && dtps.Count > 0)
            {
                cost.Printcost = dtps[0].Rateperpage * xeroxcount * qty;
                cost.Totalcost += cost.Printcost;
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        return cost;
    }
    
    RubberStampOperation stampops = new RubberStampOperation();
    public CostTable getStampCost(CostTable cost,RubberStamp stamp,int qty)
    {
        try
        {
            List<RubberStamp> stamps = stampops.readRubberStamp(stamp);
            if(stamps!=null&&stamps.Count>0)
            {
                cost.Printcost = stamps[0].Rate * qty;
                cost.Totalcost += cost.Printcost;
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        return cost;
    }
}
