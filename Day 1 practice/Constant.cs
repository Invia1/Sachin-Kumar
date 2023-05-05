using System;
class Constant{

    const float pi=3.14f;

    class A{
        public void getAreaCircle(int r){
            Console.WriteLine(pi*r*r);
        }
    }
    
    class B{
        public void getAreaCircle(int r){
            Console.WriteLine(pi*r*r);
        }
    }

    public static void Main(){
        // here are the example of Constant Variable.....
        A a=new A();
        B b=new B();

        a.getAreaCircle(3);
        b.getAreaCircle(2);

    }
}