using System;
using Simple.Data;

namespace QADAppharborDemo.Data
{
    
    public class DataAccess
    {
        public static dynamic GetRandomQuote()
        {
            var rndId = new Random().Next(1, 5500);
            return Database.Open().ChuckNorrisFacts.FindById(rndId);
        }
    }
}