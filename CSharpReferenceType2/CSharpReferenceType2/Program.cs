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
    class Person :Man,Isuper
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

        public int GetSuper()
        {
            return age + 100;
        }

        public override int GetAbstract()
        {
            return 50;
        }
    }
    
    //创建一个抽象类
    //抽象类不能被实例化，但是可以被其它的类继承，去实现里面的具体方法
    abstract class Man 
    {
        public abstract int GetAbstract();
    }

    //编写接口,命名时开头以I字母大写
    //接口与抽象类的区别在于，里面只能有方法，属性，索引和事件
    interface Isuper 
    {
        int GetSuper();
    }
}
