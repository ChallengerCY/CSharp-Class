using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReferenceType2
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化类
            var person = new Person();
            var person2 = new Person(5);
            //调用类中的static需要用直接以类名引用
            Console.WriteLine(person2.GetAge());
            Console.WriteLine(person2.Age);
            person2.Age = 10;
            Console.WriteLine(person2.GetAge());
            Console.WriteLine(Person.GitFive());
            Console.ReadLine();
        }
    }

    //class 类型的使用
    //class 默认的访问权限是internal
    class Person 
    { 
        //class里面可以包含成员变量和方法，构造函数
        //还有属性等
        int age;
        //默认的构造函数
        public Person()
        {
        }
        //修改默认的构造函数
        public Person(int myAge) {
            this.age = myAge;
        }

        public int GetAge()
        {
            return age;
        } 
  
        //定义一个代码块
        public static int GitFive() {
            return 5;
        }

        //属性
        public int Age
        {
            get {
                return age + 10;
            }
            set {
                age = value - 10;
            }
        }
    }
}
