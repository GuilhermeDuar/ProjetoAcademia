using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public static class ResponseFactory<T>
    {
        public static Feedback CreateSuccessResponse()
        {
            Feedback r = new Feedback()
            {
                Successful = true,
                Report = "Operation successfully completed."
            };
            return r;
        }

        public static Feedback CreateFailedResponse()
        {
            Feedback r = new Feedback()
            {
                Successful = false,
                Report = "Database error! Contact the admin."
            };
            return r;
        }
        public static Data_Feedback<T> CreateSuccessDataResponse(List<T> list)
        {
            Data_Feedback<T> r = new Data_Feedback<T>()
            {
                Data = list,
                Successful = true,
                Report = "Successfully selected all data!",
            };
            return r;
        }
        public static Data_Feedback<T> CreateFailedDataResponse(List<T> list)
        {
            Data_Feedback<T> r = new Data_Feedback<T>()
            {
                Successful = false,
                Report = "Database error! Contact the admin.",
                Data = list
            };
            return r;
        }
        public static Single_Feedback<T> CreateSuccessSingleResponse(T item)
        {
            Single_Feedback<T> r = new Single_Feedback<T>()
            {
                Item = item,
                Successful = true,
                Report = "Successfully found the item!",
            };
            return r;
        }
        public static Single_Feedback<T> CreateFailedSingleResponse(T item)
        {
            Single_Feedback<T> r = new Single_Feedback<T>()
            {
                Item = item,
                Successful = false,
                Report = "Could find the specified item in the system!",
            };
            return r;
        }
        public static Data_Feedback<T> CreateListResponse(List<T> item)
        {
            if (item.Count == 0)
            {
                Data_Feedback<T> response = new Data_Feedback<T>()
                {
                    Data = new List<T>(),
                    Successful = false,
                    Report = "Users not found."

                };
                return response;
            }
            Data_Feedback<T> r = new Data_Feedback<T>()
            {
                Data = item,
                Successful = true,
                Report = "Users found."

            };
            return r;
        }
    }
}
