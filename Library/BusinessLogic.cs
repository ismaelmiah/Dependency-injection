using System;
using Library.Utilities;

namespace Library
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            _logger.Log("Starting the processing of the Data");
            Console.WriteLine("Processing the Data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Processed Info");
            _logger.Log("Finished Processing Data");
        }
    }
}
