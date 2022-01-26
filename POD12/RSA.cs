using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace POD12
{
    class RSA
    {
        private uint p, q, n, phi, e, d;
        private uint[] text;
        private BigInteger[] encrypted;
        private BigInteger[] decrypted;

        public RSA(string path,uint p,uint q)
        {
            string temp = System.IO.File.ReadAllText(path);
            text = new uint[temp.Length];
            encrypted= new BigInteger[temp.Length];
            decrypted= new BigInteger[temp.Length];
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = (uint)temp[i];
            }
            this.p = p;
            this.q = q;
            this.n = p * q;
            this.phi = (p - 1)*(q - 1);
            this.e = firsty();
            this.d = dy();
        }
        public RSA(uint n,uint d,string path)
        {
            string temp = System.IO.File.ReadAllText(path);
            encrypted = new BigInteger[temp.Length];
            decrypted= new BigInteger[temp.Length];
            for (int i = 0; i < encrypted.Length; i++)
            {
                encrypted[i] = (uint)temp[i];
            }
            this.n = n;
            this.d = d;
        }
        public uint getN()
        {
            return n;
        }
        public uint getE()
        {
            return e;
        }
        public uint getD()
        {
            return d;
        }
        public uint firsty()
        {
            uint ax,bx, t;
            for (uint i = 2; i < phi; i++)
            {
                ax = i;
                bx = phi;
                while (bx != 0)
                {
                    t = bx;
                    bx = ax % bx;
                    ax = t;
                }
                if (ax == 1) return i;
            }
            return 0;
        }
        public uint dy()
        {
            uint i = 1;
            while (((e * i) - 1) % phi != 0)
            {
                i++;
            }
            return i;
        }
        public static BigInteger IntPow(BigInteger x, uint pow)
        {
            BigInteger ret = 1;
            for (int i = 0; i <= pow; i++)
            {
                if (i == 0) ret = 1;
                else ret *= x;
            }
            return ret;
        }
        public void encrypting()
        {
            for(int i = 0; i < text.Length; i++)
            {
                encrypted[i] = IntPow(text[i], e) % n;
            }
        }
        public void decrypting()
        {
            for (int i = 0; i < encrypted.Length; i++)
            {
                decrypted[i] = IntPow(encrypted[i], d) % n;
            }
        }

        public void saveEncrypted()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\Encrypted.txt");
            for (int i = 0; i < encrypted.Length; i++)
            {
                file.Write(encrypted[i]);
            }
            file.Close();
        }
        public void saveDecrypted()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\Decrypted.txt");
            for (int i = 0; i < decrypted.Length; i++)
            {
                file.Write(decrypted[i]);
            }
            file.Close();
        }
    }
}
