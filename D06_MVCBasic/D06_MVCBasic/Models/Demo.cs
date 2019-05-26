using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace D06_MVCBasic.Models
{
    public class Demo
    {
        public int Test01()
        {
            Thread.Sleep(5000);//5s
            return 7777;
        }
        public string Test02()
        {
            Thread.Sleep(2000);//2s
            return "Nhất Nghệ";
        }
        public void Test03()
        {
            Thread.Sleep(3000);//3s
        }

        public async Task<int> Test01Async()
        {
            //trong hàm async phải có tối thiểu 1 lời gọi hàm async khác
            await Task.Delay(5000);
            return 7777;
        }

        public async Task SayGoodBye()
        {
            return;
        }
        public async Task<string> Test02Async()
        {
            await Task.Delay(2000);
            return "Nhất Nghệ";
        }
        public async Task Test03Async()
        {
            await Task.Delay(3000);
        }
    }
}
