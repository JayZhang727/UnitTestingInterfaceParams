namespace ClassUnderTesting
{
    public class ParamClassA : IParamDataInterface
    {
        public ParamClassA()
        {
            this.Id = "Id";
            this.ParamClassAVar = 123;
        }

        public string Id { get; set; }

        public int ParamClassAVar { get; set; }

    }
}
