using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp实践教学
{
    class InputThread
    {
        //线程成员变量
        Thread inputThread;
        //输入检测事件
        public event Action inputEvent;

        private static InputThread instance = new InputThread();

        public static InputThread Instance
        {
            get
            {
                return instance;
            }
        }

        private InputThread()
        {
            inputThread = new Thread(InputCheck);
            inputThread.IsBackground = true;
            inputThread.Start();
        }

        private void InputCheck()
        {
            while (true)
            {
                inputEvent?.Invoke();
            }
        }
    }
}
