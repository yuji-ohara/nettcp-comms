using System;
using System.Collections.Generic;

namespace nettcp_comms
{
    public class Helper
    {
        public TestModel CreateTestModel(int id)
        {
            switch (id) {
                case 1:
                    return CreateSimpleTestModel();
                case 2:
                    return CreateComplexTestModel();
                case 3:
                    return CreateDynamicTestModel();
                default:
                    return DefaultTestModel();
            }
        }

        private TestModel CreateDynamicTestModel()
        {
            if (new Random().Next(0, 10) % 2 == 0)
                return CreateSimpleTestModel();
            else
                return CreateComplexTestModel();
        }

        private TestModel CreateComplexTestModel()
        {
            var id = new Random().Next(1, int.MaxValue);
            var dic = new Dictionary<string, string>();
            var testModel = new TestModel()
            {
                Id = id,
                Name = $"Simple Test Model {id}",
                Active = true
            };
            dic.Add("Self", Newtonsoft.Json.JsonConvert.SerializeObject(testModel));
            testModel.InternalDictionary = dic;

            return testModel;
        }

        private TestModel CreateSimpleTestModel()
        {
            var id = new Random().Next(1, int.MaxValue);
            var dic = new Dictionary<string, string>();
            dic.Add("Key1", "Value1");
            dic.Add("Key2", "Value2");

            return new TestModel()
            {
                Id = id,
                Name = $"Simple Test Model {id}",
                Active = true,
                InternalDictionary = dic
            };
        }

        private TestModel DefaultTestModel()
        {
            return new TestModel()
            {
                Id = 1,
                Name = "Test Model Default",
                Active = true,
                InternalDictionary = new Dictionary<string, string>()
            };
        }
    }
}
