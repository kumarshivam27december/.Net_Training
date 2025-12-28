using System;

class Program
{
    static PatientBill LastBill;
    static bool HasLastBill = false;

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("================ MediSure Clinic Billing =============");
            Console.WriteLine("1. create New Bill (Enter Patient Detail)");

            Console.WriteLine("2. view Last Bill");


            Console.WriteLine("3. clear Last Bill");
            Console.WriteLine("4. exit");


            Console.Write("enter your option: ");

            int userInput;

            userInput  = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Write("enter Bill Id: ");
                    string BillId = Console.ReadLine() ;
                    if (BillId == "")
                    {
                        Console.WriteLine("invalid Bill Id");
                        break;
                    }
                    Console.Write("enter Patient Name: ");

                    string PatientName = Console.ReadLine();


                    Console.Write("is patient Insured ? (Y/N): ");
                    char IsPatientInsured = Convert.ToChar(Console.ReadLine());
                    Console.Write("Enter Consultation Fee: ");



                    decimal ConsultationFee = Convert.ToDecimal(Console.ReadLine());
                    if (ConsultationFee <= 0)
                    {
                        Console.WriteLine("Consultation fee must be greater than 0");
                        break;
                    }
                    Console.Write("Enter Lab Charges: ");
                    decimal LabCharge = Convert.ToDecimal(Console.ReadLine());


                    if (LabCharge < 0)
                    {
                        Console.WriteLine("Lab charge must be greater than or equal to 0");
                        break;
                    }
                    Console.Write("Enter Medicine Charges: ");
                    decimal MedicalCharge = Convert.ToDecimal(Console.ReadLine());


                    if (MedicalCharge<0)
                    {
                        Console.WriteLine("Medical charge must be greater than or equal to 0");
                        break;
                    }

                    LastBill = new PatientBill(BillId,PatientName,IsPatientInsured,ConsultationFee,LabCharge,MedicalCharge);


                    LastBill.GrossAmount = LastBill.calculateGrossAmount();
                    LastBill.DiscountAmount = LastBill.calculateDiscount();
                    LastBill.FinalPayable = LastBill.calculateFinalPayable();

                    HasLastBill = true;
                    Console.WriteLine("Bill Created Successfully");
                    Console.WriteLine($"Gross Amount : {LastBill.GrossAmount:F2}");
                    Console.WriteLine($"Discount Amount : {LastBill.DiscountAmount:F2}");
                    Console.WriteLine($"Final Payable : {LastBill.FinalPayable:F2}");
                    Console.WriteLine("-----------------------------------------------------------");
                    break;



                case 2:
                    if (HasLastBill)
                    {
                        LastBill.View();
                    }
                    else
                    {
                        Console.WriteLine("no bills available. please create a new bill first.");
                    }

                    break;


                case 3:
                    if (HasLastBill)
                    {
                        LastBill.Clear();
                        LastBill = null;
                        HasLastBill = false;
                    }
                    else
                    {
                        Console.WriteLine("No bill to clear.");
                    }
                    break;


                    
                case 4:
                    Console.WriteLine("Thank you ");
                    return;

                default:
                    Console.WriteLine("Invalid user input.");
                    break;
            }
        }
    }
}
