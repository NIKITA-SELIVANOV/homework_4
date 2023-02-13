Console.WriteLine ("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (x<0){
    x*=-1;
}
while (x>0){
    sum +=x%10;
    x/=10;
}
Console.WriteLine ((sum));
