using SampleWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAPI.Repository
{
    //Contains the common task logic
    public interface ICommonRepository
    {
        InputData ReverseTheResponse(InputData inputData);
    }
    public class CommonRepository : ICommonRepository
    {
        public InputData ReverseTheResponse(InputData inputData)
        {
            InputData dataModel = new InputData();
            try
            {
                dataModel.FullName = ReverseString(inputData.FullName);
                dataModel.Email = ReverseString(inputData.Email);
                dataModel.Phone = inputData.Phone != null ? ReverseString(inputData.Phone) : inputData.Phone;
                dataModel.Notes = inputData.Notes != null ? ReverseString(inputData.Notes) : inputData.Notes;
            }
            catch(Exception ex)
            {
                //Exception Handle
            }
            return dataModel;
        }
        public static string ReverseString(string str)
        {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
}
