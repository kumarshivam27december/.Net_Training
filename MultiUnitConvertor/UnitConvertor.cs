using System;
class UnitConvertor{

    public double KilometerToMeter(double value){
        return value*1000;
    }

    public double MeterToKilometer(double value){
        return value/1000d;
    }
    public double MilesToFeet(double value){
        return value*5280;
    }
    public double FeetToMiles(double value){
        return value/5280;
    }

    public double KilometerToKiloMeter(double value){
        return value;
    }

    public double KilometerToFeet(double value){
        return value*3280.84;
    }
    public double KilometerToMiles(double value){
        return value*0.621371;
    }

    public double MeterToMeter(double value){
        return value;
    }   

    public double MeterToMiles(double value){
        return value*0.000621371;
    }

    public double FeetToMeter(double value){
        return value*0.3048;
    }

    public double MilesToMeter(double value){
        return value*1609.34;
    }

    public double FeetToFeet(double value){
        return value;
    }

    public double FeetToKilometer(double value){
        return value/0.0003048;
    }
    public double MilesToMiles(double value)
    {
        return value;
    }

    public double MilesToKilometer(double value){
        return value*1.60934;
    }

    public double MeterToFeet(double value){
        return value*3.28084;
    }


    public double KilogramToGram(double value){
        return value*1000;
    }

    public double KilogramToKilogram(double value){
        return value;
    }

    public double KilogramToPound(double value){
        return value*2.20462;
    }

    public double KilogramToOunce(double value){
        return value*35.274;
    }

    public double GramToGram(double value){
        return value;
    }
    public double GramToKilogram(double value){
        return value/1000;
    }

    public double GramToOunce(double value)
    {
        return value*0.035274;
    }

    public double GramToPound(double value){
        return value*0.00220462;
    }
    public double PoundToOunce(double value){
        return value *16;
    }

    public double PoundToGram(double value){
        return value*453.592;
    }

    public double PoundToPound(double value){
        return value;
    }

    public double PoundToKilogram(double value){
        return value*0.453592;
    }
    public double OunceToPound(double value){
        return value*0.0625;
    }
    public double OunceToOunce(double value){
        return value;
    }
    public double OunceToKilogram(double value){
        return value*0.0283495;
    }

    public double OunceToGram(double value){
        return value*28.3495;
    }
    public double CelciusToKelvin(double value){
        return value + 273.15;
    }

    public double CelciusToCelcius(double value)
    {   
        return value;
    }

    public double KelvinToCelcius(double value){
        return value - 273.15;
    }

    public double KelvinToKelvin(double value){
        return value;
    }

    public double CelciusToFahrenheit(double value){
        return (value * 9/5) + 32;
    }

    public double FahrenheitToCelcius(double value){
        return (value - 32) * 5/9;
    }
    public double FahrenheitToKelvin(double value){
        return (value - 32) * 5/9 + 273.15;
    }
    public double KelvinToFahrenheit(double value)
    {
        return (value - 273.15) * 9/5 + 32;
    }

    public double FahrenheitToFahrenheit(double value)
    {
        return value;
    }


    public double Convert(double value, string fromUnit, string toUnit){
        fromUnit =fromUnit.ToLower();
        toUnit = toUnit.ToLower();
        if(fromUnit=="kilogram"){
            switch (toUnit)
            {
                case "gram":
                    return KilogramToGram(value);
                case "pound":
                    return KilogramToPound(value);
                case "ounce":
                    return KilogramToOunce(value);
                default:
                    return KilogramToKilogram(value);
            }
        }else if(fromUnit == "gram"){
            switch (toUnit)
            {
                case "kilogram":
                    return GramToKilogram(value);
                case "pound":
                    return GramToPound(value);
                case "ounce":
                    return GramToOunce(value);
                default:
                    return GramToGram(value);
            }
        }else if(fromUnit == "pound"){
            switch (toUnit)
            {
                case "kilogram":
                    return PoundToKilogram(value);
                case "gram":
                    return PoundToGram(value);
                case "ounce":
                    return PoundToOunce(value);
                default:
                    return PoundToPound(value);
            }
        }else if(fromUnit == "ounce"){
            switch (toUnit)
            {
                case "kilogram":
                    return OunceToKilogram(value);
                case "gram":
                    return OunceToGram(value);
                case "pound":
                    return OunceToPound(value);
                default:
                    return OunceToOunce(value);
            }
        }else if(fromUnit == "meter"){
            switch (toUnit)
            {
                case "kilometer":
                    return MeterToKilometer(value);
                case "mile":
                    return MeterToMiles(value);
                case "feet":
                    return MeterToFeet(value);
                default:
                    return MeterToMeter(value);
            }

        }else if(fromUnit == "kilometer"){
            switch (toUnit)
            {
                case "meter":
                    return KilometerToMeter(value);
                case "mile":
                    return KilometerToMiles(value);
                case "feet":
                    return KilometerToFeet(value);
                default:
                    return KilometerToKiloMeter(value);
            }

        }else if(fromUnit == "mile"){

            switch (toUnit)
            {
                case "kilometer":
                    return MilesToKilometer(value);
                case "feet":
                    return MilesToFeet(value);
                case "meter":
                    return MilesToMeter(value);
                default:
                    return MilesToMiles(value);
            }
            

        }else if(fromUnit == "feet")
        {
            switch (toUnit)
            {
                case "mile":
                    return FeetToMiles(value);
                case "meter":
                    return FeetToMeter(value);
                case "kilometer":
                    return FeetToKilometer(value);
                default:
                    return FeetToFeet(value);
            }
            
        }else if(fromUnit == "celcius"){
            switch (toUnit)
            {
                case "fahrenheit":
                    return CelciusToFahrenheit(value);
                case "kelvin":
                    return CelciusToKelvin(value);
                default:
                    return CelciusToCelcius(value);
            }

        }else if(fromUnit == "fahrenheit"){
            switch (toUnit)
            {
                case "celcius":
                    return FahrenheitToCelcius(value);
                case "kelvin":
                    return FahrenheitToKelvin(value);
                default:
                    return FahrenheitToFahrenheit(value);
            }
        }else if(fromUnit == "kelvin"){
            switch (toUnit)
            {
                case "fahrenheit":
                    return KelvinToFahrenheit(value);
                case "celcius":
                    return KelvinToCelcius(value);
                default:
                    return KelvinToKelvin(value);
            }
            
        }
        return 0.0;
    }

    public double Convert(double value,string fromUnit)
    {
        fromUnit = fromUnit.ToLower();
        if(fromUnit=="kilometer"){
            return KilometerToMeter(value);
        }
        if(fromUnit=="meter"){
            return MeterToMeter(value);
        }
        if(fromUnit=="mile"){
            return MilesToMeter(value);
        }
        if(fromUnit=="feet"){
            return FeetToMeter(value);
        }if(fromUnit == "kilogram")
        {
            return KilogramToGram(value);
        }
        if (fromUnit == "gram")
        {
            return GramToGram(value);
        }if(fromUnit=="pound"){
            return PoundToGram(value);

        }if(fromUnit=="ounce"){
            return OunceToGram(value);

        }if(fromUnit =="celcius"){
            return CelciusToCelcius(value);

        }if(fromUnit =="kelvin"){
            return KelvinToCelcius(value);

        }if(fromUnit == "fahrenheit"){
            return FahrenheitToCelcius(value);
        }

        return 0.0d;
    }

}