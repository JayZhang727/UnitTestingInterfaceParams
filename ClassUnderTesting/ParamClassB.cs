namespace ClassUnderTesting
{
    public class ParamClassB : IParamDataInterface
    {
        public ParamClassB()
        {
            this.Id = "Id";
            this.ParamClassBVar = "not 123";
        }

        public string Id { get; set; }

        public string ParamClassBVar { get; set; }

    }
}
