﻿using System;

namespace Lista
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Tests.RunAllTests());

            List<int> list = new List<int>();

			list.PushBack(4);
			list.PushBack(8);
			list.PushBack(2);
			list.PushBack(17);
			list.PushBack(11);
            list.PushBack(9);

            list.RemoveAtIndex(2);

            Console.WriteLine(list);

			//Console.WriteLine(list.FindAtIndex(2));
            //Console.WriteLine(list.FindElement(11, (arg1, arg2) => arg1==arg2));
        }
    }
}