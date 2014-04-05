using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Monitor生产者消费者实例
            //int result = 0; //一个标志位，如果是0表示程序没有出错，如果是1表明有错误发生
            //Cell cell = new Cell();

            ////下面使用cell初始化CellProd和CellCons两个类，生产和消费次数均为20次
            //CellProd prod = new CellProd(cell, 20);
            //CellCons cons = new CellCons(cell, 20);

            //Thread producer = new Thread(new ThreadStart(prod.ThreadRun));
            //Thread consumer = new Thread(new ThreadStart(cons.ThreadRun));
            ////生产者线程和消费者线程都已经被创建，但是没有开始执行 
            //try
            //{
            //    producer.Start();
            //    consumer.Start();

            //    producer.Join();
            //    consumer.Join();
            //    Console.ReadLine();
            //}
            //catch (ThreadStateException e)
            //{
            //    //当线程因为所处状态的原因而不能执行被请求的操作
            //    Console.WriteLine(e);
            //    result = 1;
            //}
            //catch (ThreadInterruptedException e)
            //{
            //    //当线程在等待状态的时候中止
            //    Console.WriteLine(e);
            //    result = 1;
            //}
            ////尽管Main()函数没有返回值，但下面这条语句可以向父进程返回执行结果
            //Environment.ExitCode = result;
            #endregion
            #region 多线程的自动管理(线程池)
            //Console.WriteLine("Thread Pool Sample:");
            //bool W2K = false;
            //int MaxCount = 10;//允许线程池中运行最多10个线程
            ////新建ManualResetEvent对象并且初始化为无信号状态
            //ManualResetEvent eventX = new ManualResetEvent(false);
            //Console.WriteLine("Queuing {0} items to Thread Pool", MaxCount);
            //Alpha oAlpha = new Alpha(MaxCount);
            ////创建工作项
            ////注意初始化oAlpha对象的eventX属性
            //oAlpha.eventX = eventX;
            //Console.WriteLine("Queue to Thread Pool 0");
            //try
            //{
            //    //将工作项装入线程池 
            //    //这里要用到Windows 2000以上版本才有的API，所以可能出现NotSupportException异常
            //    ThreadPool.QueueUserWorkItem(new WaitCallback(oAlpha.Beta), new SomeState(0));
            //    W2K = true;
            //}
            //catch (NotSupportedException)
            //{
            //    Console.WriteLine("These API's may fail when called on a non-Windows 2000 system.");
            //    W2K = false;
            //}
            //if (W2K)//如果当前系统支持ThreadPool的方法.
            //{
            //    for (int iItem = 1; iItem < MaxCount; iItem++)
            //    {
            //        //插入队列元素
            //        Console.WriteLine("Queue to Thread Pool {0}", iItem);
            //        ThreadPool.QueueUserWorkItem(new WaitCallback(oAlpha.Beta), new SomeState(iItem));
            //    }
            //    Console.WriteLine("Waiting for Thread Pool to drain");
            //    //等待事件的完成，即线程调用ManualResetEvent.Set()方法
            //    eventX.WaitOne(Timeout.Infinite, true);
            //    //WaitOne()方法使调用它的线程等待直到eventX.Set()方法被调用
            //    Console.WriteLine("Thread Pool has been drained (Event fired)");
            //    Console.WriteLine();
            //    Console.WriteLine("Load across threads");
            //    foreach (object o in oAlpha.HashCount.Keys)
            //        Console.WriteLine("{0} {1}", o, oAlpha.HashCount[o]);
            //}
            //Console.ReadLine();
            #endregion
            #region 多线程的自动管理(定时器)
            //TimerExampleState s = new TimerExampleState();

            ////创建代理对象TimerCallback，该代理将被定时调用
            //TimerCallback timerDelegate = new TimerCallback(CheckStatus);

            ////创建一个时间间隔为1s的定时器
            //Timer timer = new Timer(timerDelegate, s, 1000, 1000);
            //s.tmr = timer;

            ////主线程停下来等待Timer对象的终止
            //while (s.tmr != null)
            //    Thread.Sleep(0);
            //Console.WriteLine("Timer example done.");
            //Console.ReadLine();
            #endregion
            #region  Mutex 互斥对象
            Console.WriteLine("Mutex Sample ");
            //创建一个Mutex对象，并且命名为MyMutex
            gM1 = new Mutex(true, "MyMutex");
            //创建一个未命名的Mutex 对象.
            gM2 = new Mutex(true);
            Console.WriteLine(" - Main Owns gM1 and gM2");

            AutoResetEvent[] evs = new AutoResetEvent[4];
            evs[0] = Event1; //为后面的线程t1,t2,t3,t4定义AutoResetEvent对象
            evs[1] = Event2;
            evs[2] = Event3;
            evs[3] = Event4;

            Program tm = new Program();
            Thread t1 = new Thread(new ThreadStart(tm.t1Start));
            Thread t2 = new Thread(new ThreadStart(tm.t2Start));
            Thread t3 = new Thread(new ThreadStart(tm.t3Start));
            Thread t4 = new Thread(new ThreadStart(tm.t4Start));
            t1.Start();// 使用Mutex.WaitAll()方法等待一个Mutex数组中的对象全部被释放
            t2.Start();// 使用Mutex.WaitOne()方法等待gM1的释放
            t3.Start();// 使用Mutex.WaitAny()方法等待一个Mutex数组中任意一个对象被释放
            t4.Start();// 使用Mutex.WaitOne()方法等待gM2的释放

            //Thread.Sleep(5000);
            Console.WriteLine(" - Main releases gM1");
            gM1.ReleaseMutex(); //线程t2,t3结束条件满足

            //Thread.Sleep(5000);
            Console.WriteLine(" - Main releases gM2");
            gM2.ReleaseMutex(); //线程t1,t4结束条件满足

            //等待所有四个线程结束
            WaitHandle.WaitAll(evs);
            Console.WriteLine(" Mutex Sample");
            Console.ReadLine();
            #endregion
        }
        #region 多线程的自动管理(定时器)
        //下面是被定时调用的方法
        static void CheckStatus(Object state)
        {
            TimerExampleState s = (TimerExampleState)state;
            s.counter++;
            Console.WriteLine("{0} Checking Status {1}.", DateTime.Now.TimeOfDay, s.counter);

            if (s.counter == 5)
            {
                //使用Change方法改变了时间间隔
                (s.tmr).Change(10000, 2000);
                Console.WriteLine("changed");
            }

            if (s.counter == 10)
            {
                Console.WriteLine("disposing of timer");
                s.tmr.Dispose();
                s.tmr = null;
            }
        }
        #endregion
        #region Mutex 互斥对象
        static Mutex gM1;
        static Mutex gM2;
        const int ITERS = 100;
        static AutoResetEvent Event1 = new AutoResetEvent(false);
        static AutoResetEvent Event2 = new AutoResetEvent(false);
        static AutoResetEvent Event3 = new AutoResetEvent(false);
        static AutoResetEvent Event4 = new AutoResetEvent(false);

        public void t1Start()
        {
            Console.WriteLine("t1Start started, Mutex.WaitAll(Mutex[])");
            Mutex[] gMs = new Mutex[2];
            gMs[0] = gM1;//创建一个Mutex数组作为Mutex.WaitAll()方法的参数
            gMs[1] = gM2;
            Mutex.WaitAll(gMs);//等待gM1和gM2都被释放
            Thread.Sleep(2000);
            Console.WriteLine("t1Start finished, Mutex.WaitAll(Mutex[]) satisfied");
            Event1.Set(); //线程结束，将Event1设置为有信号状态
        }
        public void t2Start()
        {
            Console.WriteLine("t2Start started, gM1.WaitOne( )");
            gM1.WaitOne();//等待gM1的释放
            Console.WriteLine("t2Start finished, gM1.WaitOne( ) satisfied");
            Event2.Set();//线程结束，将Event2设置为有信号状态
        }
        public void t3Start()
        {
            Console.WriteLine("t3Start started, Mutex.WaitAny(Mutex[])");
            Mutex[] gMs = new Mutex[1];
            //gMs[0] = gM1;//创建一个Mutex数组作为Mutex.WaitAny()方法的参数
            gMs[0] = gM2;
            Mutex.WaitAny(gMs);//等待数组中任意一个Mutex对象被释放
            Console.WriteLine("t3Start finished, Mutex.WaitAny(Mutex[])");
            Event3.Set();//线程结束，将Event3设置为有信号状态
        }
        public void t4Start()
        {
            Console.WriteLine("t4Start started, gM2.WaitOne( )");
            gM2.WaitOne();//等待gM2被释放
            Console.WriteLine("t4Start finished, gM2.WaitOne( )");
            Event4.Set();//线程结束，将Event4设置为有信号状态
        }
        #endregion
    }
    #region 线程lock用法
    internal class Account
    {
        int balance;
        Random r = new Random();
        internal Account(int initial)
        {
            balance = initial;
        }
        internal int Withdraw(int amount)
        {
            if (balance < 0)
            {
                //如果balance小于0则抛出异常
                throw new Exception("Negative Balance");
            }
            //下面的代码保证在当前线程修改balance的值完成之前
            //不会有其他线程也执行这段代码来修改balance的值
            //因此，balance的值是不可能小于0的
            lock (this)
            {
                Console.WriteLine("Current Thread:" + Thread.CurrentThread.Name);
                //如果没有lock关键字的保护，那么可能在执行完if的条件判断之后
                //另外一个线程却执行了balance=balance-amount修改了balance的值
                //而这个修改对这个线程是不可见的，所以可能导致这时if的条件已经不成立了
                //但是，这个线程却继续执行balance=balance-amount，所以导致balance可能小于0
                if (balance >= amount)
                {
                    Thread.Sleep(5);
                    balance = balance - amount;
                    return amount;
                }
                else
                {
                    return 0;//transction rejected
                }
            }
        }
        internal void DoTransactions()
        {
            for (int i = 0; i < 100; i++)
            {
                Withdraw(r.Next(-50, 100));
            }
        }
        //internal class Test
        //{
        //    static internal Thread[] threads = new Thread[10];
        //    public static void Main()
        //    {
        //        Account acc = new Account(0);
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Thread t = new Thread(new ThreadStart(acc.DoTransactions));
        //            threads[i] = t;
        //        }
        //        for (int i = 0; i < 10; i++)
        //        {
        //            threads[i].Name = i.ToString();
        //        }
        //        for (int i = 0; i < 10; i++)
        //        {
        //            threads[i].Start();
        //        }
        //        Console.ReadLine();
        //    }
        //}
    #endregion
    }
    #region 多线程的自动管理(线程池)
    //这是用来保存信息的数据结构，将作为参数被传递
    public class SomeState
    {
        public int Cookie;
        public SomeState(int iCookie)
        {
            Cookie = iCookie;
        }
    }

    public class Alpha
    {
        public Hashtable HashCount;
        public ManualResetEvent eventX;
        public static int iCount = 0;
        public static int iMaxCount = 0;

        public Alpha(int MaxCount)
        {
            HashCount = new Hashtable(MaxCount);
            iMaxCount = MaxCount;
        }

        //线程池里的线程将调用Beta()方法
        public void Beta(Object state)
        {
            //输出当前线程的hash编码值和Cookie的值
            Console.WriteLine(" {0} {1} :", Thread.CurrentThread.GetHashCode(), ((SomeState)state).Cookie);
            Console.WriteLine("HashCount.Count=={0}, Thread.CurrentThread.GetHashCode()=={1}", HashCount.Count, Thread.CurrentThread.GetHashCode());
            lock (HashCount)
            {
                //如果当前的Hash表中没有当前线程的Hash值，则添加之
                if (!HashCount.ContainsKey(Thread.CurrentThread.GetHashCode()))
                    HashCount.Add(Thread.CurrentThread.GetHashCode(), 0);
                HashCount[Thread.CurrentThread.GetHashCode()] =
                   ((int)HashCount[Thread.CurrentThread.GetHashCode()]) + 1;
            }
            int iX = 2000;
            Thread.Sleep(iX);
            //Interlocked.Increment()操作是一个原子操作，具体请看下面说明
            Interlocked.Increment(ref iCount);

            if (iCount == iMaxCount)
            {
                Console.WriteLine();
                Console.WriteLine("Setting eventX ");
                eventX.Set();
            }
        }
    }
    #endregion
    #region 多线程的自动管理(定时器)
    class TimerExampleState
    {
        public int counter = 0;
        public Timer tmr;
    }

    #endregion
}
