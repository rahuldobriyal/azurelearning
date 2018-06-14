using System;
namespace AzureLearning.Domain.Models
{
    public class TestData
    {
        public string Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public TestData()
        {
            this.Id = "1";
            this.Name = "Test Name";
            this.Description = "This a test data model";
        }
    }
}
