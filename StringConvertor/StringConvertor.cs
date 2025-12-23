using System;
using System.Runtime.InteropServices;
using System.Globalization;
class StringConvertor
{
    public StringConvertor()
    {
        
    }

    public string ConvertString(string input)
    {
        return input.ToLower();
    }

    public string ConvertString(string input ,bool toLower)
    {
        if(toLower == true)
        {
            return input.ToLower();
        }
        return input;
    }

    public string ConvertString(string input,int toTitleCase)
    {
        if (toTitleCase == 1)
        {
            return input.ToUpper();
        }
        if(toTitleCase == 2)
        {
            return input.ToLower();
        }
        if(toTitleCase == 3)
        {
            return new CultureInfo("en-US", false).TextInfo.ToTitleCase(input);
        }
        else
        {
            return "Invalid user input";
        }
    }
}