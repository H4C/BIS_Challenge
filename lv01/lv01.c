#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>
#define MAX_DATA 32768
int main(int argc, char *argv[])
{
  int i;
  char pwd[MAX_DATA], pin[MAX_DATA], uin[MAX_DATA];
  srand(time(NULL));
  for (i = 0; i < 10; i++)
  {
    pwd[i] = rand() % 26+97;
  }
  system("color a");
  printf("Welcome to TeamH4C Intranet\n");
  printf("UserID:");
  scanf("%s", uin);
  if (strcmp(uin, "admin") == 0)
  {
    printf("PassWD:");
    scanf("%s", pin);
    if (strcmp(pin, pwd) == 0)
    {
      printf("Login Success!\n");
      system("pause");
    }
    else
    {
      printf("Login Error: Wrong PassWD!\n");
      system("pause");
    }
  }
  else
  {
    printf("userid not found\n");
    system("pause");
  }
  return 0;
}
