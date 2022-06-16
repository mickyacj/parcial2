namespace Library1

open System
module fibo=
    Console.WriteLine("Ingrese número de términos: ")
    let n=Convert.ToInt32(Console.ReadLine())

    let mutable a=0
    let mutable b=1

    for i=1 to n do
        if i=1 then
            printfn "%d" a
        elif i=2 then
            printfn "%d" b
        else
            
            let c=a+b
            printfn "%d" c
            a<-b
            b<-c
    
    let tecla=Console.ReadKey()
    printfn("");

type Class1() = 
    member this.X = "F#"
