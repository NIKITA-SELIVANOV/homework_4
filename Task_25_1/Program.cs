Console.WriteLine ("ВВедите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите степень числа: ");
int z = Convert.ToInt32(Console.ReadLine());
int square = x;

 for (int i =1;i<z; i++){
x = x*square;
}
Console.WriteLine ((x));
