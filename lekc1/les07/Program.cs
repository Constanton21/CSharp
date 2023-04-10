Console.Clear();
int xa = 80, ya = 1;
int xb = 1, yb = 30;
int xc = 160, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.Write("+");
Console.SetCursorPosition(xb, yb);
Console.Write("+");
Console.SetCursorPosition(xc, yc);
Console.Write("+");

int x = xa, y = ya;

int count  = 0;

while(count < 30000)
{
    int che = new Random().Next(0, 3);
    if (che == 0)
   { 
   x = (x + xa)/2;
   y = (y + ya)/2;
   } if (che == 1) 
   {
    x = (x + xb)/2;
   y = (y + yb)/2;
   }
   if (che == 2) 
   {x = (x + xc)/2;
   y = (y + yc)/2;
   } 
    Console.SetCursorPosition(x, y);   
    Console.Write("+");
    count++;
}

