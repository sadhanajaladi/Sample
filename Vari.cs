using System;

class Variab{
    int x=2,y=4; //instance --> can be accessed in main method only with obj refer
    static int p=33, q=44; // static -> can be accesse in method with obj reference, can be changed
    const int a1=7; // can't be modified and accessed directly
    readonly int b=9; // used for only reading
    void add(){
        int c=34; // local variable and accessed only in that method
        Console.WriteLine(c);
    }
    static void Main(string[] args){
        Variab a= new Variab();
        Console.WriteLine(a.x+a.y);
        Console.WriteLine(p-q);
        Console.WriteLine(a1);
        Console.WriteLine(a.b);
        
    }

}