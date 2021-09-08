using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class Job : IJobExecutor
    {
        public int Amount { get; set; }

        public int maxConcurrent = 3;

        public CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public  List<Action> actions = new List<Action>();

        public void Start(int maxConcurrent)
        {
            int cnt = 0;
            List<Action> actionsnew = new List<Action>(actions);


            foreach (var action in actions)
            {
                if ((cnt < maxConcurrent) && (actions.Count > cnt))
                {
                    var task = Task.Factory.StartNew( action, cancellationTokenSource.Token);
                    Thread.Sleep(1000);
                    // cancellationTokenSource.Cancel();
                    //CancellationToken cancellationToken = cancellationTokenSource.Token;
                    cnt++;
                    actionsnew.Remove(action);
                }  
                actions = actionsnew;
            }
        }

        public void Stop()
        {
            cancellationTokenSource.Cancel();
        }

        public void Add(Action action)
        {
            Amount = Amount + 1;
            actions.Add(action);
        }

        public void Clear()
        {
            Stop();
            actions.Clear();
        }

    }
}