using System;
using System.Collections.Generic;
using System.Text;

namespace ProcesosAlternos.Diffie_Hellman
{
    class DiffieHellman
    {
        int numP = 89;
        int numG = 65;

        

        public int CrearLlaveA (int p, int g, int a, int b)
        {

            int  A = 0;
           
            int secretA;
            


            for (int i = 0; i < a; i++)
            {
                A = g * a;
            }
          

            secretA = A % p;

            return secretA;

            
        }
        public int CrearLlaveB (int p, int g , int b)
        {
            int B = 0;
            int secretB;
            for (int i = 0; i < b; i++)
            {
                b = g * b;
            }
            secretB = B % p;

            return secretB;
        }

        public void CanalSeguro (int p, int a, int b, int secretA, int secretB)
        {
            int kA = 0;
            int kB = 0;

            for (int i = 0; i < a; i++)
            {
                kA = secretB * a;
            }

            kA = kA % p;

            for (int i = 0; i < b; i++)
            {
                kB = secretA * b;
            }
            kB = kB % p;

            if (kA == kB)
            {
                // es el mismo numero
            }
        }

    }
}
