using System;
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

            // 자료형 검사
            int _int = 273;
            long _long = 274889488883;
            float _float = 52.273F;
            string _string = "Hello";
            char _char = 'A';
            double _double = 3.14;

            // 각 변수의 자료형을 출력
            Console.WriteLine("_int의 자료형: " + _int.GetType());
            Console.WriteLine("_long의 자료형: " + _long.GetType());
            Console.WriteLine("_float의 자료형: " + _float.GetType());
            Console.WriteLine("_string의 자료형: " + _string.GetType());
            Console.WriteLine("_char의 자료형: " + _char.GetType());
            Console.WriteLine("_double의 자료형: " + _double.GetType());

            Console.WriteLine((323).GetType());

            // var 키워드를 사용하여 변수를 선언할 때 컴파일러가 자료형을 추론
            // 한 번 지정된 자료형은 계속 유지
            var num = 10;
            var message = "Hello, world!";
            var pi = 3.14;

            Console.WriteLine("number의 자료형: " + num.GetType()); // System.Int32
            Console.WriteLine("message의 자료형: " + message.GetType()); // System.String
            Console.WriteLine("pi의 자료형: " + pi.GetType()); // System.Double

            // 사용자로부터 문자열 입력 받기
            Console.WriteLine("이름을 입력하세요:");
            string name = Console.ReadLine();

            // 입력받은 이름 출력하기
            Console.WriteLine("안녕하세요, " + name + "님!");

            // 자동 자료형(automatically/Implicit Type Casting) 변환 => 암시적 형변환
            int numInt = 10;
            double numDouble = numInt; // int를 double로 암시적으로 변환
            Console.WriteLine("암시적 형변환: " + numDouble); // 출력: 10.0

            // 강제 자료형 변환(force/manually/Explicit type casting) => 명시적 형변환
            double num1 = 10.5;
            int num2 = (int)num1; // double을 int로 명시적으로 변환
            Console.WriteLine("명시적 형변환: " + num2); // 출력: 10

            // Parse 메서드를 이용한 변환
            string strNumber = "100";
            int parsedNumber = int.Parse(strNumber); // 문자열을 int로 변환
            Console.WriteLine("Parse 메서드를 이용한 변환: " + parsedNumber); // 출력: 100

            // ToString()메서드를 이용한 변환
            Console.WriteLine((52.273).ToString()); // 52.273
            Console.WriteLine((52.273).ToString("0.00")); // 52.27
            Console.WriteLine((52.273).ToString("0.00000")); // 52.27300

            // 숫자와 문자열 덧셈
            Console.WriteLine(52 + 273); // 325
            Console.WriteLine("52" + 273); // 52273
            Console.WriteLine(52 + "273"); // 52273

            // 다른 자료형을 불로 변환
            Console.WriteLine(bool.Parse("True"));// True
            Console.WriteLine(bool.Parse("true")); // True
            Console.WriteLine(bool.Parse("False")); // False
            Console.WriteLine(bool.Parse("false")); // False
        }
    }
}
