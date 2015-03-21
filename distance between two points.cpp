#include<stdio.h>
#include<math.h>

int main ()
 {
     double x1,y1,x2,y2,res;
     scanf("%lf %lf %lf %lf",&x1,&y1,&x2,&y2);
     res = sqrt(pow(x2-x1,2)+ pow(y2-y1,2));
     printf("%lf\n",res);
     return 0;
    /*
     res = ((x2-x1)*(x2-x1)) - ((y2-y1)*(y2-y1));
     x = pow(x2-x1,2);
     printf("%lf\n",x);
     y = (y2 - y1) * (y2 - y2);
     y = pow(y2-y1,2);
     printf("%lf\n",y);
     res = sqrt(x+y);
     res = sqrt(res);
     */
  }

