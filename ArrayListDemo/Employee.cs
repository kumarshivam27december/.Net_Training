class Employee
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public override string ToString()
    {
        return $"Employee name is {Name} and Employee Id is {Id}";
    }
}