using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using offsetLibrary;

/// <summary>
/// Summary description for ConstructDropdown
/// </summary>
public class ConstructDropdown
{
	public ConstructDropdown()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public List<int> bindMin(List<PrintCost> costs)
    {
        List<int> items = null;
        if (costs != null && costs.Count > 0)
        {
            int item = 0;
            items = new List<int>();
            for (int i = 0; i < costs.Count; i++)
            {
                item = costs[i].Min;
               
                bool flag = false;
                if (items != null&&items.Count>0)
                {
                    for (int j = 0; j < items.Count; j++)
                    {
                        if (items[j]==item)
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                if (!flag)
                {
                    items.Add(item);
                }
            }
            items.Sort();
        }
        return items;
    }
    public List<int> bindMax(List<PrintCost> costs)
    {
        List<int> items = null;
        if (costs != null && costs.Count > 0)
        {
            int item = 0;
            items = new List<int>();
            for (int i = 0; i < costs.Count; i++)
            {
                item = costs[i].Max;

                bool flag = false;
                if (items != null && items.Count > 0)
                {
                    for (int j = 0; j < items.Count; j++)
                    {
                        if (items[j] == item)
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                if (!flag)
                {
                    items.Add(item);
                }
            }
            items.Sort();
        }
        return items;
    }
}
