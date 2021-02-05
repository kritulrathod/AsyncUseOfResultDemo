using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming
{
  public class AsyncService
  {
    public AsyncService()
    {
    }

    public void DoSomeWorkInServiceTask()
    {
      var resultOne = DoFirstWorkInRepositoryTask(1);

      int i = 1;

     // var resultTwo = DoSecondWorkInRepositoryTask(2).Result;

      i = 2;

      if (resultOne.Result.Count > 0 
        //|| resultTwo.Count > 0
        )
      {
        Debug.WriteLine("Success");
      }
      return;
    }

    private async Task<List<string>> DoFirstWorkInRepositoryTask(int TaskId)
    {
      return await Task.Run(() => SomeWork(TaskId));
    }

    private async Task<List<string>> DoSecondWorkInRepositoryTask(int TaskId)
    {
      return await Task.Run(() => SomeWork(TaskId));
    }

    private Task<List<string>> SomeWork(int TaskId)
    {
      Debug.WriteLine(TaskId);
      List<string> numbers = new List<string>();
      for (int i = 0; i <= 10000; i++)
      {
        numbers.Add(i.ToString());
      }

      return Task.FromResult(numbers);
    }
  }
}
