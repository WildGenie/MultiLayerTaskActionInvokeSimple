using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Layer
{
    public class SimpleClass
    {
        public Action<int, string> simpleAction;
        private int _currentNumber;

        public void InvokeSimpleAction(int number, string desc)
        {
            if (simpleAction != null)
            {
                simpleAction.Invoke(number, desc);
            }
        }

        public void TestAction()
        {
            Task.Factory.StartNew(delegate
            {
                Thread.Sleep(new TimeSpan(0,0,5));
                InvokeSimpleAction(_currentNumber,string.Format("Current number: {0}", _currentNumber));
                _currentNumber++;
            });
        }
    }
}
