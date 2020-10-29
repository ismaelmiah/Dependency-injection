namespace Library2.Infrastructure
{
    public class TestingModel : ITestingModel
    {
        private readonly ITest1 _test1;
        private readonly ITest2 _test2;

        public TestingModel(ITest1 test1, ITest2 test2)
        {
            _test1 = test1;
            _test2 = test2;
        }
        public string ShowData()
        {
            string data = Name + " " + Age +"\t";
            data += "\t"+ _test1.Testing1();
            data += _test2.Testing2();
            return data;
        }

        public string Name { get; set; } = "Ismail";
        public int Age { get; set; } = 23;
    }
}
