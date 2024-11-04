using System;                               //библиотеки
using System.Threading;

Console.Clear();                            //осчистка консоли

double Ax = 0;                              //начальные координаты
double Ay = 0;  
double Bx = 0;
double By = 15;
double Cx = 15;
double Cy = 15;

Console.SetCursorPosition((int)Math.Round(Ax*3), (int)Math.Round(Ay));    //началльный треугольник
Console.WriteLine("*");
Console.SetCursorPosition((int)Math.Round(Bx*3), (int)Math.Round(By));
Console.WriteLine("*");
Console.SetCursorPosition((int)Math.Round(Cx*3), (int)Math.Round(Cy));
Console.WriteLine("*");

int i = 0;                                  //введение переменных для цикла
double minL = 0;
int pare = 0;
double M_ABx = 0;
double M_ABy = 0;
double M_BCx = 0;
double M_BCy = 0;
double M_CAx = 0;
double M_CAy = 0;
double L_C_M_AB = 0;
double L_A_M_BC = 0;
double L_B_M_CA = 0;

while (i<35){                               //цикл перебора

    Thread.Sleep(500);                      //ожидание

    M_ABx = (Ax+Bx)/2;                      //середины сторон
    M_ABy = (Ay+By)/2;
    M_BCx = (Bx+Cx)/2;
    M_BCy = (By+Cy)/2;
    M_CAx = (Cx+Ax)/2;
    M_CAy = (Cy+Ay)/2;

    
    L_A_M_BC = Math.Sqrt(Math.Pow(M_BCx - Ax, 2) + Math.Pow(M_BCy - Ay, 2));    //длины бессектрис
    L_B_M_CA = Math.Sqrt(Math.Pow(M_CAx - Bx, 2) + Math.Pow(M_CAy - By, 2));
    L_C_M_AB = Math.Sqrt(Math.Pow(M_ABx - Cx, 2) + Math.Pow(M_ABy - Cy, 2));


    minL = L_A_M_BC;                        //выбор самой короткой бессектрисы
    pare = 0;
    if (minL > L_B_M_CA){
        minL = L_B_M_CA;
        pare = 1;}
    if (minL > L_C_M_AB){
        minL = L_C_M_AB;
        pare = 2;
    }
    
    if (pare == 0){                         //операция с точками
        Bx= (int)Math.Round(M_BCx);
        By= (int)Math.Round(M_BCy);
        Console.SetCursorPosition((int)Math.Round(Bx*3), (int)Math.Round(By));
        Console.WriteLine("*");}

    if (pare == 1){
        Cx= (int)Math.Round(M_CAx);
        Cy= (int)Math.Round(M_CAy);
        Console.SetCursorPosition((int)Math.Round(Cx*3), (int)Math.Round(Cy));
        Console.WriteLine("*");}

    if (pare == 2){
        Ax= (int)Math.Round(M_ABx);
        Ay= (int)Math.Round(M_ABy);
        Console.SetCursorPosition((int)Math.Round(Ax*3), (int)Math.Round(Ay));
        Console.WriteLine("*");}
/*
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(L_B_M_CA);
    Console.WriteLine(pare);
    Console.WriteLine(minL);
    Console.WriteLine(L_C_M_AB);
*/

    i= i+1;
}
Console.SetCursorPosition(0, 16); 

