void Numbers(int num)
{
    if (num == 10)
{
    return;
}
else
{
    Numbers(num - 1);
    Console.Write($"{num} ");
}
}
Numbers(30);
