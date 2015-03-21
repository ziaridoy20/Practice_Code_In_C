#include<stdio.h>
#include<math.h>
int main ()
 {
     double x1,y1,z1,perimeter,result;
     scanf("%lf %lf %lf",&x1,&y1,&z1);
     perimeter = (x1+y1+z1)/3;
     printf("%lf\n",perimeter);
     result = sqrt(perimeter *(perimeter - x1) * (perimeter - y1) * (perimeter - z1));
     printf("%lf\n",result);
     return 0;
  }


