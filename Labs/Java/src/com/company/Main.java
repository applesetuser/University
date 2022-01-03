package com.company;

public class Main {
    static int[] konwertuj(int x, int n){
        int[] zw = new int[n];
        for(int i = 0; i<n; i++){
            zw[n-1-i]=x%2;
            x=x/2;
        }
        return zw;
    }
    static int konwertuj10(int[] lista){
        int waga=1
        int wartosc10=0;
        int koniec=lista.length-1;
        waga=waga<<koniec;
        for(int i=0;i<=koniec;i++){
            wartosc10+=lista[i]*waga;
            waga/=2;
        }
        return wartosc10;
    }
    public static void drukuj(int[] liczby)
    {
        for (int i = 0; i < liczby.length; i++)
            System.out.print(liczby[i] + " ");
            System.out.println();
    }
    public static void main(String[] args){
    int[] listaA=konwertuj(x:23, n:6); drukuj(listaA);
    int[] listaB = {1,1,0,1,0,0};
    int[] listaW = {0,0,0,0,0,0,0}
    int przeniesienie = 0;
    int sumaBit = 0;
        System.out.println("=================================");

    for (int i=listaA.length-1;i>=0;i--) {



    }




        else if (sumaBit == 3)
        {
            listaW[i+1] = 1;

        }

    listaW[0]=przeniesienie;
    drukuj(listaA);
    drukuj(listaB);
    drukuj(listaW);
    System.out.println("suma = "+konwertuj10);


    }
}
