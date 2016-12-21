﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class identitycardsell : System.Web.UI.Page
{
    CustomerDetails customer = null;
    CustomerOperation custops = new CustomerOperation();
    ConstructCost construct = new ConstructCost();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["bill"] != null)
        {


            Bill bill = (Bill)Session["bill"];
            customer = bill.Customer;
            if (customer.Customername.Equals(""))
            {
                CheckBox7.Checked = true;
                CheckBox7.Enabled = false;
                disableTexts();
            }
            else
            {
                CheckBox7.Checked = false;

                TextName.Text = customer.Customername;
                TextAddress.Text = customer.CustomerAddress;
                TextEmail.Text = customer.Customeremail;
                TextMobNo.Text = customer.Customermobno;
                userid.Text = customer.Customerid.ToString();
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        prepareOrder();
        Response.Redirect("~/SellSummary.aspx");
    }
    private void disableTexts()
    {
        TextName.Enabled = false;
        TextEmail.Enabled = false;
        TextMobNo.Enabled = false;
        TextAddress.Enabled = false;

    }
    private void enableTexts()
    {
        TextName.Enabled = true;
        TextEmail.Enabled = true;
        TextMobNo.Enabled = true;
        TextAddress.Enabled = true;
    }

    private void prepareOrder()
    {
        try
        {
          //  Session["bill"] = null;
            Bill bill = null;
            //get customer
            if (customer == null)
            {
                if (!CheckBox7.Checked)
                {
                    if (userid.Text != null)
                    {
                        customer = new CustomerDetails();
                        customer.Customerid = Int32.Parse(userid.Text.ToString());
                        customer = custops.readCustomers(customer)[0];
                    }
                }
                else
                {
                    customer = new CustomerDetails();
                    customer.Customerid = 0;
                }

            }
            //get bill if applicable
            if (construct.getBillDetails() == null)
            {
                bill = new Bill();
                bill.Customer = customer;
                bill.Billdate = DateTime.Today.ToShortDateString();
                bill.Orders = new List<OrderDetails>();
                Session["bill"] = bill;
            }
            else
            {
                bill = (Bill)Session["bill"];
            }
            //create order
            OrderDetails order = constructOrder();
            //calculate totalnoofpagesperunit

            Category cat = new Category();
            cat.Id = Int32.Parse(categoryid.Value.ToString());
            float distance = 0;
            if (CheckBox5.Checked)
            {
                distance = float.Parse(Textdistance.Text);
            }
            CostTable costtable = construct.getCost(false, false, CheckBox6.Checked, CheckBox5.Checked, cat, Int32.Parse(qty.Text), 0, distance);
            //calculate stamp cost
            costtable = construct.getIdentityCost(costtable,Int32.Parse(qty.Text));




            costtable = construct.setProfit(costtable);
            order = construct.setCost(order, costtable);
            bill = construct.setOrderIntoBill(bill, order);
            bill = construct.setTotalValue();
            Session["bill"] = bill;
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    private OrderDetails constructOrder()
    {
        OrderDetails orderDetails = new OrderDetails();
        orderDetails.Categoryid = Int32.Parse(categoryid.Value.ToString());

        try
        {

            orderDetails.Qty = Int32.Parse(qty.Text);
            orderDetails.Description = "SCHOOL IDENTITY CARD";
           

        }
        catch (Exception e)
        {
            throw e;
        }
        return orderDetails;
    }
    protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void qty_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        prepareOrder();
        Response.Redirect("~/itemchoice.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        prepareOrder();
        Response.Redirect("~/quotation.aspx");
    }
}