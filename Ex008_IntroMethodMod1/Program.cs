Console.Clear();

int 
    a1 = 1,
    b1 = 2,
    c1 = 3,
    a2 = 4,
    b2 = 5,
    c2 = 6,
    a3 = 7,
    b3 = 8,
    c3 = 9;

int max = a1;

if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine("Проверка выполнения программы: " + max);