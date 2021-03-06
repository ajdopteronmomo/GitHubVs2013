﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    public class Cell
    {
        int cellContents; // Cell对象里边的内容
        bool readerFlag = false; // 状态标志，为true时可以读取，为false则正在写入
        public int ReadFromCell()
        {
            lock (this) // Lock关键字保证了什么，请大家看前面对lock的介绍
            {
                if (!readerFlag)//如果现在不可读取
                {
                    try
                    {
                        //等待WriteToCell方法中调用Monitor.Pulse()方法
                        Monitor.Wait(this);
                    }
                    catch (SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                Console.WriteLine("Consume: {0}", cellContents);
                readerFlag = false;
                //重置readerFlag标志，表示消费行为已经完成
                Monitor.Pulse(this);
                //通知WriteToCell()方法（该方法在另外一个线程中执行，等待中）
            }
            return cellContents;
        }

        public void WriteToCell(int n)
        {
            lock (this)
            {
                if (readerFlag)
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch (SynchronizationLockException e)
                    {
                        //当同步方法（指Monitor类除Enter之外的方法）在非同步的代码区被调用
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        //当线程在等待状态的时候中止 
                        Console.WriteLine(e);
                    }
                }
                cellContents = n;
                Console.WriteLine("Produce: {0}", cellContents);
                readerFlag = true;
                Monitor.Pulse(this);
                //通知另外一个线程中正在等待的ReadFromCell()方法
            }
        }
    }

    public class CellProd
    {
        Cell cell; // 被操作的Cell对象
        int quantity = 1; // 生产者生产次数，初始化为1 

        public CellProd(Cell box, int request)
        {
            //构造函数
            cell = box;
            quantity = request;
        }
        public void ThreadRun()
        {
            for (int looper = 1; looper <= quantity; looper++)
                cell.WriteToCell(looper); //生产者向操作对象写入信息
        }
    }

    public class CellCons
    {
        Cell cell;
        int quantity = 1;

        public CellCons(Cell box, int request)
        {
            //构造函数
            cell = box;
            quantity = request;
        }
        public void ThreadRun()
        {
            int valReturned;
            for (int looper = 1; looper <= quantity; looper++)
                valReturned = cell.ReadFromCell();//消费者从操作对象中读取信息
        }
    } 
}
