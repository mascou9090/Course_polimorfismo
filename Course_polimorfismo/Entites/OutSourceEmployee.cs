namespace Course_polimorfismo.Entites
{
    internal class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourceEmployee()
        {
            
        }
        public OutSourceEmployee(string name, int hours, double valuePerHours, double additionalCharge) : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
