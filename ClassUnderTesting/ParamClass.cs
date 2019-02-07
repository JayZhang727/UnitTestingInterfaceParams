namespace ClassUnderTesting
{
    public class ParamClass<T> : IParamInterface where T : IParamDataInterface
    {
        public T ParamData { get; set; }

        public ParamClass()
        {

        }

        public ParamClass(T para)
        {
            this.ParamData = para;
        }

        public IParamDataInterface GetParamData()
        {
            return ParamData;
        }
    }
}
