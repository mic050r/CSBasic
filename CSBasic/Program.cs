﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C#에서도 헬로월드를?!
            Console.WriteLine("Hello World!");

            // 오버플로우 연습
            int a = 2000000000; //20억
            int b = 1000000000; // 10억
            Console.WriteLine(a + b);

            // 오버플로우 연습2
            // 다른 타입끼리 연산을 할 때 더 큰 연산의 타입을 따라간다. 
            Console.WriteLine((long)a + b); // => long a + long b
            Console.WriteLine(a + (long)b);
            Console.WriteLine((long)a + (long)b);

            // 자료형 최소, 최대 값 출력하기
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            // sizeof 연산자 연습
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("char : " + sizeof(char));
            Console.WriteLine("bool : " + sizeof(bool));

            // 중감연산자 연습 
            int number = 10;
            number++;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);
            Console.WriteLine(--number);
            Console.WriteLine(number++);
            number += 1;
        }
    }
}
