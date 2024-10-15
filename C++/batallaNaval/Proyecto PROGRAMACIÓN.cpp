#include <iostream>  
#include <stdlib.h>
#include <time.h>
#include <conio.h>
#include <windows.h>
using namespace std; 

 
void wait(int seconds) // Funcion 'clock' para el tiempo de juego
{
    clock_t endwait;
    endwait = clock() + seconds * CLOCKS_PER_SEC;
    while( clock() < endwait )
    {}
}
 
void imprimir();
void iniciar();

int i, j, k, jugador[10][10], oponente[10][10], opcion1, opcion2, puntajejugador=0, puntajeoponente=0; // Variables globales
time_t start,finish;
double dif, tiempototal=0;
 
//________________________________________________________________________________________________
void imprimir() // Funcion que imprime el tablero de juego
{  
     
    for(i=1;i<=10;i++) // Imprime el tablero del jugador
    {
        cout<<"\n";
        for(j=1;j<=10;j++)
        {
            if(oponente[i][j]==3)
            { 
                cout<<"  #"; 
            }
            else
            {
                if(oponente[i][j]==2) 
                { 
                    cout<<"  -"; 
                }
                else
                {
                    if(oponente[i][j]==1)
                    { 
                        cout<<"  -"; 
                    }
                    else
                    { 
                        cout<<"  -"; 
                    }
                }
            }                                     
        }
        if(i==3)
        { 
            cout<<"                                         JUGADOR1"; 
        }
        else
        {
            if(i==1)
            { 
                cout<<"                                         Puntaje jugador 1: "<<puntajeoponente; 
            }
        }
    }
    
	
    cout<<"\n\n\n\n_____________________________\n\n";
     
    for(i=1;i<=10;i++) // Imprime el tablero del jugador
    {
        cout<<"\n";
        for(j=1;j<=10;j++)
        {
            if(jugador[i][j]==3)
            { 
                cout<<"  -"; 
            }
            else
            {
                if(jugador[i][j]==2) 
                { 
                    cout<<"  "; 
                }
                else
                {
                    if(jugador[i][j]==1)
                    { 
                        cout<<"  "; 
                    }
                    else
                    { 
                        cout<<"  "; 
                    }
                   /* if (jugador[i][j]==4 ){
                    	
					}else( )*/
                }
            }                                     
        }
        if(i==3)
        { 
            cout<<"                                                   JUGADOR2"; 
        }
        else
        {
            if(i==1)
            { 
                cout<<"                                                   Puntaje jugador 2: "<<puntajejugador; 
            }
        }
    }
  
  
}
 //_______________________________________________________________________________________________
 
void iniciar() 
{
          
    for(i=1;i<=10;i++) 
    {
        for(j=1;j<=10;j++)
        {
            jugador[i][j]=0;
            oponente[i][j]=0;
        }
    }
     
    cout<<"\nCOLOQUEN SUS COORDENADAS \n";
     
    srand(time(NULL));

    for(k=1;k<=5;k++) // Distribuye los barcos
    {
        imprimir();

        cout<<"\nCOORDENADAS OPONENTE 1\n";
        
        cout<<"\n\nX"<<k<<"=";
        cin>>opcion2;
        while(opcion2<1 || opcion2>5)
        { 
            cout<<"    Escoje un valor valido ( 1 a 5 )\n\n\n = "<<k;
            cin>>opcion2;
        }
                         
        cout<<"\n\nY"<<k<<"=";
        cin>>opcion1;
        while(opcion1<1 || opcion1>5)
        { 
             cout<<"\n    Escoje un valor valido ( 1 a 5 )=  ";
            cin>>opcion1; 
        }
                         
        if(oponente[opcion1][opcion2]==1)
        {
            cout<<"\n Ese valor ya existe...";
            getch();
            k=k-1;
        }
        oponente[opcion1][opcion2]=1;


cout<<"\nCOORDENADAS OPONENTE 2\n";
                     
        cout<<"\n\nX"<<k<<"=";
        cin>>opcion2;
        while(opcion2<1 || opcion2>5)
        { 
            cout<<"    Escoje un valor valido ( 1 a 5)\n\n\n = "<<k;
            cin>>opcion2;
        }
                         
        cout<<"\n\nY"<<k<<"=";
        cin>>opcion1;
        while(opcion1<1 || opcion1>5)
        { 
             cout<<"\n    Escoje un valor valido ( 1 a 5 )=  ";
            cin>>opcion1; 
        }
                         
        if(jugador[opcion1][opcion2]==1)
        {
            cout<<"\n Ese valor ya existe...";
            getch();
            k=k-1;
        }
        jugador[opcion1][opcion2]=1;
                       
        system("cls"); 
                                                          
    }   
     
}
 
