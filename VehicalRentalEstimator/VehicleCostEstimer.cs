using System;
class VehicleCostEstimer
{
    public VehicleCostEstimer()
    {
        
    }

    public  double EstimateCost(int days, int distance)
    {
        return (days*50) + (distance*0.2);
    }

    public  double EstimateCost(int days, int distance,bool withDriver)
    {
        if (withDriver == true)
        {
            return days*100 + distance*0.5 +200;
        }
        else
        {
            return days*100 +  distance* 0.5;
        }
    }

    public  double EstimateCost(int days, bool includeInsurance)
    {
        if (includeInsurance == true)
        {
            return days*20+50;
        }
        else
        {
            return days*20;
        }
    }
}