using System;


class PatientBill
{
    public string BillId { get; set; }
    public string PatientName { get; set; }
    public char HasInsurance { get; set; }
    public decimal ConsultationFee { get; set; }
    public decimal LabCharge { get; set; }
    public decimal MedicalCharge { get; set; }

    public decimal GrossAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal FinalPayable { get; set; }

    public PatientBill(string BillId,string PatientName,char HasInsurance,decimal ConsultationFee,decimal LabCharge,decimal MedicalCharge){
        this.BillId = BillId;
        this.PatientName = PatientName;
        this.HasInsurance = HasInsurance;
        this.ConsultationFee = ConsultationFee;
        this.LabCharge = LabCharge;
        this.MedicalCharge = MedicalCharge;
    }

    public decimal calculateGrossAmount()
    {
        return ConsultationFee + LabCharge + MedicalCharge;
    }

    public decimal calculateDiscount()
    {
        if (HasInsurance == 'Y' || HasInsurance == 'y')
        {
            return (GrossAmount *10)/100;
        }
        return (10/100);
    }

    public decimal calculateFinalPayable()
    {
        return GrossAmount - DiscountAmount;
    }

    public void View()
    {
        Console.WriteLine("-----------------------Last Bill---------------");
        Console.WriteLine($"BillId: {BillId}");
        Console.WriteLine($"Patient: {PatientName}");
        if(HasInsurance=='Y' || HasInsurance == 'y')
        {
            Console.WriteLine("Insured: Yes");
        }
        else
        {
            Console.WriteLine("Insured: No");
        }
        Console.WriteLine($"Consultation fees: {ConsultationFee}");
        Console.WriteLine($"Lab charges: {LabCharge}");
        Console.WriteLine($"Medicine charges: {MedicalCharge}");
        Console.WriteLine($"Gross amount: {GrossAmount}");
        Console.WriteLine($"Discount amount: {DiscountAmount}");
        Console.WriteLine($"Final Payable: {FinalPayable}");
        Console.WriteLine("-----------------------------------------------");
    }

    public void Clear()
    {
        Console.WriteLine("Last bill cleared.");
    }
}