//________________________________________________________________________________________________
 
int main() // Inicia el programa (main)
{
    int res, auxiliar, probabilidadcpu, destruidosoponente=0, destruidosjugador=0, ganador;
    float dificultadcpu=0.5; 
      
    system("color 0B");
 
    cout<<"\n\n\n                ~JUGUEMOS A : BATALLA NAVAL    <3 ~\n\n                       #\n                       #|\n                       #|#\n                       #|##\n                       #|###\n                       #|####";
    cout<<"\n                       #|#####\n                       #|######\n            ##########################";
    cout<<"\n           ____________________________";
    cout<<"\n           ############################\n             #######################\n               ###################\n                 ##############";
    cout<<"\n\n\n\n                1- JUGAR\n\n                2- SALIR\n\n                Dame tu opcion:";
    cin>>res;
    system("cls");
       
    switch(res)
    { // Eliges la opcion Jugar o Salir
       
       case 1:
       {
           iniciar(); // Llama a la funcion iniciar
           cout<<"\n\n\n\n\n Preparado?\n\n";
           wait(2);
           cout<<"\n\n\n AHORA!!!";
           wait(1);
                              
           do
           {
               time(&start);
               system("cls"); // Limpia la pantalla 
                                
               imprimir();
               
                                
               cout<<" Es tu turno JUGADOR 2! Dame la posicion que deseas atacar~\n\n";
               cout<<"\nX = ";
               cin>>opcion2;
               while(opcion2<1 || opcion2>5)
               { 
                   cout<<"\n    Escoje un valor valido ( 1 a 5 )\n\n\n = ";
                   cin>>opcion2; 
               }
                                
               cout<<"\nY = ";
               cin>>opcion1;
               while(opcion1<1 || opcion1>5)
               { 
                   cout<<"\n    Escoje un valor valido ( 1 a 5 )\n\n\n = ";
                   cin>>opcion1; 
               }
                                
               auxiliar=oponente[opcion1][opcion2];
               oponente[opcion1][opcion2]=3;
               system("cls");
               imprimir();
               oponente[opcion1][opcion2]=auxiliar;                           
                                
               if(oponente[opcion1][opcion2]==1)
               {
                   oponente[opcion1][opcion2]=2;
                   destruidosoponente=destruidosoponente+1;
                   puntajejugador=puntajejugador+200;
                   cout<<"\n El JUGADOR 2 acertado!!\n\n";
               }
               else
               {
                   cout<<"\n El JUGADOR 2 fallado...\n\n";
               }
                                
               system("PAUSE");
               system("cls");
               if(destruidosoponente==5)
               { 
                   cout<<"\n\n\n\n\n\nEl JUGADOR 2 GANO!!";
                   getch();
               }          
			   
			   
			   
			   
			                                                         
               imprimir();
                                
               cout<<" Es tu turno JUGADOR 1! Dame la posicion que deseas atacar~\n\n";
               cout<<"\nX = ";
               cin>>opcion2;
               while(opcion2<1 || opcion2>5)
               { 
                   cout<<"\n    Escoje un valor valido ( 1 a 5 )\n\n\n = ";
                   cin>>opcion2; 
               }
                                
               cout<<"\nY = ";
               cin>>opcion1;
               while(opcion1<1 || opcion1>5)
               { 
                   cout<<"\n    Escoje un valor valido ( 1 a 5 )\n\n\n = ";
                   cin>>opcion1; 
               }
                                
               auxiliar=oponente[opcion1][opcion2];
               oponente[opcion1][opcion2]=3;
               system("cls");
               imprimir();
               oponente[opcion1][opcion2]=auxiliar;                           
                                
               if(oponente[opcion1][opcion2]==1)
               {
                   cout<<"\n El JUGADOR 1 fallado...\n\n";
               }
               else
               {
               	   oponente[opcion1][opcion2]=2;
                   destruidosoponente=destruidosoponente+1;
                   puntajeoponente=puntajeoponente+200;
                   cout<<"\n El JUGADOR 1 acertado!!\n\n";
               }
                                
               system("PAUSE");
               system("cls");
               if(destruidosoponente==5)
               { 
                   cout<<"\n\n\n\n\n\nEl JUGADOR 1 GANO!!";
                   getch();
               }          
               
               
               
           }
           while(destruidosoponente<5 || destruidosjugador<5);
       }
                                
    } // Termina switch(res)
                 
} // Termina el programa (main)
 
 
//________________________________________________________________________________________________
